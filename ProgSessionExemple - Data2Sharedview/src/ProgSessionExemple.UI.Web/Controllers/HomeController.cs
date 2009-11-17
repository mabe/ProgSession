using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProgSessionExemple.UI.Web.Models;

namespace ProgSessionExemple.UI.Web.Controllers
{
	public class HomeController : BaseController
	{
		public ActionResult Index()
		{
			ViewData["Message"] = "Welcome to ASP.NET MVC!";
			ViewData["Archive"] = new ProgSessionExemple.UI.Web.Data.ArchiveRepository().Get();
			var model = new ArchiveViewModel() { Archive = new ProgSessionExemple.UI.Web.Data.ArchiveRepository().Get() };

			return View(model);
		}
	}
}
