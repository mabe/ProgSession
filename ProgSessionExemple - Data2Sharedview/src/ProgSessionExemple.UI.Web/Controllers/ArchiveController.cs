using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace ProgSessionExemple.UI.Web.Controllers
{
    public class ArchiveController : Controller
    {

        public ActionResult List()
        {
			return View(new ProgSessionExemple.UI.Web.Data.ArchiveRepository().Get());
        }

    }
}
