using DevExpress.Web.Mvc;
using DXData.Chinook;
using DXMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Xpo;


namespace DXMVC.Controllers
{
	public class HomeController : XpoBaseController<XPOInvoice>
	{
		IEnumerable<InvoiceViewModel> GetItems()
		{
			var result = (from c in XpoSession.Query<XPOInvoice>().ToList()
					select new InvoiceViewModel()
					{
						InvoiceId = c.InvoiceId,
						CustomerId = (c.CustomerId == null) ? 0 : (c.CustomerKey),
						InvoiceDate = c.InvoiceDate,
						BillingAddress = c.BillingAddress,
						BillingCity = c.BillingCity,
						BillingState = c.BillingState,
						BillingCountry = c.BillingCountry,
						BillingPostalCode = c.BillingPostalCode,
						Total = c.Total
					}).ToList();
			return result;
		}

		IEnumerable<CustomerViewModel> GetCustomers()
		{
			var result = (from c in XpoSession.Query<XPOCustomer>().ToList()
						  select new CustomerViewModel()
						  {
							  CustomerId = c.CustomerId,
							  DisplayText = String.Format("{0}, {1}", c.LastName, c.FirstName),
							  FirstName = c.FirstName,
							  LastName = c.LastName,
							  Company = c.Company
						  }
						  ).ToList();
			return result;
		}

		// GET: Home
		public ActionResult Index()
		{
			ViewBag.LookupCustomers = GetCustomers();
			return View(GetItems());
		}

		[ValidateInput(false)]
		public ActionResult GridPartial()
		{
			ViewBag.LookupCustomers = GetCustomers();
			return PartialView("_GridPartial", GetItems());
		}
		
		[HttpPost]
		public ActionResult EditInvoice([ModelBinder(typeof(DevExpressEditorsBinder))] InvoiceViewModel invoice)
		{
			Save(invoice, invoice.InvoiceId);
			ViewBag.LookupCustomers = GetCustomers();
			return PartialView("_GridPartial", GetItems());
		}

		[HttpPost]
		public ActionResult DeleteInvoice([ModelBinder(typeof(DevExpressEditorsBinder))] InvoiceViewModel invoice)
		{
			Delete(invoice, invoice.InvoiceId);
			ViewBag.LookupCustomers = GetCustomers();
			return PartialView("_GridPartial", GetItems());
		}
	}
}
