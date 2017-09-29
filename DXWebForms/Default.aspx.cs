using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DXWebForms.Code;
using DevExpress.Xpo;

namespace DXWebForms
{
	public partial class Default : System.Web.UI.Page
	{
		private Session _sess = null;
		protected Session XpoSession
		{
			get
			{
				if (_sess == null)
					_sess = AppDataContext.GetSession(true);
				return _sess;
			}
		}
		

		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void xpDatasource_Init(object sender, EventArgs e)
		{
			((XpoDataSource)sender).Session = this.XpoSession;
		}

		protected void grid_RowDeleted(object sender, DevExpress.Web.Data.ASPxDataDeletedEventArgs e)
		{
			AppDataContext.Commit(_sess);
		}

		protected void grid_RowInserted(object sender, DevExpress.Web.Data.ASPxDataInsertedEventArgs e)
		{
			AppDataContext.Commit(_sess);
		}

		protected void grid_RowUpdated(object sender, DevExpress.Web.Data.ASPxDataUpdatedEventArgs e)
		{
			AppDataContext.Commit(_sess);
		}
	}
}