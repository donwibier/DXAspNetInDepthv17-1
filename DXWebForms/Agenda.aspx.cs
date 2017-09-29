using DevExpress.Web.ASPxScheduler;
using DevExpress.Xpo;
using DevExpress.XtraScheduler;
using DXData.Chinook;
using DXWebForms.Code;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXWebForms
{
	public partial class Agenda : XpoWebPage
	{
		void ProvideRowInsertion()
		{
			XPORowInsertionProvider aptProvider = new XPORowInsertionProvider();
			aptProvider.ProvideRowInsertion(ASPxScheduler1, this.XpoAppointments, this.XpoSession as UnitOfWork);
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			ProvideRowInsertion();
			if (!IsPostBack)
			{
				ASPxScheduler1.DataBind();
			}
		}
		protected void xpDatasource_Init(object sender, EventArgs e)
		{
			((XpoDataSource)sender).Session = this.XpoSession;
		}

		protected void ASPxScheduler1_ResourcesInserted(object sender, PersistentObjectsEventArgs e)
		{
			this.XpoCommit(this.XpoSession);
		}

		protected void ASPxScheduler1_ResourcesDeleted(object sender, PersistentObjectsEventArgs e)
		{
			this.XpoCommit(this.XpoSession);
		}

		protected void ASPxScheduler1_ResourcesChanged(object sender, PersistentObjectsEventArgs e)
		{
			this.XpoCommit(this.XpoSession);
		}

		protected void ASPxScheduler1_AppointmentsInserted(object sender, PersistentObjectsEventArgs e)
		{
			this.XpoCommit(this.XpoSession);

		}

		protected void ASPxScheduler1_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e)
		{
			this.XpoCommit(this.XpoSession);

		}

		protected void ASPxScheduler1_AppointmentsChanged(object sender, PersistentObjectsEventArgs e)
		{
			this.XpoCommit(this.XpoSession);

		}


		public class XPORowInsertionProvider
		{
			List<int> insertedAppointmentsId = new List<int>();
			ASPxScheduler control;
			UnitOfWork unitOfWork;
			public void ProvideRowInsertion(ASPxScheduler control, XpoDataSource dataSource, UnitOfWork unitOfWork)
			{
				this.control = control;
				this.unitOfWork = unitOfWork;
				control.AppointmentRowInserted += new ASPxSchedulerDataInsertedEventHandler(ASPxScheduler1_AppointmentRowInserted);
				dataSource.Inserted += new XpoDataSourceInsertedEventHandler(dataSource_OnInserted);
				control.AppointmentsInserted += new PersistentObjectsEventHandler(ControlOnAppointmentsInserted);
			}
			void dataSource_OnInserted(object sender, XpoDataSourceInsertedEventArgs e)
			{
				//((XPObject)e.Value).Save();
				this.unitOfWork.CommitChanges();
				this.insertedAppointmentsId.Add(((XPOAppointment)e.Value).UniqueID);
			}
			protected void ASPxScheduler1_AppointmentRowInserted(object sender, ASPxSchedulerDataInsertedEventArgs e)
			{
				e.KeyFieldValue = this.insertedAppointmentsId[this.insertedAppointmentsId.Count - 1];
			}
			void ControlOnAppointmentsInserted(object sender, PersistentObjectsEventArgs e)
			{
				int count = e.Objects.Count;
				System.Diagnostics.Debug.Assert(count == insertedAppointmentsId.Count);
				SetAppointmentsId(sender, e);
			}
			void SetAppointmentsId(object sender, PersistentObjectsEventArgs e)
			{
				AppointmentBaseCollection appointments = (AppointmentBaseCollection)e.Objects;
				ASPxSchedulerStorage storage = (ASPxSchedulerStorage)sender;
				int count = appointments.Count;
				System.Diagnostics.Debug.Assert(count == insertedAppointmentsId.Count);
				for (int i = 0; i < count; i++)
				{
					Appointment apt = appointments[i];
					storage.SetAppointmentId(apt, insertedAppointmentsId[i]);
				}
				insertedAppointmentsId.Clear();
			}
		}
	}
}