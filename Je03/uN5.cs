using System;
using System.Linq;
using System.Text;
using nb1D668;

namespace Je03
{
	// Token: 0x02000078 RID: 120
	public class uN5 : 2l3Fyo
	{
		// Token: 0x06000223 RID: 547 RVA: 0x0000797B File Offset: 0x00005B7B
		public uN5()
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00007983 File Offset: 0x00005B83
		public uN5(string Name, Ulguje467X4 TypedPropertyValue)
		{
			this.BodGstHW = Name;
			base.mxxLqwO53K = TypedPropertyValue;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00007999 File Offset: 0x00005B99
		public override uint WGqjkuXzJj
		{
			get
			{
				return 9U + this.LBBFg9p + (uint)base.mxxLqwO53K.GetBytes().Length;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000226 RID: 550 RVA: 0x000079B2 File Offset: 0x00005BB2
		public uint LBBFg9p
		{
			get
			{
				return (uint)((this.BodGstHW.Length + 1) * 2);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00007978 File Offset: 0x00005B78
		public byte wgER
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000228 RID: 552 RVA: 0x000079C3 File Offset: 0x00005BC3
		// (set) Token: 0x06000229 RID: 553 RVA: 0x000079CB File Offset: 0x00005BCB
		public string BodGstHW { get; set; }

		// Token: 0x0600022A RID: 554 RVA: 0x0002C89C File Offset: 0x0002AA9C
		public override byte[] GetBytes()
		{
			int num = 0;
			byte[] array;
			do
			{
				if (num == 4)
				{
					Buffer.BlockCopy(Encoding.Unicode.GetBytes(this.BodGstHW), 0, array, 9, 4);
					num = 5;
				}
				if (num == 2)
				{
					Buffer.BlockCopy(BitConverter.GetBytes(this.rJ0NMMldXBY), 0, array, 0, 4);
					num = 3;
				}
				if (num == 5)
				{
					Buffer.BlockCopy(base.mxxLqwO53K.GetBytes(), 0, array, (int)(9U + this.LBBFg9p), base.mxxLqwO53K.GetBytes().Length);
					num = 6;
				}
				if (num == 1)
				{
					array = new byte[this.rJ0NMMldXBY];
					num = 2;
				}
				if (num == 3)
				{
					Buffer.BlockCopy(BitConverter.GetBytes(this.LBBFg9p), 0, array, 4, 4);
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

		// Token: 0x0600022B RID: 555 RVA: 0x0002CA38 File Offset: 0x0002AC38
		public override string ToString()
		{
			int num = 0;
			StringBuilder stringBuilder;
			do
			{
				if (num == 1)
				{
					stringBuilder = new StringBuilder();
					num = 2;
				}
				if (num == 8)
				{
					stringBuilder.AppendLine();
					num = 9;
				}
				if (num == 7)
				{
					stringBuilder.AppendFormat("Name: {0}", this.BodGstHW);
					num = 8;
				}
				if (num == 4)
				{
					stringBuilder.AppendLine();
					num = 5;
				}
				if (num == 3)
				{
					stringBuilder.AppendFormat("ValueSize: {0} (0x{0:X})", this.rJ0NMMldXBY);
					num = 4;
				}
				if (num == 5)
				{
					stringBuilder.AppendFormat("NameSize: {0} (0x{0:X})", this.LBBFg9p);
					num = 6;
				}
				if (num == 6)
				{
					stringBuilder.AppendLine();
					num = 7;
				}
				if (num == 2)
				{
					stringBuilder.Append(base.ToString());
					num = 3;
				}
				if (num == 9)
				{
					stringBuilder.Append(base.mxxLqwO53K.ToString());
					num = 10;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 10);
			return stringBuilder.ToString();
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0002CC30 File Offset: 0x0002AE30
		public static 2l3Fyo nBn6CtFY(byte[] wKuIeJkujk)
		{
			int num = 0;
			uint num2;
			for (;;)
			{
				uN5 uN;
				if (num == 1)
				{
					uN = new uN5();
					num = 2;
				}
				if (num == 3)
				{
					break;
				}
				if (num != 5)
				{
					goto IL_96;
				}
				if ((long)wKuIeJkujk.Length < (long)((ulong)num2))
				{
					num = 6;
					goto IL_96;
				}
				goto IL_1F3;
				IL_2B7:
				if (num == 9)
				{
					goto Block_14;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 15)
				{
					return uN;
				}
				continue;
				IL_20E:
				if (num == 14)
				{
					443AbOc type;
					byte[] value;
					uN.mxxLqwO53K = new Ulguje467X4(type, value);
					num = 15;
				}
				uint num3;
				if (num == 13)
				{
					byte[] value = wKuIeJkujk.Skip((int)(9U + num3)).Take((int)((ulong)(num2 - 9U) - (ulong)((long)num3))).ToArray<byte>();
					num = 14;
				}
				if (num == 4)
				{
					goto IL_29C;
				}
				goto IL_2B7;
				IL_96:
				if (num == 12)
				{
					443AbOc type = (443AbOc)BitConverter.ToUInt16(wKuIeJkujk, 9);
					num = 13;
				}
				if (num == 2)
				{
					if (wKuIeJkujk.Length >= 9)
					{
						goto IL_29C;
					}
					num = 3;
				}
				byte[] bytes;
				if (num == 11)
				{
					uN5 uN2 = uN;
					string @string = Encoding.Unicode.GetString(bytes);
					char[] trimChars = new char[1];
					uN2.BodGstHW = @string.TrimEnd(trimChars);
					num = 12;
				}
				if (num == 6)
				{
					goto Block_9;
				}
				if (num != 8)
				{
					goto IL_1A8;
				}
				if ((long)(wKuIeJkujk.Length - 9) < (long)((ulong)num3))
				{
					num = 9;
					goto IL_1A8;
				}
				goto IL_1B9;
				IL_1E2:
				if (num == 7)
				{
					goto IL_1F3;
				}
				goto IL_20E;
				IL_1A8:
				if (num != 10)
				{
					goto IL_1E2;
				}
				IL_1B9:
				bytes = wKuIeJkujk.Skip(9).Take((int)num3).ToArray<byte>();
				num = 11;
				goto IL_1E2;
				IL_29C:
				num2 = BitConverter.ToUInt32(wKuIeJkujk, 0);
				num = 5;
				goto IL_2B7;
				IL_1F3:
				num3 = BitConverter.ToUInt32(wKuIeJkujk, 4);
				num = 8;
				goto IL_20E;
			}
			throw new ArgumentException(string.Format("Size of the StringName is less than 9 ({0})", wKuIeJkujk.Length));
			Block_9:
			throw new ArgumentException(string.Format("Size of the StringName is not equal to {0} ({1})", num2, wKuIeJkujk.Length));
			Block_14:
			throw new ArgumentException(string.Format("Size of the NameSize is not equal to {0} ({1})", num2, wKuIeJkujk.Length - 8));
		}
	}
}
