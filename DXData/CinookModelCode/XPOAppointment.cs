using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DXData.Chinook
{

	public partial class XPOAppointment
	{
		public XPOAppointment(Session session) : base(session) { }
		public override void AfterConstruction() { base.AfterConstruction(); }
	}

}
