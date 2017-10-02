using DevExpress.Xpo;
using DevExpress.Xpo.DB.Exceptions;
using DX.Data.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DXMVC.Controllers
{
	public class AppDataContext
	{
		static readonly XpoDatabase _ctx = new XpoDatabase("DefaultConnection");
		public static XpoDatabase Get()
		{
			return _ctx;
		}

		public static Session GetSession(bool transactional = false)
		{
			return transactional ? _ctx.GetUnitOfWork() : _ctx.GetSession();
		}

		public static UnitOfWork GetUnitOfWork()
		{
			return _ctx.GetUnitOfWork();
		}

		public static void Commit(object obj)
		{
			if (obj == null)
				return;

			UnitOfWork wrk = obj as UnitOfWork;
			if (wrk != null)
			{
				wrk.CommitChanges();
				return;
			}

			IXPSimpleObject dataObject = obj as IXPSimpleObject;
			if (obj != null)
			{
				wrk = dataObject.Session as UnitOfWork;
				if (wrk != null)
					wrk.CommitChanges();
				else
					dataObject.Session.Save(dataObject);
			}
		}

		public static void Rollback(object obj)
		{
			UnitOfWork wrk = obj as UnitOfWork;
			if (wrk != null)
			{
				wrk.CommitChanges();
				return;
			}

			IXPSimpleObject dataObject = obj as IXPSimpleObject;
			if (obj != null)
			{
				wrk = dataObject.Session as UnitOfWork;
				if (wrk != null)
					wrk.RollbackTransaction();
			}
		}
	}

	public abstract class BaseViewModel<TXpoModel, TKey>
	{
		TKey id = default(TKey);
		public virtual TKey ID
		{
			get { return id; }
			set { id = value; }
		}

		public abstract void GetData(TXpoModel model);
	}

	public abstract class BaseViewModel<TXpoModel>: BaseViewModel<TXpoModel, int>
	{
	}

	public abstract class XpoBaseController<T> : Controller 
		where T : IXPSimpleObject
	{
		private Session _sess = null;

		public XpoBaseController() : base()
		{
		}

		protected Session XpoSession
		{
			get
			{
				if (_sess == null)
					_sess = AppDataContext.GetSession(true);
				return _sess;
			}
		}

		public void XpoCommit(object obj)
		{
			AppDataContext.Commit(obj);
		}

		public void XpoRollback(object obj)
		{
			AppDataContext.Rollback(obj);
		}

		bool Save(BaseViewModel<T> viewModel, object key, bool delete)
		{
			T model = XpoSession.GetObjectByKey<T>(key);
			if (model == null && !delete)
				model = (T)XpoSession.GetClassInfo<T>().CreateNewObject(XpoSession);
			if (!delete)
				viewModel.GetData(model);
			else if (model != null)
				XpoSession.Delete(model);
			try
			{
				XpoCommit(model);				
				return true;
			}
			catch (LockingException) { return false; }
		}

		protected bool Save(BaseViewModel<T> viewModel, object key)
		{
			return Save(viewModel, key, false);
		}

		protected bool Delete(BaseViewModel<T> viewModel, object key)
		{
			return Save(viewModel,key, true);
		}
	}
}