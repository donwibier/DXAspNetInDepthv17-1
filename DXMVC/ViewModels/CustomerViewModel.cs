using DXData.Chinook;
using DXMVC.Controllers;
using System;

namespace DXMVC.ViewModels
{
	public class CustomerViewModel : BaseViewModel<XPOCustomer, int>
	{
		public CustomerViewModel()
		{
		}
		public override int ID { get => CustomerId; set => CustomerId = value; }
		public string Company { get; set; }
		public int CustomerId { get; set; }
		public string DisplayText { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public override void GetData(XPOCustomer model)
		{
			model.Company = this.Company;
			model.CustomerId = this.CustomerId;
			//model.DisplayText { get; set; }
			model.FirstName = this.FirstName;
			model.LastName = this.LastName;

		}
	}
}

