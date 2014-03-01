using cfbInfo.DAL;
using cfbInfo.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace cfbInfo.Web.Controllers
{
	public class SearchController : Controller
	{
        Context db = new Context();

		//
		// GET: /Search/
		public ActionResult Index()
		{
			return View();
		}


        public ActionResult Results(string value)
        {
            if (value == null)
            {
                return View();
            }

            var searchViewModel = new SearchViewModel(value, db);

            if (searchViewModel == null)
            {
                return Index();
            }
            return View(searchViewModel);
        }
	}
}