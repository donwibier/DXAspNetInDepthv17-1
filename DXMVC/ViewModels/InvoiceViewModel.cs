using DX.Data.Xpo.Identity;
using DXData.Chinook;
using DXMVC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXMVC.ViewModels
{
	public class InvoiceViewModel : BaseViewModel<XPOInvoice>
	{
		public override int ID { get => InvoiceId; set => InvoiceId = value; }

		public int InvoiceId { get; set; }
		public int CustomerId { get; set; }
		//public CustomerViewModel Customer{get; set;}
		//public CustomerViewModel CustomerId
		public DateTime InvoiceDate { get; set; }
		public string BillingAddress { get; set; }
		public string BillingCity { get; set; }
		public string BillingState { get; set; }
		public string BillingCountry { get; set; }
		public string BillingPostalCode { get; set; }
		public decimal Total { get; set; }

		//public XPCollection<XPOInvoiceLine> InvoiceLines { get { return GetCollection<XPOInvoiceLine>("InvoiceLines"); } }
		public override void GetData(XPOInvoice model)
		{
			model.InvoiceId = this.InvoiceId;
			model.CustomerId = (this.CustomerId <= 0) ? null : model.Session.GetObjectByKey<XPOCustomer>(this.CustomerId);
			model.InvoiceDate = this.InvoiceDate;
			model.BillingAddress = this.BillingAddress;
			model.BillingCity = this.BillingCity;
			model.BillingState = this.BillingState;
			model.BillingCountry = this.BillingCountry;
			model.BillingPostalCode = this.BillingPostalCode;
			model.Total = this.Total;
		}
	}
}