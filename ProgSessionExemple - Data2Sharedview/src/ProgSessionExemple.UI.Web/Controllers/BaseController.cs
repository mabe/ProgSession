using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace ProgSessionExemple.UI.Web.Controllers
{
	[HandleError]
    public class BaseController : Controller
    {
		public BaseController()
		{
			Archive = new ProgSessionExemple.UI.Web.Data.ArchiveRepository().Get();
		}

		public IDictionary<string, short> Archive { set { ViewData["BaseController.Archive"] = value; } }
    }
}
