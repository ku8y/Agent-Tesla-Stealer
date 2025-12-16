using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using UHyll;

namespace JSW1fecBOy
{
	// Token: 0x0200006B RID: 107
	public static class g3Vt7T2gk5
	{
		// Token: 0x060001F0 RID: 496 RVA: 0x00029878 File Offset: 0x00027A78
		public static byte[] 83xr(string r88xtWY)
		{
			int num = 0;
			byte[] array;
			for (;;)
			{
				if (num == 7)
				{
					goto IL_1F;
				}
				goto IL_3D;
				IL_E7:
				int num2;
				if (num == 6)
				{
					num2++;
					num = 7;
				}
				string s;
				if (num == 5)
				{
					array[num2] = byte.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
					num = 6;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 8)
				{
					break;
				}
				continue;
				IL_3D:
				if (num == 1)
				{
					array = new byte[r88xtWY.Length / 2];
					num = 2;
				}
				if (num == 2)
				{
					num2 = 0;
					num = 3;
				}
				if (num != 3)
				{
					if (num == 4)
					{
						goto IL_C2;
					}
					goto IL_E7;
				}
				IL_1F:
				if (num2 > array.Length - 1)
				{
					num = 8;
					goto IL_3D;
				}
				IL_C2:
				s = r88xtWY.Substring(num2 * 2, 2);
				num = 5;
				goto IL_E7;
			}
			return array;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00029A04 File Offset: 0x00027C04
		public static void awtLzZ7zx<T>(ref T[] 8mqQ8jdj, int LSJ7QQjCU)
		{
			int num = 0;
			for (;;)
			{
				T[] array;
				if (num == 10)
				{
					8mqQ8jdj = array;
					num = 11;
				}
				if (num == 6)
				{
					break;
				}
				if (num == 8)
				{
					Array.Copy(8mqQ8jdj, 0, array, 0, LSJ7QQjCU);
					num = 9;
				}
				int upperBound;
				if (num == 1)
				{
					upperBound = 8mqQ8jdj.GetUpperBound(0);
					num = 2;
				}
				if (num == 9)
				{
					Array.Copy(8mqQ8jdj, LSJ7QQjCU + 1, array, LSJ7QQjCU, upperBound - LSJ7QQjCU);
					num = 10;
				}
				if (num != 5)
				{
					goto IL_124;
				}
				if (LSJ7QQjCU > upperBound)
				{
					num = 6;
					goto IL_124;
				}
				goto IL_183;
				IL_1A5:
				int lowerBound;
				if (num == 2)
				{
					lowerBound = 8mqQ8jdj.GetLowerBound(0);
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 11)
				{
					return;
				}
				continue;
				IL_124:
				int num2;
				if (num == 3)
				{
					num2 = upperBound - lowerBound;
					num = 4;
				}
				if (num == 4)
				{
					if (LSJ7QQjCU < lowerBound)
					{
						break;
					}
					num = 5;
				}
				if (num != 7)
				{
					goto IL_1A5;
				}
				IL_183:
				array = new T[num2 - 1 + 1];
				num = 8;
				goto IL_1A5;
			}
			throw new ArgumentOutOfRangeException("");
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00029C1C File Offset: 0x00027E1C
		public static void RJR(string 0Rh)
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
			try
			{
				if (File.Exists(0Rh))
				{
					FNu.DeleteFile(0Rh + ":Zone.Identifier");
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00029CB0 File Offset: 0x00027EB0
		public static string lX1xTKPz()
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
			string result;
			try
			{
				uint num2;
				uint num3;
				uint num4;
				FNu.GetVolumeInformation(Environment.GetEnvironmentVariable("SystemDrive") + "\\", null, 0, out num2, out num3, out num4, null, 0);
				result = num2.ToString("X");
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00029D78 File Offset: 0x00027F78
		public static string 1b9(string TKmNZR, string d5PWntgeqi, string 8a62L1X98r, int LslUr8)
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
			string result;
			try
			{
				string input = Regex.Split(TKmNZR, d5PWntgeqi)[LslUr8 + 1];
				result = Regex.Split(input, 8a62L1X98r)[0];
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00029E2C File Offset: 0x0002802C
		public static string[] o1a9sIqIfKj(this string vIgAcjbb, string uzaTHDthvSC)
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
			return vIgAcjbb.Split(new string[]
			{
				uzaTHDthvSC
			}, StringSplitOptions.None);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00029EAC File Offset: 0x000280AC
		public static string eCqZ9sy(byte[] DWMZ)
		{
			int num = 0;
			StringBuilder stringBuilder;
			for (;;)
			{
				if (num == 2)
				{
					num = 3;
				}
				if (num == 4)
				{
					goto IL_AA;
				}
				if (num == 5)
				{
					goto IL_60;
				}
				goto IL_76;
				IL_C2:
				if (num == 1)
				{
					stringBuilder = new StringBuilder();
					num = 2;
				}
				byte b;
				if (num == 6)
				{
					stringBuilder.AppendFormat("{0:X2}", b);
					num = 7;
				}
				int num2;
				if (num == 7)
				{
					num2++;
					num = 8;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 9)
				{
					break;
				}
				continue;
				IL_76:
				if (num == 3)
				{
					num2 = 0;
					num = 4;
				}
				if (num != 8)
				{
					goto IL_C2;
				}
				IL_AA:
				if (num2 >= DWMZ.Length)
				{
					num = 9;
					goto IL_C2;
				}
				IL_60:
				b = DWMZ[num2];
				num = 6;
				goto IL_76;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0002A03C File Offset: 0x0002823C
		public static byte[] 6RprJ(byte[] PgB3CAqlF, byte[] ku2hGQG0kd0)
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
			byte[] result;
			try
			{
				byte[] array = new byte[PgB3CAqlF.Length + ku2hGQG0kd0.Length - 1 + 1];
				Array.Copy(PgB3CAqlF, array, PgB3CAqlF.Length);
				Array.Copy(ku2hGQG0kd0, 0, array, PgB3CAqlF.Length, ku2hGQG0kd0.Length);
				result = array;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0002A10C File Offset: 0x0002830C
		public static string Q4YnB9Kv(string zmg, string BdIoZSGsNc, string U2NqKyGp)
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
			return zmg.Split(new string[]
			{
				BdIoZSGsNc
			}, StringSplitOptions.None)[1].Split(new string[]
			{
				U2NqKyGp
			}, StringSplitOptions.None)[0];
		}
	}
}
