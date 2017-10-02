using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DX.Data.Xpo;

namespace DXData.Chinook
{	
	public partial class XPOInvoice
	{
		public XPOInvoice(Session session) : base(session) { }
		public override void AfterConstruction() { base.AfterConstruction(); }
	}

}
