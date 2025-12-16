using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using S5j;

namespace rCOGWW
{
	// Token: 0x02000055 RID: 85
	public class btrVogW
	{
		// Token: 0x06000195 RID: 405 RVA: 0x00020DCC File Offset: 0x0001EFCC
		public btrVogW(string baseName)
		{
			if (File.Exists(baseName))
			{
				this.4Io0C7JAWtc = this.cDly16fYU0V(baseName);
				if (this.4Io0C7JAWtc == null || this.4Io0C7JAWtc.Length < 1)
				{
					return;
				}
				if (Encoding.Default.GetString(this.4Io0C7JAWtc, 0, 15).CompareTo("SQLite format 3") != 0)
				{
					return;
				}
				if (this.4Io0C7JAWtc[52] != 0)
				{
					return;
				}
				this.q6YeGtqOSc = (ushort)this.KOSpM9gE(16, 2);
				this.qDfr = this.KOSpM9gE(56, 4);
				if (decimal.Compare(new decimal(this.qDfr), 0m) == 0)
				{
					this.qDfr = 1UL;
				}
				this.UhiKkGt(100UL);
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00020EA8 File Offset: 0x0001F0A8
		private byte[] cDly16fYU0V(string 10yrGZnRqf)
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
				byte[] array = null;
				using (FileStream fileStream = new FileStream(10yrGZnRqf, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					array = new byte[fileStream.Length - 1L + 1L];
					fileStream.Read(array, 0, Convert.ToInt32(fileStream.Length));
				}
				result = array;
			}
			catch
			{
				result = p3H.bjUl(10yrGZnRqf);
			}
			return result;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00020FB4 File Offset: 0x0001F1B4
		private ulong KOSpM9gE(int hxGK, int LOR)
		{
			int num = 0;
			while (num != 2)
			{
				if (num == 1)
				{
					if (!(LOR > 8 | LOR == 0))
					{
						goto IL_9B;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 3)
				{
					continue;
				}
				IL_9B:
				ulong num2 = 0UL;
				int num3 = LOR - 1;
				for (int i = 0; i <= num3; i++)
				{
					num2 = (num2 << 8 | (ulong)this.4Io0C7JAWtc[hxGK + i]);
				}
				return num2;
			}
			return 0UL;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000210C4 File Offset: 0x0001F2C4
		private long CtA2d3TzOj(int 6QN, int cajiQSYxvKV)
		{
			int num = 0;
			while (num != 6)
			{
				int num2;
				if (num == 5)
				{
					if (!(num2 == 0 | num2 > 9))
					{
						goto IL_E8;
					}
					num = 6;
				}
				byte[] array;
				if (num == 2)
				{
					array = new byte[8];
					num = 3;
				}
				bool flag;
				if (num == 4)
				{
					flag = false;
					num = 5;
				}
				if (num == 3)
				{
					num2 = cajiQSYxvKV - 6QN;
					num = 4;
				}
				if (num != 7)
				{
					if (num == 1)
					{
						cajiQSYxvKV++;
						num = 2;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 8)
					{
						goto IL_18B;
					}
					continue;
				}
				IL_E8:
				if (num2 == 1)
				{
					array[0] = (this.4Io0C7JAWtc[6QN] & 127);
					return BitConverter.ToInt64(array, 0);
				}
				IL_18B:
				if (num2 == 9)
				{
					flag = true;
				}
				int num3 = 1;
				int num4 = 7;
				int num5 = 0;
				if (flag)
				{
					array[0] = this.4Io0C7JAWtc[cajiQSYxvKV - 1];
					cajiQSYxvKV--;
					num5 = 1;
				}
				for (int i = cajiQSYxvKV - 1; i >= 6QN; i += -1)
				{
					if (i - 1 >= 6QN)
					{
						array[num5] = (byte)(((int)((byte)(this.4Io0C7JAWtc[i] >> (num3 - 1 & 7))) & 255 >> num3) | (int)((byte)(this.4Io0C7JAWtc[i - 1] << (num4 & 7))));
						num3++;
						num5++;
						num4--;
					}
					else if (!flag)
					{
						array[num5] = (byte)((int)((byte)(this.4Io0C7JAWtc[i] >> (num3 - 1 & 7))) & 255 >> num3);
					}
				}
				return BitConverter.ToInt64(array, 0);
			}
			return 0L;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00021404 File Offset: 0x0001F604
		public int unm()
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
			return this.Hpxv9MP.Length;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00021460 File Offset: 0x0001F660
		public string[] LVZowkRvZWX()
		{
			int num = 0;
			List<string> list;
			for (;;)
			{
				if (num == 7)
				{
					goto IL_1F;
				}
				IL_36:
				int num2;
				if (num == 6)
				{
					list.Add(this.c826[num2].wRQ3);
					num = 7;
				}
				if (num == 1)
				{
					list = new List<string>();
					num = 2;
				}
				int num3;
				if (num == 2)
				{
					num3 = this.c826.Length - 1;
					num = 3;
				}
				if (num == 4)
				{
					goto IL_F2;
				}
				if (num == 8)
				{
					goto IL_F2;
				}
				goto IL_108;
				IL_170:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 9)
				{
					break;
				}
				continue;
				IL_108:
				if (num == 3)
				{
					num2 = 0;
					num = 4;
				}
				if (num != 5)
				{
					goto IL_170;
				}
				IL_13C:
				if (this.c826[num2].CH0us == "table")
				{
					num = 6;
					goto IL_170;
				}
				goto IL_1F;
				IL_F2:
				if (num2 > num3)
				{
					num = 9;
					goto IL_108;
				}
				goto IL_13C;
				IL_1F:
				num2++;
				num = 8;
				goto IL_36;
			}
			return list.ToArray();
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0002161C File Offset: 0x0001F81C
		public string 68OQjJrpl(int Bjn6PrH0i, int mo5k)
		{
			int num = 0;
			while (num != 2)
			{
				if (num != 3)
				{
					if (num == 1)
					{
						if (Bjn6PrH0i < this.Hpxv9MP.Length)
						{
							goto IL_3B;
						}
						num = 2;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 4)
					{
						goto IL_CC;
					}
					continue;
				}
				IL_3B:
				if (mo5k >= this.Hpxv9MP[Bjn6PrH0i].ktwrk6jufAF.Length)
				{
					return null;
				}
				IL_CC:
				return this.Hpxv9MP[Bjn6PrH0i].ktwrk6jufAF[mo5k];
			}
			return null;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00021714 File Offset: 0x0001F914
		public string jK2IxJ35o1(int 6Edk57TfUz, string zUj)
		{
			int num = 0;
			int num2;
			for (;;)
			{
				int num3;
				if (num == 6)
				{
					num2 = num3;
					num = 7;
				}
				if (num == 1)
				{
					num2 = -1;
					num = 2;
				}
				if (num == 9)
				{
					goto IL_64;
				}
				goto IL_7A;
				IL_164:
				if (num == 3)
				{
					num3 = 0;
					num = 4;
				}
				int num4;
				if (num == 2)
				{
					num4 = this.QS5Z6J8c.Length - 1;
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 12)
				{
					goto Block_12;
				}
				continue;
				IL_13C:
				if (num == 8)
				{
					goto IL_14D;
				}
				goto IL_164;
				IL_114:
				if (num == 10)
				{
					goto IL_125;
				}
				goto IL_13C;
				IL_7A:
				if (num == 7)
				{
					goto IL_125;
				}
				if (num == 4)
				{
					goto IL_64;
				}
				if (num == 11)
				{
					break;
				}
				if (num == 5)
				{
					goto IL_E5;
				}
				goto IL_114;
				IL_14D:
				num3++;
				num = 9;
				goto IL_164;
				IL_E5:
				if (this.QS5Z6J8c[num3].ToLower().CompareTo(zUj.ToLower()) == 0)
				{
					num = 6;
					goto IL_114;
				}
				goto IL_14D;
				IL_64:
				if (num3 > num4)
				{
					num = 10;
					goto IL_7A;
				}
				goto IL_E5;
				IL_125:
				if (num2 == -1)
				{
					num = 11;
					goto IL_13C;
				}
				goto IL_1EC;
			}
			return null;
			Block_12:
			IL_1EC:
			return this.68OQjJrpl(6Edk57TfUz, num2);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00021920 File Offset: 0x0001FB20
		private int jxLHRDoZ(int 9zg)
		{
			int num = 0;
			int num2;
			while (num != 4)
			{
				if (num != 3)
				{
					if (num == 2)
					{
						return 0;
					}
					if (num == 1)
					{
						if (9zg <= this.4Io0C7JAWtc.Length)
						{
							goto IL_5C;
						}
						num = 2;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 5)
					{
						IL_124:
						num2++;
						goto IL_132;
					}
					continue;
				}
				IL_5C:
				int num3 = 9zg + 8;
				num2 = 9zg;
				IL_132:
				if (num2 > num3)
				{
					return 9zg + 8;
				}
				if (num2 > this.4Io0C7JAWtc.Length - 1)
				{
					return 0;
				}
				break;
			}
			if ((this.4Io0C7JAWtc[num2] & 128) != 128)
			{
				return num2;
			}
			goto IL_124;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00021A78 File Offset: 0x0001FC78
		private bool gHo8FbvDW8(long pVZPB)
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
			return (pVZPB & 1L) == 1L;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00021ADC File Offset: 0x0001FCDC
		private void UhiKkGt(ulong juSpdlG)
		{
			int num = 0;
			for (;;)
			{
				if (num == 35)
				{
					goto IL_1F;
				}
				IL_36:
				if (num == 70)
				{
					goto IL_47;
				}
				IL_94:
				ushort num2;
				if (num == 66)
				{
					num2 = Convert.ToUInt16(decimal.Subtract(new decimal(this.KOSpM9gE(Convert.ToInt32(decimal.Add(new decimal(juSpdlG), 3m)), 2)), 1m));
					num = 67;
				}
				ushort num3;
				if (num == 2)
				{
					num3 = Convert.ToUInt16(decimal.Subtract(new decimal(this.KOSpM9gE(Convert.ToInt32(decimal.Add(new decimal(juSpdlG), 3m)), 2)), 1m));
					num = 3;
				}
				if (num == 11)
				{
					goto IL_C04;
				}
				int num4;
				int num5;
				ulong num6;
				long value;
				long[] array;
				if (num == 55)
				{
					this.c826[num4 + num5].ASfv4WqhO = Encoding.Default.GetString(this.4Io0C7JAWtc, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num6), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					num = 56;
				}
				int num8;
				int num7;
				if (num == 21)
				{
					num7 = num8;
					num = 22;
				}
				if (num == 25)
				{
					goto IL_26A;
				}
				goto IL_281;
				IL_138D:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 78)
				{
					return;
				}
				continue;
				IL_1278:
				int num9;
				if (num == 27)
				{
					array[num9] = this.CtA2d3TzOj(num8, num7);
					num = 28;
				}
				if (num == 46)
				{
					this.c826[num4 + num5].wRQ3 = Encoding.Default.GetString(this.4Io0C7JAWtc, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num6), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					num = 47;
				}
				if (num == 12)
				{
					goto IL_1341;
				}
				goto IL_138D;
				IL_1126:
				if (num == 73)
				{
					goto IL_DF4;
				}
				if (num == 36)
				{
					if (num9 <= 4)
					{
						goto IL_26A;
					}
					num = 37;
				}
				if (num == 10)
				{
					num5 = 0;
					num = 11;
				}
				if (num == 19)
				{
					num6 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num6), decimal.Subtract(new decimal(num7), new decimal(num6))), 1m));
					num = 20;
				}
				if (num == 23)
				{
					array = new long[5];
					num = 24;
				}
				if (num == 16)
				{
					this.CtA2d3TzOj((int)num6, num8);
					num = 17;
				}
				if (num == 48)
				{
					goto IL_124D;
				}
				goto IL_1278;
				IL_10DB:
				if (num == 39)
				{
					goto IL_780;
				}
				if (num == 15)
				{
					goto IL_110B;
				}
				goto IL_1126;
				IL_109F:
				if (num == 51)
				{
					goto IL_10B0;
				}
				goto IL_10DB;
				IL_F6D:
				if (num == 54)
				{
					if (decimal.Compare(new decimal(this.qDfr), 1m) != 0)
					{
						goto IL_421;
					}
					num = 55;
				}
				if (num == 59)
				{
					goto IL_CF6;
				}
				if (num == 69)
				{
					goto IL_7BC;
				}
				if (num == 42)
				{
					goto IL_780;
				}
				ushort num10;
				if (num == 72)
				{
					this.UhiKkGt(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(this.KOSpM9gE((int)num10, 4)), 1m), new decimal((int)this.q6YeGtqOSc))));
					num = 73;
				}
				if (num == 34)
				{
					goto IL_1078;
				}
				goto IL_109F;
				IL_E60:
				if (num == 64)
				{
					break;
				}
				if (num == 44)
				{
					this.c826[num4 + num5].CH0us = Encoding.BigEndianUnicode.GetString(this.4Io0C7JAWtc, Convert.ToInt32(decimal.Add(new decimal(num6), new decimal(value))), (int)array[0]);
					num = 45;
				}
				if (num == 14)
				{
					num6 += juSpdlG;
					num = 15;
				}
				if (num == 56)
				{
					goto IL_CF6;
				}
				if (num == 40)
				{
					goto IL_F42;
				}
				goto IL_F6D;
				IL_E0B:
				int num11;
				if (num == 67)
				{
					num11 = (int)num2;
					num = 68;
				}
				if (num == 65)
				{
					goto IL_E3E;
				}
				goto IL_E60;
				IL_D0D:
				if (num != 4)
				{
					goto IL_D35;
				}
				if (this.c826 != null)
				{
					num = 5;
					goto IL_D35;
				}
				goto IL_DC2;
				IL_DE3:
				if (num == 75)
				{
					goto IL_DF4;
				}
				goto IL_E0B;
				IL_D35:
				if (num == 18)
				{
					this.c826[num4 + num5].HGuqrd = this.CtA2d3TzOj(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num6), decimal.Subtract(new decimal(num8), new decimal(num6))), 1m)), num7);
					num = 19;
				}
				if (num != 8)
				{
					goto IL_DE3;
				}
				IL_DC2:
				this.c826 = new btrVogW.rv0CeEB[(int)(num3 + 1)];
				num = 9;
				goto IL_DE3;
				IL_C1A:
				if (num == 37)
				{
					if (decimal.Compare(new decimal(this.qDfr), 1m) != 0)
					{
						goto IL_F42;
					}
					num = 38;
				}
				if (num == 7)
				{
					goto IL_3E0;
				}
				if (num == 41)
				{
					this.c826[num4 + num5].CH0us = Encoding.Unicode.GetString(this.4Io0C7JAWtc, Convert.ToInt32(decimal.Add(new decimal(num6), new decimal(value))), (int)array[0]);
					num = 42;
				}
				if (num == 62)
				{
					goto IL_CF6;
				}
				goto IL_D0D;
				IL_AA6:
				if (num == 30)
				{
					array[num9] = (long)Math.Round((double)(array[num9] - 13L) / 2.0);
					num = 31;
				}
				if (num == 52)
				{
					this.c826[num4 + num5].wRQ3 = Encoding.BigEndianUnicode.GetString(this.4Io0C7JAWtc, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num6), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					num = 53;
				}
				if (num == 26)
				{
					num7 = this.jxLHRDoZ(num8);
					num = 27;
				}
				if (num == 5)
				{
					num4 = this.c826.Length;
					num = 6;
				}
				if (num == 22)
				{
					value = this.CtA2d3TzOj((int)num6, num8);
					num = 23;
				}
				if (num == 63)
				{
					goto IL_C04;
				}
				goto IL_C1A;
				IL_7D2:
				if (num == 61)
				{
					this.c826[num4 + num5].ASfv4WqhO = Encoding.BigEndianUnicode.GetString(this.4Io0C7JAWtc, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num6), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					num = 62;
				}
				if (num == 24)
				{
					num9 = 0;
					num = 25;
				}
				int num12;
				if (num == 68)
				{
					num12 = 0;
					num = 69;
				}
				if (num == 77)
				{
					this.UhiKkGt(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(this.KOSpM9gE(Convert.ToInt32(decimal.Add(new decimal(juSpdlG), 8m)), 4)), 1m), new decimal((int)this.q6YeGtqOSc))));
					num = 78;
				}
				if (num == 3)
				{
					num4 = 0;
					num = 4;
				}
				if (num == 38)
				{
					this.c826[num4 + num5].CH0us = Encoding.Default.GetString(this.4Io0C7JAWtc, Convert.ToInt32(decimal.Add(new decimal(num6), new decimal(value))), (int)array[0]);
					num = 39;
				}
				if (num == 47)
				{
					goto IL_A15;
				}
				if (num == 53)
				{
					goto IL_A15;
				}
				goto IL_AA6;
				IL_7AB:
				if (num == 76)
				{
					goto IL_7BC;
				}
				goto IL_7D2;
				IL_4A7:
				if (num == 49)
				{
					this.c826[num4 + num5].wRQ3 = Encoding.Unicode.GetString(this.4Io0C7JAWtc, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num6), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					num = 50;
				}
				if (num == 1)
				{
					if (this.4Io0C7JAWtc[(int)juSpdlG] != 13)
					{
						goto IL_E3E;
					}
					num = 2;
				}
				if (num == 33)
				{
					goto IL_1F;
				}
				if (num == 20)
				{
					num8 = this.jxLHRDoZ((int)num6);
					num = 21;
				}
				if (num == 29)
				{
					if (!this.gHo8FbvDW8(array[num9]))
					{
						goto IL_2CE;
					}
					num = 30;
				}
				if (num == 17)
				{
					num7 = this.jxLHRDoZ(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num6), decimal.Subtract(new decimal(num8), new decimal(num6))), 1m)));
					num = 18;
				}
				if (num == 71)
				{
					if (decimal.Compare(new decimal(juSpdlG), 100m) != 0)
					{
						goto IL_341;
					}
					num = 72;
				}
				if (num == 6)
				{
					Array.Resize<btrVogW.rv0CeEB>(ref this.c826, this.c826.Length + (int)num3 + 1);
					num = 7;
				}
				if (num == 58)
				{
					this.c826[num4 + num5].ASfv4WqhO = Encoding.Unicode.GetString(this.4Io0C7JAWtc, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num6), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					num = 59;
				}
				if (num == 45)
				{
					goto IL_780;
				}
				goto IL_7AB;
				IL_44C:
				if (num == 31)
				{
					goto IL_1F;
				}
				if (num == 60)
				{
					goto IL_47C;
				}
				goto IL_4A7;
				IL_3F1:
				if (num == 50)
				{
					goto IL_A15;
				}
				if (num == 57)
				{
					goto IL_421;
				}
				goto IL_44C;
				IL_398:
				if (num == 13)
				{
					if (decimal.Compare(new decimal(juSpdlG), 100m) == 0)
					{
						goto IL_110B;
					}
					num = 14;
				}
				if (num == 9)
				{
					goto IL_3E0;
				}
				goto IL_3F1;
				IL_302:
				if (num == 28)
				{
					if (array[num9] <= 9L)
					{
						goto IL_1078;
					}
					num = 29;
				}
				if (num == 74)
				{
					goto IL_341;
				}
				goto IL_398;
				IL_2BD:
				if (num == 32)
				{
					goto IL_2CE;
				}
				goto IL_302;
				IL_281:
				if (num == 43)
				{
					goto IL_292;
				}
				goto IL_2BD;
				IL_1341:
				num6 = this.KOSpM9gE(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(juSpdlG), 8m), new decimal(num5 * 2))), 2);
				num = 13;
				goto IL_138D;
				IL_C04:
				int num13;
				if (num5 > num13)
				{
					num = 64;
					goto IL_C1A;
				}
				goto IL_1341;
				IL_124D:
				if (decimal.Compare(new decimal(this.qDfr), 2m) == 0)
				{
					num = 49;
					goto IL_1278;
				}
				goto IL_10B0;
				IL_780:
				if (decimal.Compare(new decimal(this.qDfr), 1m) == 0)
				{
					num = 46;
					goto IL_7AB;
				}
				goto IL_124D;
				IL_292:
				if (decimal.Compare(new decimal(this.qDfr), 3m) == 0)
				{
					num = 44;
					goto IL_2BD;
				}
				goto IL_780;
				IL_F42:
				if (decimal.Compare(new decimal(this.qDfr), 2m) == 0)
				{
					num = 41;
					goto IL_F6D;
				}
				goto IL_292;
				IL_110B:
				num8 = this.jxLHRDoZ((int)num6);
				num = 16;
				goto IL_1126;
				IL_10B0:
				if (decimal.Compare(new decimal(this.qDfr), 3m) == 0)
				{
					num = 52;
					goto IL_10DB;
				}
				goto IL_A15;
				IL_1078:
				array[num9] = (long)((ulong)this.C2e[(int)array[num9]]);
				num = 35;
				goto IL_109F;
				IL_E3E:
				if (this.4Io0C7JAWtc[(int)juSpdlG] == 5)
				{
					num = 66;
					goto IL_E60;
				}
				return;
				IL_DF4:
				num12++;
				num = 76;
				goto IL_E0B;
				IL_CF6:
				num5++;
				num = 63;
				goto IL_D0D;
				IL_47C:
				if (decimal.Compare(new decimal(this.qDfr), 3m) == 0)
				{
					num = 61;
					goto IL_4A7;
				}
				goto IL_CF6;
				IL_421:
				if (decimal.Compare(new decimal(this.qDfr), 2m) == 0)
				{
					num = 58;
					goto IL_44C;
				}
				goto IL_47C;
				IL_A15:
				this.c826[num4 + num5].iO6FefoDoth = (long)this.KOSpM9gE(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num6), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
				num = 54;
				goto IL_AA6;
				IL_7BC:
				if (num12 > num11)
				{
					num = 77;
					goto IL_7D2;
				}
				goto IL_47;
				IL_3E0:
				num13 = (int)num3;
				num = 10;
				goto IL_3F1;
				IL_341:
				this.UhiKkGt(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(this.KOSpM9gE((int)(juSpdlG + (ulong)num10), 4)), 1m), new decimal((int)this.q6YeGtqOSc))));
				num = 75;
				goto IL_398;
				IL_2CE:
				array[num9] = (long)Math.Round((double)(array[num9] - 12L) / 2.0);
				num = 33;
				goto IL_302;
				IL_26A:
				num8 = num7 + 1;
				num = 26;
				goto IL_281;
				IL_47:
				num10 = (ushort)this.KOSpM9gE(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(juSpdlG), 12m), new decimal(num12 * 2))), 2);
				num = 71;
				goto IL_94;
				IL_1F:
				num9++;
				num = 36;
				goto IL_36;
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00022EAC File Offset: 0x000210AC
		public bool f9NLCu(string yjMz5b5nYX)
		{
			int num = 0;
			int num2;
			for (;;)
			{
				if (num == 5)
				{
					goto IL_1F;
				}
				goto IL_57;
				IL_15D:
				if (num == 10)
				{
					goto IL_16E;
				}
				IL_185:
				if (num != 7)
				{
					if (num == 4)
					{
						goto IL_11F;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 12)
					{
						goto Block_12;
					}
					continue;
				}
				IL_16E:
				if (num2 == -1)
				{
					num = 11;
					goto IL_185;
				}
				goto IL_1F9;
				IL_135:
				if (num == 8)
				{
					goto IL_146;
				}
				goto IL_15D;
				IL_57:
				int num3;
				if (num == 3)
				{
					num3 = 0;
					num = 4;
				}
				int num4;
				if (num == 2)
				{
					num4 = this.c826.Length - 1;
					num = 3;
				}
				if (num == 11)
				{
					break;
				}
				if (num == 1)
				{
					num2 = -1;
					num = 2;
				}
				if (num == 6)
				{
					num2 = num3;
					num = 7;
				}
				if (num == 9)
				{
					goto IL_11F;
				}
				goto IL_135;
				IL_1F:
				if (this.c826[num3].wRQ3.ToLower().CompareTo(yjMz5b5nYX.ToLower()) == 0)
				{
					num = 6;
					goto IL_57;
				}
				goto IL_146;
				IL_11F:
				if (num3 > num4)
				{
					num = 10;
					goto IL_135;
				}
				goto IL_1F;
				IL_146:
				num3++;
				num = 9;
				goto IL_15D;
			}
			return false;
			Block_12:
			IL_1F9:
			string[] array = this.c826[num2].ASfv4WqhO.Substring(this.c826[num2].ASfv4WqhO.IndexOf("(") + 1).Split(new char[]
			{
				','
			});
			int num5 = array.Length - 1;
			for (int i = 0; i <= num5; i++)
			{
				array[i] = array[i].TrimStart(new char[0]);
				if (array[i].EndsWith(")"))
				{
					array[i] = array[i].Substring(0, array[i].Length - 1);
				}
				int num6 = array[i].IndexOf(" ");
				if (num6 > 0)
				{
					array[i] = array[i].Substring(0, num6);
				}
				if (array[i].IndexOf("UNIQUE") == 0)
				{
					break;
				}
				Array.Resize<string>(ref this.QS5Z6J8c, i + 1);
				this.QS5Z6J8c[i] = array[i];
			}
			return this.oR7n5B4((ulong)((this.c826[num2].iO6FefoDoth - 1L) * (long)((ulong)this.q6YeGtqOSc)));
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00023294 File Offset: 0x00021494
		private bool oR7n5B4(ulong frdY2XJ)
		{
			int num = 0;
			for (;;)
			{
				ulong num2;
				int num3;
				if (num == 20)
				{
					num2 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num2), decimal.Subtract(new decimal(num3), new decimal(num2))), 1m));
					num = 21;
				}
				if (num == 53)
				{
					goto IL_C65;
				}
				int num4;
				if (num == 63)
				{
					num4++;
					num = 64;
				}
				if (num == 10)
				{
					num4 = 0;
					num = 11;
				}
				int num5;
				int num6;
				long num7;
				int num8;
				btrVogW.uNTdr[] array;
				if (num == 52)
				{
					this.Hpxv9MP[num5 + num4].ktwrk6jufAF[num6] = Encoding.Unicode.GetString(this.4Io0C7JAWtc, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num2), new decimal(num7)), new decimal(num8))), (int)array[num6].ZyY8);
					num = 53;
				}
				if (num == 35)
				{
					goto IL_16B;
				}
				goto IL_1B1;
				IL_1115:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 76)
				{
					break;
				}
				continue;
				IL_10AC:
				if (num == 58)
				{
					goto IL_C65;
				}
				if (num == 44)
				{
					num6 = 0;
					num = 45;
				}
				if (num == 40)
				{
					goto IL_10FF;
				}
				goto IL_1115;
				IL_DC7:
				int num9;
				if (num == 2)
				{
					num9 = Convert.ToInt32(decimal.Subtract(new decimal(this.KOSpM9gE(Convert.ToInt32(decimal.Add(new decimal(frdY2XJ), 3m)), 2)), 1m));
					num = 3;
				}
				if (num == 75)
				{
					this.oR7n5B4(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(this.KOSpM9gE(Convert.ToInt32(decimal.Add(new decimal(frdY2XJ), 8m)), 4)), 1m), new decimal((int)this.q6YeGtqOSc))));
					num = 76;
				}
				if (num == 13)
				{
					num2 = this.KOSpM9gE(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(frdY2XJ), 8m), new decimal(num4 * 2))), 2);
					num = 14;
				}
				if (num == 4)
				{
					if (this.Hpxv9MP == null)
					{
						goto IL_9D2;
					}
					num = 5;
				}
				int num10;
				if (num == 43)
				{
					num10 = array.Length - 1;
					num = 44;
				}
				int num11;
				if (num == 69)
				{
					num11 = 0;
					num = 70;
				}
				if (num == 55)
				{
					this.Hpxv9MP[num5 + num4].ktwrk6jufAF[num6] = Encoding.BigEndianUnicode.GetString(this.4Io0C7JAWtc, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num2), new decimal(num7)), new decimal(num8))), (int)array[num6].ZyY8);
					num = 56;
				}
				int num12;
				if (num == 28)
				{
					num12 = num3 + 1;
					num = 29;
				}
				if (num == 45)
				{
					goto IL_1FF;
				}
				if (num == 14)
				{
					if (decimal.Compare(new decimal(frdY2XJ), 100m) == 0)
					{
						goto IL_758;
					}
					num = 15;
				}
				if (num == 27)
				{
					goto IL_1090;
				}
				goto IL_10AC;
				IL_C8A:
				if (num == 1)
				{
					if (this.4Io0C7JAWtc[(int)frdY2XJ] != 13)
					{
						goto IL_AB9;
					}
					num = 2;
				}
				ushort num13;
				if (num == 67)
				{
					num13 = Convert.ToUInt16(decimal.Subtract(new decimal(this.KOSpM9gE(Convert.ToInt32(decimal.Add(new decimal(frdY2XJ), 3m)), 2)), 1m));
					num = 68;
				}
				int num14;
				if (num == 68)
				{
					num14 = (int)num13;
					num = 69;
				}
				if (num == 48)
				{
					if (decimal.Compare(new decimal(this.qDfr), 1m) != 0)
					{
						goto IL_974;
					}
					num = 49;
				}
				if (num == 37)
				{
					goto IL_D8E;
				}
				goto IL_DC7;
				IL_BF4:
				if (num == 18)
				{
					num3 = this.jxLHRDoZ(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num2), decimal.Subtract(new decimal(num12), new decimal(num2))), 1m)));
					num = 19;
				}
				if (num == 60)
				{
					goto IL_C65;
				}
				goto IL_C8A;
				IL_ADB:
				if (num == 42)
				{
					num8 = 0;
					num = 43;
				}
				if (num == 6)
				{
					Array.Resize<btrVogW.fWibnc>(ref this.Hpxv9MP, this.Hpxv9MP.Length + num9 + 1);
					num = 7;
				}
				int num15;
				if (num == 31)
				{
					if (array[num15].ufE8dO21 <= 9L)
					{
						goto IL_D8E;
					}
					num = 32;
				}
				if (num == 25)
				{
					num15 = 0;
					num = 26;
				}
				if (num == 15)
				{
					num2 += frdY2XJ;
					num = 16;
				}
				if (num == 46)
				{
					goto IL_BCE;
				}
				goto IL_BF4;
				IL_AA8:
				if (num == 66)
				{
					goto IL_AB9;
				}
				goto IL_ADB;
				IL_A51:
				if (num == 3)
				{
					num5 = 0;
					num = 4;
				}
				if (num == 38)
				{
					goto IL_A85;
				}
				goto IL_AA8;
				IL_9F3:
				if (num == 22)
				{
					num3 = num12;
					num = 23;
				}
				if (num == 54)
				{
					goto IL_A26;
				}
				goto IL_A51;
				IL_9C1:
				if (num == 8)
				{
					goto IL_9D2;
				}
				goto IL_9F3;
				IL_99F:
				if (num == 9)
				{
					goto IL_9B0;
				}
				goto IL_9C1;
				IL_8B0:
				if (num == 61)
				{
					num6++;
					num = 62;
				}
				if (num == 73)
				{
					num11++;
					num = 74;
				}
				if (num == 5)
				{
					num5 = this.Hpxv9MP.Length;
					num = 6;
				}
				if (num == 32)
				{
					if (!this.gHo8FbvDW8(array[num15].ufE8dO21))
					{
						goto IL_16B;
					}
					num = 33;
				}
				if (num == 51)
				{
					goto IL_974;
				}
				goto IL_99F;
				IL_773:
				ushort num16;
				if (num == 72)
				{
					this.oR7n5B4(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(this.KOSpM9gE((int)(frdY2XJ + (ulong)num16), 4)), 1m), new decimal((int)this.q6YeGtqOSc))));
					num = 73;
				}
				if (num == 26)
				{
					goto IL_10FF;
				}
				if (num == 33)
				{
					array[num15].ZyY8 = (long)Math.Round((double)(array[num15].ufE8dO21 - 13L) / 2.0);
					num = 34;
				}
				if (num == 71)
				{
					goto IL_863;
				}
				goto IL_8B0;
				IL_64A:
				if (num == 36)
				{
					goto IL_A85;
				}
				if (num == 65)
				{
					break;
				}
				long num17;
				if (num == 24)
				{
					num17 = Convert.ToInt64(decimal.Add(decimal.Subtract(new decimal(num2), new decimal(num12)), 1m));
					num = 25;
				}
				if (num == 29)
				{
					num3 = this.jxLHRDoZ(num12);
					num = 30;
				}
				if (num == 21)
				{
					num12 = this.jxLHRDoZ((int)num2);
					num = 22;
				}
				if (num == 50)
				{
					goto IL_C65;
				}
				if (num == 16)
				{
					goto IL_758;
				}
				goto IL_773;
				IL_543:
				if (num == 19)
				{
					this.Hpxv9MP[num5 + num4].HGuqrd = this.CtA2d3TzOj(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num2), decimal.Subtract(new decimal(num12), new decimal(num2))), 1m)), num3);
					num = 20;
				}
				if (num == 57)
				{
					goto IL_5D0;
				}
				goto IL_64A;
				IL_51C:
				if (num == 74)
				{
					goto IL_52D;
				}
				goto IL_543;
				IL_215:
				if (num == 34)
				{
					goto IL_A85;
				}
				if (num == 17)
				{
					this.CtA2d3TzOj((int)num2, num12);
					num = 18;
				}
				if (num == 49)
				{
					this.Hpxv9MP[num5 + num4].ktwrk6jufAF[num6] = Encoding.Default.GetString(this.4Io0C7JAWtc, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num2), new decimal(num7)), new decimal(num8))), (int)array[num6].ZyY8);
					num = 50;
				}
				if (num == 11)
				{
					goto IL_33B;
				}
				if (num == 56)
				{
					goto IL_C65;
				}
				if (num == 64)
				{
					goto IL_33B;
				}
				goto IL_351;
				IL_3EE:
				if (num == 23)
				{
					num7 = this.CtA2d3TzOj((int)num2, num12);
					num = 24;
				}
				if (num == 47)
				{
					if (this.gHo8FbvDW8(array[num6].ufE8dO21))
					{
						goto IL_5D0;
					}
					num = 48;
				}
				if (num == 7)
				{
					goto IL_9B0;
				}
				if (num == 70)
				{
					goto IL_52D;
				}
				if (num == 59)
				{
					goto IL_4A7;
				}
				goto IL_51C;
				IL_351:
				if (num == 41)
				{
					this.Hpxv9MP[num5 + num4].ktwrk6jufAF = new string[array.Length - 1 + 1];
					num = 42;
				}
				if (num == 39)
				{
					num15++;
					num = 40;
				}
				if (num != 12)
				{
					goto IL_3EE;
				}
				IL_3D7:
				array = new btrVogW.uNTdr[1];
				num = 13;
				goto IL_3EE;
				IL_33B:
				int num18;
				if (num4 > num18)
				{
					num = 65;
					goto IL_351;
				}
				goto IL_3D7;
				IL_1B1:
				if (num == 30)
				{
					array[num15].ufE8dO21 = this.CtA2d3TzOj(num12, num3);
					num = 31;
				}
				if (num == 62)
				{
					goto IL_1FF;
				}
				goto IL_215;
				IL_10FF:
				if (num17 >= num7)
				{
					num = 41;
					goto IL_1115;
				}
				IL_1090:
				Array.Resize<btrVogW.uNTdr>(ref array, num15 + 1);
				num = 28;
				goto IL_10AC;
				IL_D8E:
				array[num15].ZyY8 = (long)((ulong)this.C2e[(int)array[num15].ufE8dO21]);
				num = 38;
				goto IL_DC7;
				IL_C65:
				num8 += (int)array[num6].ZyY8;
				num = 61;
				goto IL_C8A;
				IL_A26:
				if (decimal.Compare(new decimal(this.qDfr), 3m) == 0)
				{
					num = 55;
					goto IL_A51;
				}
				goto IL_C65;
				IL_974:
				if (decimal.Compare(new decimal(this.qDfr), 2m) == 0)
				{
					num = 52;
					goto IL_99F;
				}
				goto IL_A26;
				IL_BCE:
				if (array[num6].ufE8dO21 > 9L)
				{
					num = 47;
					goto IL_BF4;
				}
				goto IL_4A7;
				IL_1FF:
				if (num6 > num10)
				{
					num = 63;
					goto IL_215;
				}
				goto IL_BCE;
				IL_AB9:
				if (this.4Io0C7JAWtc[(int)frdY2XJ] == 5)
				{
					num = 67;
					goto IL_ADB;
				}
				break;
				IL_A85:
				num17 = num17 + (long)(num3 - num12) + 1L;
				num = 39;
				goto IL_AA8;
				IL_9D2:
				this.Hpxv9MP = new btrVogW.fWibnc[num9 + 1];
				num = 9;
				goto IL_9F3;
				IL_9B0:
				num18 = num9;
				num = 10;
				goto IL_9C1;
				IL_863:
				num16 = (ushort)this.KOSpM9gE(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(frdY2XJ), 12m), new decimal(num11 * 2))), 2);
				num = 72;
				goto IL_8B0;
				IL_52D:
				if (num11 > num14)
				{
					num = 75;
					goto IL_543;
				}
				goto IL_863;
				IL_758:
				num12 = this.jxLHRDoZ((int)num2);
				num = 17;
				goto IL_773;
				IL_5D0:
				this.Hpxv9MP[num5 + num4].ktwrk6jufAF[num6] = Encoding.Default.GetString(this.4Io0C7JAWtc, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num2), new decimal(num7)), new decimal(num8))), (int)array[num6].ZyY8);
				num = 58;
				goto IL_64A;
				IL_4A7:
				this.Hpxv9MP[num5 + num4].ktwrk6jufAF[num6] = Convert.ToString(this.KOSpM9gE(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num2), new decimal(num7)), new decimal(num8))), (int)array[num6].ZyY8));
				num = 60;
				goto IL_51C;
				IL_16B:
				array[num15].ZyY8 = (long)Math.Round((double)(array[num15].ufE8dO21 - 12L) / 2.0);
				num = 36;
				goto IL_1B1;
			}
			return true;
		}

		// Token: 0x040000C0 RID: 192
		private readonly byte[] 4Io0C7JAWtc;

		// Token: 0x040000C1 RID: 193
		private readonly ulong qDfr;

		// Token: 0x040000C2 RID: 194
		private readonly ushort q6YeGtqOSc;

		// Token: 0x040000C3 RID: 195
		private readonly byte[] C2e = new byte[]
		{
			0,
			1,
			2,
			3,
			4,
			6,
			8,
			8,
			0,
			0
		};

		// Token: 0x040000C4 RID: 196
		public string[] QS5Z6J8c = new string[1];

		// Token: 0x040000C5 RID: 197
		private btrVogW.rv0CeEB[] c826;

		// Token: 0x040000C6 RID: 198
		private btrVogW.fWibnc[] Hpxv9MP;

		// Token: 0x02000056 RID: 86
		private struct uNTdr
		{
			// Token: 0x040000C7 RID: 199
			public long ZyY8;

			// Token: 0x040000C8 RID: 200
			public long ufE8dO21;
		}

		// Token: 0x02000057 RID: 87
		private struct rv0CeEB
		{
			// Token: 0x040000C9 RID: 201
			public long HGuqrd;

			// Token: 0x040000CA RID: 202
			public string CH0us;

			// Token: 0x040000CB RID: 203
			public string wRQ3;

			// Token: 0x040000CC RID: 204
			public string TG2GA;

			// Token: 0x040000CD RID: 205
			public long iO6FefoDoth;

			// Token: 0x040000CE RID: 206
			public string ASfv4WqhO;
		}

		// Token: 0x02000058 RID: 88
		private struct fWibnc
		{
			// Token: 0x040000CF RID: 207
			public long HGuqrd;

			// Token: 0x040000D0 RID: 208
			public string[] ktwrk6jufAF;
		}
	}
}
