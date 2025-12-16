using System;
using System.Collections.Generic;
using System.IO;

namespace rCOGWW
{
	// Token: 0x02000053 RID: 83
	public class w3uoxlrf : Dictionary<string, Dictionary<string, string>>
	{
		// Token: 0x06000187 RID: 391 RVA: 0x00007789 File Offset: 0x00005989
		public w3uoxlrf()
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00007791 File Offset: 0x00005991
		public w3uoxlrf(string filename)
		{
			this.hM2BAOOJRl(filename);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00020204 File Offset: 0x0001E404
		public void hM2BAOOJRl(string A8vLNZ7kwCa)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.h0Y1Jvs(File.ReadAllLines(A8vLNZ7kwCa));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00020284 File Offset: 0x0001E484
		public void ULlXEXipk(string ccOjPm1L)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.h0Y1Jvs(ccOjPm1L.Split(new string[]
					{
						Environment.NewLine
					}, StringSplitOptions.None));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00020328 File Offset: 0x0001E528
		public void sVSM2(string[] dEPTQAwG)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.h0Y1Jvs(dEPTQAwG);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000203A0 File Offset: 0x0001E5A0
		private void h0Y1Jvs(string[] WagS7nJUsku)
		{
			int num = 0;
			for (;;)
			{
				string text;
				int num2;
				if (num == 14)
				{
					num2 = text.IndexOf('=');
					num = 15;
				}
				if (num != 9)
				{
					goto IL_66;
				}
				string key;
				if (!base.ContainsKey(key))
				{
					num = 10;
					goto IL_66;
				}
				goto IL_E0;
				IL_F7:
				if (num != 6)
				{
					goto IL_129;
				}
				if (text.StartsWith("["))
				{
					num = 7;
					goto IL_129;
				}
				goto IL_205;
				IL_226:
				if (num == 13)
				{
					if (!text.Contains("="))
					{
						goto IL_E0;
					}
					num = 14;
				}
				int num3;
				if (num == 3)
				{
					num3 = 0;
					num = 4;
				}
				if (num == 7)
				{
					if (!text.EndsWith("]"))
					{
						goto IL_205;
					}
					num = 8;
				}
				if (num == 15)
				{
					base[key][text.Substring(0, num2).TrimEnd(new char[]
					{
						' '
					})] = text.Substring(num2 + 1, text.Length - num2 - 1).TrimEnd(new char[]
					{
						' '
					});
					num = 16;
				}
				if (num == 10)
				{
					base.Add(key, new Dictionary<string, string>());
					num = 11;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 18)
				{
					break;
				}
				continue;
				IL_129:
				if (num == 8)
				{
					key = text.Substring(1, text.Length - 2).TrimEnd(new char[]
					{
						' '
					});
					num = 9;
				}
				if (num == 17)
				{
					goto IL_19B;
				}
				IL_1B3:
				if (num != 4)
				{
					if (num == 2)
					{
						num = 3;
					}
					if (num == 12)
					{
						goto IL_205;
					}
					goto IL_226;
				}
				IL_19B:
				if (num3 >= WagS7nJUsku.Length)
				{
					num = 18;
					goto IL_1B3;
				}
				goto IL_77;
				IL_205:
				if (!text.StartsWith(";"))
				{
					num = 13;
					goto IL_226;
				}
				goto IL_E0;
				IL_8D:
				if (num == 1)
				{
					key = string.Empty;
					num = 2;
				}
				if (num == 11)
				{
					goto IL_E0;
				}
				if (num == 16)
				{
					goto IL_E0;
				}
				goto IL_F7;
				IL_66:
				if (num == 5)
				{
					goto IL_77;
				}
				goto IL_8D;
				IL_E0:
				num3++;
				num = 17;
				goto IL_F7;
				IL_77:
				text = WagS7nJUsku[num3];
				num = 6;
				goto IL_8D;
			}
		}
	}
}
