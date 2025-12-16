using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Je03
{
	// Token: 0x02000075 RID: 117
	public class wwVTa1 : iAafP
	{
		// Token: 0x0600020E RID: 526 RVA: 0x000078F2 File Offset: 0x00005AF2
		public wwVTa1()
		{
			this.9n6vI7Q7 = new List<2l3Fyo>();
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00007905 File Offset: 0x00005B05
		public wwVTa1(List<2l3Fyo> PropertyStorage)
		{
			this.9n6vI7Q7 = PropertyStorage;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0002B968 File Offset: 0x00029B68
		public virtual uint KmZUd757A
		{
			get
			{
				uint num = 28U;
				for (int i = 0; i < this.9n6vI7Q7.Count; i++)
				{
					num += this.9n6vI7Q7[i].rJ0NMMldXBY;
				}
				return num;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000211 RID: 529 RVA: 0x00007914 File Offset: 0x00005B14
		public uint fxN3h
		{
			get
			{
				return 1397773105U;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0000791B File Offset: 0x00005B1B
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00007923 File Offset: 0x00005B23
		public Guid D7kDk9 { get; set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0000792C File Offset: 0x00005B2C
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00007934 File Offset: 0x00005B34
		public List<2l3Fyo> 9n6vI7Q7 { get; set; }

		// Token: 0x06000216 RID: 534 RVA: 0x0002B9A4 File Offset: 0x00029BA4
		public override byte[] GetBytes()
		{
			int num = 0;
			byte[] array;
			for (;;)
			{
				if (num == 8)
				{
					goto IL_255;
				}
				if (num == 3)
				{
					Buffer.BlockCopy(BitConverter.GetBytes(this.KmZUd757A), 0, array, 0, 4);
					num = 4;
				}
				if (num == 2)
				{
					array = new byte[this.KmZUd757A];
					num = 3;
				}
				int num2;
				if (num == 12)
				{
					num2++;
					num = 13;
				}
				2l3Fyo 2l3Fyo;
				int num3;
				if (num == 10)
				{
					Buffer.BlockCopy(2l3Fyo.GetBytes(), 0, array, num3, (int)2l3Fyo.rJ0NMMldXBY);
					num = 11;
				}
				if (num == 4)
				{
					Buffer.BlockCopy(BitConverter.GetBytes(this.fxN3h), 0, array, 4, 4);
					num = 5;
				}
				Guid formatID;
				if (num == 5)
				{
					formatID = this.D7kDk9;
					num = 6;
				}
				if (num == 1)
				{
					num3 = 24;
					num = 2;
				}
				if (num == 9)
				{
					goto IL_19B;
				}
				goto IL_1BA;
				IL_275:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 14)
				{
					break;
				}
				continue;
				IL_1BA:
				if (num == 11)
				{
					num3 += (int)2l3Fyo.rJ0NMMldXBY;
					num = 12;
				}
				if (num == 6)
				{
					Buffer.BlockCopy(formatID.ToByteArray(), 0, array, 8, 16);
					num = 7;
				}
				if (num == 7)
				{
					num2 = 0;
					num = 8;
				}
				if (num != 13)
				{
					goto IL_275;
				}
				IL_255:
				if (num2 >= this.9n6vI7Q7.Count)
				{
					num = 14;
					goto IL_275;
				}
				IL_19B:
				2l3Fyo = this.9n6vI7Q7[num2];
				num = 10;
				goto IL_1BA;
			}
			return array;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0002BC60 File Offset: 0x00029E60
		public override string ToString()
		{
			int num = 0;
			StringBuilder stringBuilder;
			for (;;)
			{
				if (num == 3)
				{
					stringBuilder.AppendFormat("StorageSize: {0} (0x{0:X})", this.KmZUd757A);
					num = 4;
				}
				if (num == 6)
				{
					stringBuilder.AppendLine();
					num = 7;
				}
				int num2;
				if (num == 12)
				{
					num2++;
					num = 13;
				}
				if (num == 4)
				{
					stringBuilder.AppendLine();
					num = 5;
				}
				if (num == 7)
				{
					stringBuilder.AppendFormat("FormatID: {0}", this.D7kDk9);
					num = 8;
				}
				if (num == 8)
				{
					stringBuilder.AppendLine();
					num = 9;
				}
				if (num == 1)
				{
					stringBuilder = new StringBuilder();
					num = 2;
				}
				if (num == 9)
				{
					num2 = 0;
					num = 10;
				}
				if (num == 11)
				{
					goto IL_171;
				}
				IL_19B:
				if (num == 2)
				{
					stringBuilder.Append(base.ToString());
					num = 3;
				}
				if (num == 13)
				{
					goto IL_1D9;
				}
				IL_1F9:
				if (num == 5)
				{
					stringBuilder.AppendFormat("Version: 0x{0:X}", this.fxN3h);
					num = 6;
				}
				if (num != 10)
				{
					if (num == 0)
					{
						num = 1;
					}
					if (num == 14)
					{
						break;
					}
					continue;
				}
				IL_1D9:
				if (num2 >= this.9n6vI7Q7.Count)
				{
					num = 14;
					goto IL_1F9;
				}
				IL_171:
				stringBuilder.Append(this.9n6vI7Q7[num2].ToString());
				num = 12;
				goto IL_19B;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0002BF00 File Offset: 0x0002A100
		public static wwVTa1 d9DuXvT7N(byte[] Fuqyx1FLE)
		{
			int num = 0;
			while (num != 3)
			{
				if (num == 20)
				{
					goto IL_59;
				}
				IL_6F:
				if (num == 4)
				{
					goto IL_80;
				}
				IL_9B:
				if (num == 19)
				{
					goto IL_286;
				}
				uint num2;
				if (num == 6)
				{
					throw new ArgumentException(string.Format("Size of the SerializedPropertyStore is less than {0} ({1})", num2, Fuqyx1FLE.Length));
				}
				wwVTa1 wwVTa;
				if (num == 1)
				{
					wwVTa = new wwVTa1();
					num = 2;
				}
				if (num == 10)
				{
					goto IL_131;
				}
				IL_148:
				uint num3;
				if (num == 22)
				{
					Fuqyx1FLE = Fuqyx1FLE.Skip((int)num3).ToArray<byte>();
					num = 23;
				}
				Guid formatID;
				if (num == 17)
				{
					if (!formatID.Equals(new Guid("{D5CDD505-2E9C-101B-9397-08002B2CF9AE}")))
					{
						goto IL_59;
					}
					num = 18;
				}
				if (num == 16)
				{
					goto IL_1C0;
				}
				IL_1D6:
				if (num == 24)
				{
					goto IL_1E7;
				}
				IL_1FE:
				uint num4;
				if (num == 8)
				{
					if (wwVTa.fxN3h == num4)
					{
						goto IL_131;
					}
					num = 9;
				}
				if (num != 15)
				{
					if (num == 14)
					{
						num3 = BitConverter.ToUInt32(Fuqyx1FLE, 0);
						num = 15;
					}
					if (num == 21)
					{
						goto IL_286;
					}
					goto IL_2A1;
				}
				IL_1E7:
				if (num3 <= 5U)
				{
					num = 25;
					goto IL_1FE;
				}
				IL_1C0:
				formatID = wwVTa.D7kDk9;
				num = 17;
				goto IL_1D6;
				IL_131:
				byte[] array = new byte[16];
				num = 11;
				goto IL_148;
				IL_2A1:
				if (num == 9)
				{
					throw new ArgumentException(string.Format("Version is not equal to {0} ({1})", wwVTa.fxN3h, num4));
				}
				if (num != 5)
				{
					goto IL_312;
				}
				if ((long)Fuqyx1FLE.Length < (long)((ulong)num2))
				{
					num = 6;
					goto IL_312;
				}
				goto IL_323;
				IL_33E:
				if (num == 11)
				{
					Buffer.BlockCopy(Fuqyx1FLE, 8, array, 0, array.Length);
					num = 12;
				}
				if (num == 23)
				{
					num3 = BitConverter.ToUInt32(Fuqyx1FLE, 0);
					num = 24;
				}
				if (num == 12)
				{
					wwVTa.D7kDk9 = new Guid(array);
					num = 13;
				}
				if (num == 13)
				{
					Fuqyx1FLE = Fuqyx1FLE.Skip(24).ToArray<byte>();
					num = 14;
				}
				2l3Fyo item;
				if (num == 18)
				{
					item = uN5.nBn6CtFY(Fuqyx1FLE);
					num = 19;
				}
				if (num == 2)
				{
					if (Fuqyx1FLE.Length >= 28)
					{
						goto IL_80;
					}
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 25)
				{
					return wwVTa;
				}
				continue;
				IL_312:
				if (num != 7)
				{
					goto IL_33E;
				}
				IL_323:
				num4 = BitConverter.ToUInt32(Fuqyx1FLE, 4);
				num = 8;
				goto IL_33E;
				IL_286:
				wwVTa.9n6vI7Q7.Add(item);
				num = 22;
				goto IL_2A1;
				IL_80:
				num2 = BitConverter.ToUInt32(Fuqyx1FLE, 0);
				num = 5;
				goto IL_9B;
				IL_59:
				item = jlA4fWu.0zA(Fuqyx1FLE);
				num = 21;
				goto IL_6F;
			}
			throw new ArgumentException(string.Format("Size of the SerializedPropertyStorage is less than 28 ({0})", Fuqyx1FLE.Length));
		}
	}
}
