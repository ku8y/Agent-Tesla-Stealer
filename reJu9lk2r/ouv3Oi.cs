using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using PK42;

namespace reJu9lk2r
{
	// Token: 0x02000060 RID: 96
	public class ouv3Oi
	{
		// Token: 0x060001BE RID: 446 RVA: 0x000265F0 File Offset: 0x000247F0
		public byte[] O0xgxU(byte[] HMI, byte[] fjo, byte[] 38KQy5, byte[] gOs, byte[] KyuDmsUpza8)
		{
			int num = 0;
			while (num != 14)
			{
				if (num != 11)
				{
					goto IL_60;
				}
				uint num2;
				if (num2 == IEF.YwmfMC)
				{
					num = 12;
					goto IL_60;
				}
				goto IL_17F;
				IL_321:
				if (num == 0)
				{
					num = 1;
				}
				byte[] array;
				if (num == 18)
				{
					return array;
				}
				continue;
				IL_230:
				IntPtr hKey;
				int num3;
				if (num == 6)
				{
					IEF.TDsnUlQTh tdsnUlQTh;
					byte[] array2;
					num2 = IEF.BCryptDecrypt(hKey, gOs, gOs.Length, ref tdsnUlQTh, array2, array2.Length, null, 0, ref num3, 0);
					num = 7;
				}
				if (num == 16)
				{
					IntPtr hglobal;
					Marshal.FreeHGlobal(hglobal);
					num = 17;
				}
				if (num == 5)
				{
					num3 = 0;
					num = 6;
				}
				IntPtr intPtr;
				if (num == 1)
				{
					intPtr = this.fOTi(IEF.eDsPIG, IEF.uT99, IEF.kMN9gxn);
					num = 2;
				}
				if (num == 9)
				{
					goto IL_30B;
				}
				goto IL_321;
				IL_191:
				if (num == 17)
				{
					IEF.BCryptCloseAlgorithmProvider(intPtr, 0U);
					num = 18;
				}
				if (num == 10)
				{
					IEF.TDsnUlQTh tdsnUlQTh;
					byte[] array2;
					num2 = IEF.BCryptDecrypt(hKey, gOs, gOs.Length, ref tdsnUlQTh, array2, array2.Length, array, array.Length, ref num3, 0);
					num = 11;
				}
				if (num == 15)
				{
					goto IL_21D;
				}
				goto IL_230;
				IL_60:
				if (num == 7)
				{
					if (num2 == 0U)
					{
						goto IL_30B;
					}
					num = 8;
				}
				if (num == 8)
				{
					throw new CryptographicException("");
				}
				if (num == 3)
				{
					IEF.TDsnUlQTh tdsnUlQTh = new IEF.TDsnUlQTh(fjo, 38KQy5, KyuDmsUpza8);
					num = 4;
				}
				if (num == 12)
				{
					throw new CryptographicException("");
				}
				if (num == 2)
				{
					IntPtr hglobal = this.a13lq(intPtr, HMI, out hKey);
					num = 3;
				}
				if (num == 4)
				{
					byte[] array2 = new byte[this.1zT(intPtr)];
					num = 5;
				}
				if (num == 13)
				{
					goto IL_17F;
				}
				goto IL_191;
				IL_30B:
				array = new byte[num3];
				num = 10;
				goto IL_321;
				IL_21D:
				IEF.BCryptDestroyKey(hKey);
				num = 16;
				goto IL_230;
				IL_17F:
				if (num2 != 0U)
				{
					num = 14;
					goto IL_191;
				}
				goto IL_21D;
			}
			throw new CryptographicException("");
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00026958 File Offset: 0x00024B58
		private int 1zT(IntPtr ieLdqu60c6B)
		{
			int num = 0;
			byte[] array;
			do
			{
				byte[] array2;
				if (num == 6)
				{
					array[3] = array2[7];
					num = 7;
				}
				if (num == 3)
				{
					array[0] = array2[4];
					num = 4;
				}
				if (num == 4)
				{
					array[1] = array2[5];
					num = 5;
				}
				if (num == 5)
				{
					array[2] = array2[6];
					num = 6;
				}
				if (num == 2)
				{
					array = new byte[4];
					num = 3;
				}
				if (num == 1)
				{
					array2 = this.msWehzo(ieLdqu60c6B, IEF.dcu4h9Bdas);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 7);
			return BitConverter.ToInt32(array, 0);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00026AC8 File Offset: 0x00024CC8
		private IntPtr fOTi(string 1JOXIfVK3y, string 45T, string e6bCCP)
		{
			int num = 0;
			for (;;)
			{
				if (num == 5)
				{
					goto IL_1F;
				}
				IL_3A:
				if (num == 4)
				{
					break;
				}
				if (num == 8)
				{
					goto Block_2;
				}
				IntPtr zero;
				if (num == 1)
				{
					zero = IntPtr.Zero;
					num = 2;
				}
				byte[] bytes;
				uint num2;
				if (num == 6)
				{
					num2 = IEF.BCryptSetAlgorithmProperty(zero, IEF.DbDbVKRi5, bytes, bytes.Length, 0);
					num = 7;
				}
				if (num == 7)
				{
					if (num2 == 0U)
					{
						return zero;
					}
					num = 8;
				}
				if (num == 3)
				{
					if (num2 == 0U)
					{
						goto IL_1F;
					}
					num = 4;
				}
				if (num == 2)
				{
					num2 = IEF.BCryptOpenAlgorithmProvider(out zero, 1JOXIfVK3y, 45T, 0U);
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 9)
				{
					return zero;
				}
				continue;
				IL_1F:
				bytes = Encoding.Unicode.GetBytes(e6bCCP);
				num = 6;
				goto IL_3A;
			}
			throw new CryptographicException("");
			Block_2:
			throw new CryptographicException("");
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00026C78 File Offset: 0x00024E78
		private IntPtr a13lq(IntPtr NJlGaP9pF, byte[] a80Tw565, out IntPtr nlnjxRf)
		{
			int num = 0;
			for (;;)
			{
				IntPtr intPtr;
				if (num == 6)
				{
					uint num2;
					if (num2 == 0U)
					{
						return intPtr;
					}
					num = 7;
				}
				byte[] array;
				if (num == 4)
				{
					array = this.EDFjkyz4sX7(new byte[][]
					{
						IEF.eXA0VImi5,
						BitConverter.GetBytes(1),
						BitConverter.GetBytes(a80Tw565.Length),
						a80Tw565
					});
					num = 5;
				}
				int num3;
				if (num == 2)
				{
					byte[] value;
					num3 = BitConverter.ToInt32(value, 0);
					num = 3;
				}
				if (num == 5)
				{
					uint num2 = IEF.BCryptImportKey(NJlGaP9pF, IntPtr.Zero, IEF.VdYfvXgR, out nlnjxRf, intPtr, num3, array, array.Length, 0U);
					num = 6;
				}
				if (num == 7)
				{
					break;
				}
				if (num == 1)
				{
					byte[] value = this.msWehzo(NJlGaP9pF, IEF.19BPk1xR);
					num = 2;
				}
				if (num == 3)
				{
					intPtr = Marshal.AllocHGlobal(num3);
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 8)
				{
					return intPtr;
				}
			}
			throw new CryptographicException("");
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00026E68 File Offset: 0x00025068
		private byte[] msWehzo(IntPtr tN3epTuYUAE, string 6cf5)
		{
			int num = 0;
			while (num != 8)
			{
				int num3;
				uint num2;
				if (num == 2)
				{
					num2 = IEF.BCryptGetProperty(tN3epTuYUAE, 6cf5, null, 0, ref num3, 0U);
					num = 3;
				}
				if (num == 4)
				{
					throw new CryptographicException("");
				}
				byte[] array;
				if (num == 7)
				{
					if (num2 == 0U)
					{
						return array;
					}
					num = 8;
				}
				if (num == 1)
				{
					num3 = 0;
					num = 2;
				}
				if (num == 6)
				{
					num2 = IEF.BCryptGetProperty(tN3epTuYUAE, 6cf5, array, array.Length, ref num3, 0U);
					num = 7;
				}
				if (num != 3)
				{
					goto IL_143;
				}
				if (num2 != 0U)
				{
					num = 4;
					goto IL_143;
				}
				goto IL_154;
				IL_16A:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 9)
				{
					return array;
				}
				continue;
				IL_143:
				if (num != 5)
				{
					goto IL_16A;
				}
				IL_154:
				array = new byte[num3];
				num = 6;
				goto IL_16A;
			}
			throw new CryptographicException("");
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0002701C File Offset: 0x0002521C
		public byte[] EDFjkyz4sX7(params byte[][] H2JMWCsCb)
		{
			int num = 0;
			byte[] array3;
			for (;;)
			{
				if (num == 5)
				{
					goto IL_1F;
				}
				IL_35:
				if (num == 19)
				{
					goto IL_46;
				}
				IL_5D:
				if (num == 2)
				{
					num = 3;
				}
				byte[] array;
				if (num == 16)
				{
					if (array == null)
					{
						goto IL_46;
					}
					num = 17;
				}
				int num2;
				byte[] array2;
				if (num == 7)
				{
					num2 += array2.Length;
					num = 8;
				}
				int num3;
				if (num == 3)
				{
					num3 = 0;
					num = 4;
				}
				if (num == 14)
				{
					goto IL_20A;
				}
				if (num == 9)
				{
					goto IL_11E;
				}
				IL_136:
				if (num == 8)
				{
					goto IL_147;
				}
				IL_15E:
				if (num == 6)
				{
					if (array2 == null)
					{
						goto IL_147;
					}
					num = 7;
				}
				if (num == 4)
				{
					goto IL_11E;
				}
				int num4;
				if (num == 13)
				{
					num4 = 0;
					num = 14;
				}
				int num5;
				if (num == 17)
				{
					Buffer.BlockCopy(array, 0, array3, num5, array.Length);
					num = 18;
				}
				if (num == 20)
				{
					goto IL_20A;
				}
				goto IL_222;
				IL_147:
				num3++;
				num = 9;
				goto IL_15E;
				IL_11E:
				if (num3 >= H2JMWCsCb.Length)
				{
					num = 10;
					goto IL_136;
				}
				goto IL_1F;
				IL_26C:
				if (num == 11)
				{
					num5 = 0;
					num = 12;
				}
				if (num == 10)
				{
					array3 = new byte[num2 - 1 + 1];
					num = 11;
				}
				if (num == 18)
				{
					num5 += array.Length;
					num = 19;
				}
				if (num == 12)
				{
					num = 13;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 21)
				{
					break;
				}
				continue;
				IL_222:
				if (num == 1)
				{
					num2 = 0;
					num = 2;
				}
				if (num != 15)
				{
					goto IL_26C;
				}
				IL_256:
				array = H2JMWCsCb[num4];
				num = 16;
				goto IL_26C;
				IL_20A:
				if (num4 >= H2JMWCsCb.Length)
				{
					num = 21;
					goto IL_222;
				}
				goto IL_256;
				IL_46:
				num4++;
				num = 20;
				goto IL_5D;
				IL_1F:
				array2 = H2JMWCsCb[num3];
				num = 6;
				goto IL_35;
			}
			return array3;
		}
	}
}
