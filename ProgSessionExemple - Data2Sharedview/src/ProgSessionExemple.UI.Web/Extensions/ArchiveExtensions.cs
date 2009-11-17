using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgSessionExemple.UI.Web.Extensions
{
	public static class ArchiveExtensions
	{
		public static IDictionary<string, short> Archive(this ViewMasterPage view)
		{
			return view.ViewContext.Archive();
		}

		private static IDictionary<string, short> Archive(this ViewContext context)
		{
			return (IDictionary<string, short>)context.ViewData["BaseController.Archive"];
		}
	}
}
