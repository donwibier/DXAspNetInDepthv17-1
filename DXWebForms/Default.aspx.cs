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
	public partial class Default : XpoWebPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void xpDatasource_Init(object sender, EventArgs e)
		{
			((XpoDataSource)sender).Session = this.XpoSession;
		}

		protected void grid_RowDeleted(object sender, DevExpress.Web.Data.ASPxDataDeletedEventArgs e)
		{
			XpoCommit(this.XpoSession);
		}

		protected void grid_RowInserted(object sender, DevExpress.Web.Data.ASPxDataInsertedEventArgs e)
		{
			XpoCommit(this.XpoSession);
		}

		protected void grid_RowUpdated(object sender, DevExpress.Web.Data.ASPxDataUpdatedEventArgs e)
		{
			XpoCommit(this.XpoSession);
		}
	}
}