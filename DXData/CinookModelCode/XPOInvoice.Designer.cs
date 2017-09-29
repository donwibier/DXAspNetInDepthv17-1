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

	[Persistent(@"Invoice")]
	public partial class XPOInvoice : XPLiteObject
	{
		int _InvoiceId;
		[Key(true)]
		public int InvoiceId
		{
			get { return _InvoiceId; }
			set { SetPropertyValue<int>("InvoiceId", ref _InvoiceId, value); }
		}
		XPOCustomer _CustomerId;
		[Association(@"XPOInvoiceReferencesXPOCustomer")]
		public XPOCustomer CustomerId
		{
			get { return _CustomerId; }
			set { SetPropertyValue<XPOCustomer>("CustomerId", ref _CustomerId, value); }
		}
		DateTime _InvoiceDate;
		public DateTime InvoiceDate
		{
			get { return _InvoiceDate; }
			set { SetPropertyValue<DateTime>("InvoiceDate", ref _InvoiceDate, value); }
		}
		string _BillingAddress;
		[Size(70)]
		public string BillingAddress
		{
			get { return _BillingAddress; }
			set { SetPropertyValue<string>("BillingAddress", ref _BillingAddress, value); }
		}
		string _BillingCity;
		[Size(40)]
		public string BillingCity
		{
			get { return _BillingCity; }
			set { SetPropertyValue<string>("BillingCity", ref _BillingCity, value); }
		}
		string _BillingState;
		[Size(40)]
		public string BillingState
		{
			get { return _BillingState; }
			set { SetPropertyValue<string>("BillingState", ref _BillingState, value); }
		}
		string _BillingCountry;
		[Size(40)]
		public string BillingCountry
		{
			get { return _BillingCountry; }
			set { SetPropertyValue<string>("BillingCountry", ref _BillingCountry, value); }
		}
		string _BillingPostalCode;
		[Size(10)]
		public string BillingPostalCode
		{
			get { return _BillingPostalCode; }
			set { SetPropertyValue<string>("BillingPostalCode", ref _BillingPostalCode, value); }
		}
		decimal _Total;
		public decimal Total
		{
			get { return _Total; }
			set { SetPropertyValue<decimal>("Total", ref _Total, value); }
		}
		[Association(@"XPOInvoiceLineReferencesXPOInvoice")]
		public XPCollection<XPOInvoiceLine> InvoiceLines { get { return GetCollection<XPOInvoiceLine>("InvoiceLines"); } }
	}

}
