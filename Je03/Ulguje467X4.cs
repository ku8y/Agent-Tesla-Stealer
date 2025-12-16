using System;
using System.Linq;
using System.Text;
using nb1D668;

namespace Je03
{
	// Token: 0x02000077 RID: 119
	public class Ulguje467X4 : iAafP
	{
		// Token: 0x0600021D RID: 541 RVA: 0x0000795A File Offset: 0x00005B5A
		public Ulguje467X4(443AbOc Type, byte[] Value)
		{
			this.uPY1WSXFs = Type;
			this.GfXQAUl = Value;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00007970 File Offset: 0x00005B70
		public 443AbOc KCZq
		{
			get
			{
				return this.uPY1WSXFs;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00007978 File Offset: 0x00005B78
		public ushort MwAuVgF
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0002C398 File Offset: 0x0002A598
		public object DTO
		{
			get
			{
				if (this.GfXQAUl == null)
				{
					return null;
				}
				443AbOc type = this.KCZq;
				switch (type)
				{
				case 443AbOc.98lzlCjFV:
					return BitConverter.ToInt16(this.GfXQAUl, 0);
				case 443AbOc.O9jqwxj6:
				case 443AbOc.Il8qhlWKe3:
					return BitConverter.ToInt32(this.GfXQAUl, 0);
				case 443AbOc.dxNu6ek:
					return BitConverter.ToSingle(this.GfXQAUl, 0);
				case 443AbOc.ucxZk3:
					return BitConverter.ToDouble(this.GfXQAUl, 0);
				case 443AbOc.ej7:
				case 443AbOc.jB55Yd2ii:
					return BitConverter.ToUInt64(this.GfXQAUl, 0);
				case 443AbOc.hgVO:
					break;
				case 443AbOc.rel8ihj:
				case 443AbOc.XXLZN | 443AbOc.rel8ihj:
				case 443AbOc.dxNu6ek | 443AbOc.rel8ihj:
				case 443AbOc.XXLZN | 443AbOc.dxNu6ek | 443AbOc.rel8ihj:
				case 443AbOc.BIjqCb:
				case 443AbOc.XXLZN | 443AbOc.98lzlCjFV | 443AbOc.dxNu6ek | 443AbOc.rel8ihj:
				case 443AbOc.rel8ihj | 443AbOc.l0N28LsKIs:
				case 443AbOc.XXLZN | 443AbOc.rel8ihj | 443AbOc.l0N28LsKIs:
				case 443AbOc.98lzlCjFV | 443AbOc.rel8ihj | 443AbOc.l0N28LsKIs:
				case 443AbOc.XXLZN | 443AbOc.98lzlCjFV | 443AbOc.rel8ihj | 443AbOc.l0N28LsKIs:
				case 443AbOc.dxNu6ek | 443AbOc.rel8ihj | 443AbOc.l0N28LsKIs:
				case 443AbOc.XXLZN | 443AbOc.dxNu6ek | 443AbOc.rel8ihj | 443AbOc.l0N28LsKIs:
					goto IL_20F;
				case 443AbOc.O1t3vOpVBn:
				case 443AbOc.zzlUFL:
				case 443AbOc.iV2i:
					return BitConverter.ToUInt32(this.GfXQAUl, 0);
				case 443AbOc.niMoFhMN0Y:
					return this.GfXQAUl[0] != 0 || this.GfXQAUl[1] != 0;
				case 443AbOc.l0N28LsKIs:
					return (sbyte)this.GfXQAUl[0];
				case 443AbOc.Szg2g:
					return this.GfXQAUl[0];
				case 443AbOc.9f0fbWUt:
					return BitConverter.ToUInt16(this.GfXQAUl, 0);
				case 443AbOc.cZxl:
					return BitConverter.ToInt64(this.GfXQAUl, 0);
				case 443AbOc.nIEWGF50ae:
				{
					string @string = Encoding.Default.GetString(this.GfXQAUl.Skip(4).ToArray<byte>());
					char[] trimChars = new char[1];
					return @string.TrimEnd(trimChars);
				}
				case 443AbOc.kD2bL16rAVY:
				{
					string string2 = Encoding.Unicode.GetString(this.GfXQAUl.Skip(4).ToArray<byte>());
					char[] trimChars2 = new char[1];
					return string2.TrimEnd(trimChars2);
				}
				default:
					switch (type)
					{
					case 443AbOc.mFPSslAp:
						break;
					case 443AbOc.Xj0:
					case 443AbOc.dLwCpHQDr:
					case 443AbOc.Glb7rZLidO:
					case 443AbOc.cR1xMPZ:
					case 443AbOc.1MdBqrpJoU:
					case 443AbOc.Il4SI:
					case 443AbOc.QnSP1zGmQ:
					case 443AbOc.10Ozknk:
						goto IL_20F;
					case 443AbOc.44P:
						return new Guid(this.GfXQAUl);
					default:
						goto IL_20F;
					}
					break;
				}
				return DateTime.FromFileTimeUtc(BitConverter.ToInt64(this.GfXQAUl, 0));
				IL_20F:
				return this.GfXQAUl;
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0002C5BC File Offset: 0x0002A7BC
		public override byte[] GetBytes()
		{
			int num = 0;
			byte[] array;
			do
			{
				if (num == 4)
				{
					if (this.GfXQAUl == null)
					{
						break;
					}
					num = 5;
				}
				if (num == 2)
				{
					Buffer.BlockCopy(BitConverter.GetBytes((ushort)this.KCZq), 0, array, 0, 2);
					num = 3;
				}
				if (num == 1)
				{
					array = new byte[this.GfXQAUl.Length + 4];
					num = 2;
				}
				if (num == 5)
				{
					Buffer.BlockCopy(this.GfXQAUl, 0, array, 4, this.GfXQAUl.Length);
					num = 6;
				}
				if (num == 3)
				{
					Buffer.BlockCopy(BitConverter.GetBytes(this.MwAuVgF), 0, array, 2, 2);
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 6);
			return array;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0002C730 File Offset: 0x0002A930
		public override string ToString()
		{
			int num = 0;
			StringBuilder stringBuilder;
			do
			{
				if (num == 6)
				{
					stringBuilder.AppendLine();
					num = 7;
				}
				if (num == 4)
				{
					stringBuilder.AppendLine();
					num = 5;
				}
				if (num == 3)
				{
					stringBuilder.AppendFormat("Type: {0}", this.KCZq);
					num = 4;
				}
				if (num == 5)
				{
					stringBuilder.AppendFormat("Value: {0}", this.DTO.ToString());
					num = 6;
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
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 7);
			return stringBuilder.ToString();
		}

		// Token: 0x04000155 RID: 341
		private 443AbOc uPY1WSXFs;

		// Token: 0x04000156 RID: 342
		private byte[] GfXQAUl;
	}
}
