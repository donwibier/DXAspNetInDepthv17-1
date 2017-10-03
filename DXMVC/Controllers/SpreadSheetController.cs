using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DXMVC.Controllers
{
    public class SpreadSheetController : Controller
    {
        // GET: SpreadSheet
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult SpreadsheetPartial()
		{
			return PartialView("_SpreadsheetPartial");
		}
	}
}