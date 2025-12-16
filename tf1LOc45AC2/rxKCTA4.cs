using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Je03;

namespace tf1LOc45AC2
{
	// Token: 0x0200007A RID: 122
	public class rxKCTA4 : iAafP
	{
		// Token: 0x06000236 RID: 566 RVA: 0x000079FB File Offset: 0x00005BFB
		public rxKCTA4()
		{
			this.SzFh6R = new List<wwVTa1>();
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00007A0E File Offset: 0x00005C0E
		public rxKCTA4(List<wwVTa1> SerializedPropertyStorage)
		{
			this.SzFh6R = SerializedPropertyStorage;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0002D4C8 File Offset: 0x0002B6C8
		public static rxKCTA4 GcV(byte[] rnp5)
		{
			int num = 0;
			while (num != 3)
			{
				rxKCTA4 rxKCTA;
				if (num == 1)
				{
					rxKCTA = new rxKCTA4();
					num = 2;
				}
				if (num == 9)
				{
					goto IL_1E7;
				}
				uint num2;
				if (num == 5)
				{
					if ((long)rnp5.Length >= (long)((ulong)num2))
					{
						goto IL_23B;
					}
					num = 6;
				}
				wwVTa1 item;
				if (num == 11)
				{
					rxKCTA.SzFh6R.Add(item);
					num = 12;
				}
				uint num3;
				if (num == 13)
				{
					num3 = BitConverter.ToUInt32(rnp5, 0);
					num = 14;
				}
				if (num == 12)
				{
					rnp5 = rnp5.Skip((int)num3).ToArray<byte>();
					num = 13;
				}
				if (num == 4)
				{
					goto IL_14E;
				}
				IL_169:
				if (num == 2)
				{
					if (rnp5.Length >= 8)
					{
						goto IL_14E;
					}
					num = 3;
				}
				if (num == 6)
				{
					throw new ArgumentException(string.Format("Size of the SerializedPropertyStore is less than {0} ({1})", num2, rnp5.Length));
				}
				if (num == 14)
				{
					goto IL_1E7;
				}
				goto IL_1FE;
				IL_14E:
				num2 = BitConverter.ToUInt32(rnp5, 0);
				num = 5;
				goto IL_169;
				IL_282:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 15)
				{
					return rxKCTA;
				}
				continue;
				IL_25B:
				if (num == 10)
				{
					goto IL_26C;
				}
				goto IL_282;
				IL_1FE:
				if (num == 8)
				{
					num3 = BitConverter.ToUInt32(rnp5, 0);
					num = 9;
				}
				if (num == 7)
				{
					goto IL_23B;
				}
				goto IL_25B;
				IL_26C:
				item = wwVTa1.d9DuXvT7N(rnp5);
				num = 11;
				goto IL_282;
				IL_1E7:
				if (num3 <= 5U)
				{
					num = 15;
					goto IL_1FE;
				}
				goto IL_26C;
				IL_23B:
				rnp5 = rnp5.Skip(4).ToArray<byte>();
				num = 8;
				goto IL_25B;
			}
			throw new ArgumentException(string.Format("Size of the SerializedPropertyStore is less than 8 ({0})", rnp5.Length));
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0002D794 File Offset: 0x0002B994
		public virtual uint YIc
		{
			get
			{
				uint num = 8U;
				for (int i = 0; i < this.SzFh6R.Count; i++)
				{
					num += this.SzFh6R[i].KmZUd757A;
				}
				return num;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00007A1D File Offset: 0x00005C1D
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00007A25 File Offset: 0x00005C25
		public List<wwVTa1> SzFh6R { get; set; }

		// Token: 0x0600023C RID: 572 RVA: 0x0002D7D0 File Offset: 0x0002B9D0
		public override byte[] GetBytes()
		{
			int num = 0;
			byte[] array;
			for (;;)
			{
				int num2;
				wwVTa1 wwVTa;
				if (num == 8)
				{
					num2 += (int)wwVTa.KmZUd757A;
					num = 9;
				}
				if (num == 6)
				{
					goto IL_4B;
				}
				IL_6A:
				if (num == 7)
				{
					Buffer.BlockCopy(wwVTa.GetBytes(), 0, array, num2, (int)wwVTa.KmZUd757A);
					num = 8;
				}
				if (num == 5)
				{
					goto IL_1B3;
				}
				int num3;
				if (num == 9)
				{
					num3++;
					num = 10;
				}
				if (num == 3)
				{
					Buffer.BlockCopy(BitConverter.GetBytes(this.YIc), 0, array, 0, 4);
					num = 4;
				}
				if (num == 4)
				{
					num3 = 0;
					num = 5;
				}
				if (num == 2)
				{
					array = new byte[this.YIc];
					num = 3;
				}
				if (num == 1)
				{
					num2 = 4;
					num = 2;
				}
				if (num == 10)
				{
					goto IL_1B3;
				}
				IL_1D3:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 11)
				{
					break;
				}
				continue;
				IL_1B3:
				if (num3 >= this.SzFh6R.Count)
				{
					num = 11;
					goto IL_1D3;
				}
				IL_4B:
				wwVTa = this.SzFh6R[num3];
				num = 7;
				goto IL_6A;
			}
			return array;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0002D9EC File Offset: 0x0002BBEC
		public override string ToString()
		{
			int num = 0;
			StringBuilder stringBuilder;
			for (;;)
			{
				int num2;
				if (num == 8)
				{
					num2++;
					num = 9;
				}
				if (num == 6)
				{
					goto IL_138;
				}
				if (num == 5)
				{
					num2 = 0;
					num = 6;
				}
				if (num == 7)
				{
					goto IL_89;
				}
				goto IL_B3;
				IL_158:
				if (num == 3)
				{
					stringBuilder.AppendFormat("StoreSize: {0} (0x{0X})", this.YIc);
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 10)
				{
					break;
				}
				continue;
				IL_B3:
				if (num == 4)
				{
					stringBuilder.AppendLine();
					num = 5;
				}
				if (num == 1)
				{
					stringBuilder = new StringBuilder();
					num = 2;
				}
				if (num == 2)
				{
					stringBuilder.Append(base.ToString());
					num = 3;
				}
				if (num != 9)
				{
					goto IL_158;
				}
				IL_138:
				if (num2 >= this.SzFh6R.Count)
				{
					num = 10;
					goto IL_158;
				}
				IL_89:
				stringBuilder.Append(this.SzFh6R[num2].ToString());
				num = 8;
				goto IL_B3;
			}
			return stringBuilder.ToString();
		}
	}
}
