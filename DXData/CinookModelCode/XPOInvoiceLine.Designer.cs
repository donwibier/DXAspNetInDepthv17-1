﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DXData.Chinook
{

	[Persistent(@"InvoiceLine")]
	public partial class XPOInvoiceLine : XPLiteObject
	{
		int _InvoiceLineId;
		[Key(true)]
		public int InvoiceLineId
		{
			get { return _InvoiceLineId; }
			set { SetPropertyValue<int>("InvoiceLineId", ref _InvoiceLineId, value); }
		}
		XPOInvoice _InvoiceId;
		[Association(@"XPOInvoiceLineReferencesXPOInvoice")]
		public XPOInvoice InvoiceId
		{
			get { return _InvoiceId; }
			set { SetPropertyValue<XPOInvoice>("InvoiceId", ref _InvoiceId, value); }
		}
		XPOTrack _TrackId;
		[Association(@"XPOInvoiceLineReferencesXPOTrack")]
		public XPOTrack TrackId
		{
			get { return _TrackId; }
			set { SetPropertyValue<XPOTrack>("TrackId", ref _TrackId, value); }
		}
		decimal _UnitPrice;
		public decimal UnitPrice
		{
			get { return _UnitPrice; }
			set { SetPropertyValue<decimal>("UnitPrice", ref _UnitPrice, value); }
		}
		int _Quantity;
		public int Quantity
		{
			get { return _Quantity; }
			set { SetPropertyValue<int>("Quantity", ref _Quantity, value); }
		}
	}

}
