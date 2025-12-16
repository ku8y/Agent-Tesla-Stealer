using System;
using System.Security.Cryptography;

namespace reJu9lk2r
{
	// Token: 0x0200005F RID: 95
	public class 93WgTZS3
	{
		// Token: 0x060001B8 RID: 440 RVA: 0x000259FC File Offset: 0x00023BFC
		public 93WgTZS3(HMAC algorithm, byte[] password, byte[] salt, int iterations)
		{
			this.V4i = algorithm;
			this.V4i.Key = password;
			this.VO69NqL = salt;
			this.2CV0Wp6wOZk = iterations;
			this.JeMaAJAh9k = this.V4i.HashSize / 8;
			this.KMr7 = new byte[this.JeMaAJAh9k - 1 + 1];
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00025A60 File Offset: 0x00023C60
		public byte[] sVd(int wuPnwcH)
		{
			int num = 0;
			int num2;
			byte[] array;
			int i;
			do
			{
				if (num == 5)
				{
					if (wuPnwcH >= num2)
					{
						goto IL_6E;
					}
					num = 6;
				}
				if (num == 4)
				{
					if (num2 <= 0)
					{
						break;
					}
					num = 5;
				}
				if (num == 9)
				{
					goto IL_6E;
				}
				if (num == 8)
				{
					return array;
				}
				if (num == 7)
				{
					this.ZvT += wuPnwcH;
					num = 8;
				}
				if (num == 2)
				{
					i = 0;
					num = 3;
				}
				if (num == 6)
				{
					Buffer.BlockCopy(this.KMr7, this.ZvT, array, 0, wuPnwcH);
					num = 7;
				}
				if (num == 1)
				{
					array = new byte[wuPnwcH - 1 + 1];
					num = 2;
				}
				if (num == 3)
				{
					num2 = this.sWHMyet - this.ZvT;
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 10);
			IL_2C5:
			while (i < wuPnwcH)
			{
				int num3 = wuPnwcH - i;
				this.KMr7 = this.jMef(true);
				if (num3 <= this.JeMaAJAh9k)
				{
					Buffer.BlockCopy(this.KMr7, 0, array, i, num3);
					this.ZvT = num3;
					this.sWHMyet = this.JeMaAJAh9k;
					return array;
				}
				Buffer.BlockCopy(this.KMr7, 0, array, i, this.JeMaAJAh9k);
				i += this.JeMaAJAh9k;
			}
			return array;
			IL_6E:
			Buffer.BlockCopy(this.KMr7, this.ZvT, array, 0, num2);
			this.ZvT = 93WgTZS3.S5eqrYkD<int>(ref this.sWHMyet, 0);
			i += num2;
			goto IL_2C5;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00025D44 File Offset: 0x00023F44
		private static T S5eqrYkD<T>(ref T CxnDl, T ddSv6FGa9)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					CxnDl = ddSv6FGa9;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			return ddSv6FGa9;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00025DC0 File Offset: 0x00023FC0
		public byte[] rHd9AQN83Om(int 1Dwqrspiz, string LBvJdr = "sha512")
		{
			int num = 0;
			byte[] array;
			while (num != 8)
			{
				if (num == 9)
				{
					goto IL_3E;
				}
				int i;
				if (num == 2)
				{
					i = 0;
					num = 3;
				}
				if (num == 7)
				{
					this.ZvT += 1Dwqrspiz;
					num = 8;
				}
				int num2;
				if (num == 4)
				{
					if (num2 <= 0)
					{
						goto IL_2BD;
					}
					num = 5;
				}
				if (num == 6)
				{
					Buffer.BlockCopy(this.KMr7, this.ZvT, array, 0, 1Dwqrspiz);
					num = 7;
				}
				if (num == 1)
				{
					array = new byte[1Dwqrspiz];
					num = 2;
				}
				if (num == 5)
				{
					if (1Dwqrspiz >= num2)
					{
						goto IL_3E;
					}
					num = 6;
				}
				if (num == 3)
				{
					num2 = this.sWHMyet - this.ZvT;
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 10)
				{
					continue;
				}
				IL_2BD:
				while (i < 1Dwqrspiz)
				{
					int num3 = 1Dwqrspiz - i;
					this.KMr7 = this.jMef(true);
					if (num3 <= this.JeMaAJAh9k)
					{
						Buffer.BlockCopy(this.KMr7, 0, array, i, num3);
						this.ZvT = num3;
						this.sWHMyet = this.JeMaAJAh9k;
						return array;
					}
					Buffer.BlockCopy(this.KMr7, 0, array, i, this.JeMaAJAh9k);
					i += this.JeMaAJAh9k;
				}
				return array;
				IL_3E:
				Buffer.BlockCopy(this.KMr7, this.ZvT, array, 0, num2);
				this.ZvT = (this.sWHMyet = 0);
				i += num2;
				goto IL_2BD;
			}
			return array;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0002609C File Offset: 0x0002429C
		private byte[] jMef(bool ARHDRwjpJ = true)
		{
			int num = 0;
			byte[] array2;
			for (;;)
			{
				if (num == 13)
				{
					goto IL_1F;
				}
				goto IL_40;
				IL_1BE:
				if (num == 16)
				{
					goto IL_1CF;
				}
				IL_1E6:
				byte[] array;
				if (num == 2)
				{
					Buffer.BlockCopy(this.VO69NqL, 0, array, 0, this.VO69NqL.Length);
					num = 3;
				}
				int num2;
				if (num == 9)
				{
					num2 = 0;
					num = 10;
				}
				if (num == 12)
				{
					num2++;
					num = 13;
				}
				if (num == 3)
				{
					Buffer.BlockCopy(93WgTZS3.GvmP8P(this.BezT1vre), 0, array, this.VO69NqL.Length, 4);
					num = 4;
				}
				if (num == 18)
				{
					if (this.BezT1vre != 4294967295U)
					{
						goto IL_38E;
					}
					num = 19;
				}
				byte[] array3;
				if (num == 15)
				{
					Array.Copy(array2, array3, array3.Length);
					num = 16;
				}
				int num3;
				if (num == 6)
				{
					num3 = 2;
					num = 7;
				}
				if (num == 14)
				{
					if (!ARHDRwjpJ)
					{
						goto IL_1CF;
					}
					num = 15;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 20)
				{
					goto Block_20;
				}
				continue;
				IL_1CF:
				num3++;
				num = 17;
				goto IL_1E6;
				IL_40:
				if (num == 19)
				{
					break;
				}
				if (num == 5)
				{
					array2 = array3;
					num = 6;
				}
				if (num == 17)
				{
					goto IL_8F;
				}
				goto IL_AA;
				IL_115:
				if (num == 7)
				{
					goto IL_8F;
				}
				if (num == 1)
				{
					array = new byte[this.VO69NqL.Length + 4];
					num = 2;
				}
				if (num == 10)
				{
					goto IL_1F;
				}
				if (num == 11)
				{
					goto IL_198;
				}
				goto IL_1BE;
				IL_AA:
				if (num == 4)
				{
					array3 = this.V4i.ComputeHash(array);
					num = 5;
				}
				if (num != 8)
				{
					goto IL_115;
				}
				IL_EB:
				array3 = this.V4i.ComputeHash(array3, 0, array3.Length);
				num = 9;
				goto IL_115;
				IL_8F:
				if (num3 > this.2CV0Wp6wOZk)
				{
					num = 18;
					goto IL_AA;
				}
				goto IL_EB;
				IL_1F:
				if (num2 > this.JeMaAJAh9k - 1)
				{
					num = 14;
					goto IL_40;
				}
				IL_198:
				array2[num2] ^= array3[num2];
				num = 12;
				goto IL_1BE;
			}
			return null;
			Block_20:
			IL_38E:
			this.BezT1vre += 1U;
			return array2;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00026450 File Offset: 0x00024650
		private static byte[] GvmP8P(uint XubGR6)
		{
			int num = 0;
			byte[] array;
			for (;;)
			{
				byte[] bytes;
				if (num == 5)
				{
					array[1] = bytes[2];
					num = 6;
				}
				if (num == 8)
				{
					break;
				}
				if (num == 3)
				{
					array = new byte[4];
					num = 4;
				}
				if (num == 7)
				{
					array[3] = bytes[0];
					num = 8;
				}
				if (num == 6)
				{
					array[2] = bytes[1];
					num = 7;
				}
				if (num == 1)
				{
					bytes = BitConverter.GetBytes(XubGR6);
					num = 2;
				}
				if (num == 4)
				{
					array[0] = bytes[3];
					num = 5;
				}
				if (num == 2)
				{
					if (!BitConverter.IsLittleEndian)
					{
						return bytes;
					}
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 9)
				{
					return bytes;
				}
			}
			return array;
		}

		// Token: 0x040000DC RID: 220
		private int JeMaAJAh9k;

		// Token: 0x040000DD RID: 221
		private uint BezT1vre = 1U;

		// Token: 0x040000DE RID: 222
		private byte[] KMr7;

		// Token: 0x040000DF RID: 223
		private int ZvT;

		// Token: 0x040000E0 RID: 224
		private int sWHMyet;

		// Token: 0x040000E1 RID: 225
		public HMAC V4i;

		// Token: 0x040000E2 RID: 226
		public byte[] VO69NqL;

		// Token: 0x040000E3 RID: 227
		public int 2CV0Wp6wOZk;
	}
}
