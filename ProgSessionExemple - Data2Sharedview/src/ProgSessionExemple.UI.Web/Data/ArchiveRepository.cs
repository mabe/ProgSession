using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace ProgSessionExemple.UI.Web.Data
{
	public class ArchiveRepository
	{
		public IDictionary<string, short> Get()
		{
			var archive = new Dictionary<string, short>();

			for (int i = 1; i <= DateTime.Now.Month; i++)
			{
				archive.Add(CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[i - 1], (short)DateTime.DaysInMonth(DateTime.Now.Year, i));
			}

			return archive;
		}
	}
}
