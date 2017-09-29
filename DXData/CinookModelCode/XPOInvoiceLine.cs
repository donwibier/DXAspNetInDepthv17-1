using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DXData.Chinook
{

	public partial class XPOInvoiceLine
	{
		public XPOInvoiceLine(Session session) : base(session) { }
		public override void AfterConstruction() { base.AfterConstruction(); }
	}

}
