using DevExpress.Xpo;
using DX.Data.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace DXWebForms.Code
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

	public static class XpoExtensions
	{
		public static Session XpoSession(this TemplateControl handler, bool transactional = false)
		{
			return AppDataContext.GetSession(transactional);
		}

		public static void XpoCommit(this TemplateControl handler, object obj)
		{
			AppDataContext.Commit(obj);
		}

		public static void XpoRollback(this TemplateControl handler, object obj)
		{
			AppDataContext.Rollback(obj);
		}
	}
}