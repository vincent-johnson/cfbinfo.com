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
                return RedirectToAction("Index");
            }

            var searchViewModel = new SearchViewModel(value);

            if (searchViewModel.ReturnConferences.Count() == 0 && searchViewModel.ReturnPlayers.Count() == 0 && searchViewModel.ReturnTeams.Count() == 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(searchViewModel);
            }
        }
	}
}