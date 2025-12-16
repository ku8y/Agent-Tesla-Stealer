using System;
using System.Linq;
using System.Text;
using nb1D668;

namespace Je03
{
	public class jlA4fWu : 2l3Fyo
	{
		public jlA4fWu()
		{
		}

		public jlA4fWu(uint ID, Ulguje467X4 TypedPropertyValue)
		{
			this.0Xm = ID;
			base.mxxLqwO53K = TypedPropertyValue;
		}
		public override uint XjwelkS
		{
			get
			{
				uint num = (uint)base.mxxLqwO53K.GetBytes().Length;
				return 9U + num;
			}
		}

		public uint 0Xm { get; set; }


		public byte ysUai
		{
			get
			{
				return 0;
			}
		}

		public override byte[] GetBytes()
		{
			int num = 0;
			byte[] array;
			do
			{
				if (num == 1)
				{
					array = new byte[this.rJ0NMMldXBY];
					num = 2;
				}
				if (num == 4)
				{
					Buffer.BlockCopy(base.mxxLqwO53K.GetBytes(), 0, array, 9, base.mxxLqwO53K.GetBytes().Length);
					num = 5;
				}
				if (num == 2)
				{
					Buffer.BlockCopy(BitConverter.GetBytes(this.rJ0NMMldXBY), 0, array, 0, 4);
					num = 3;
				}
				if (num == 3)
				{
					Buffer.BlockCopy(BitConverter.GetBytes(this.0Xm), 0, array, 4, 4);
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
			return array;
		}

		public override string ToString()
		{
			int num = 0;
			StringBuilder stringBuilder;
			do
			{
				if (num == 3)
				{
					stringBuilder.AppendFormat("ValueSize: {0} (0x{0:X})", this.rJ0NMMldXBY);
					num = 4;
				}
				if (num == 2)
				{
					stringBuilder.Append(base.ToString());
					num = 3;
				}
				if (num == 7)
				{
					stringBuilder.Append(base.mxxLqwO53K.ToString());
					num = 8;
				}
				if (num == 6)
				{
					stringBuilder.AppendLine();
					num = 7;
				}
				if (num == 5)
				{
					stringBuilder.AppendFormat("ID: 0x{0:X}", this.0Xm);
					num = 6;
				}
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
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 8);
			return stringBuilder.ToString();
		}

		public static 2l3Fyo 0zA(byte[] hrJESTBUd)
		{
			int num = 0;
			while (num != 3)
			{
				uint num2;
				byte[] value;
				if (num == 9)
				{
					value = hrJESTBUd.Skip(13).Take((int)(num2 - 13U)).ToArray<byte>();
					num = 10;
				}
				jlA4fWu jlA4fWu;
				if (num == 10)
				{
					443AbOc type;
					jlA4fWu.mxxLqwO53K = new Ulguje467X4(type, value);
					num = 11;
				}
				if (num != 2)
				{
					goto IL_E2;
				}
				if (hrJESTBUd.Length < 9)
				{
					num = 3;
					goto IL_E2;
				}
				goto IL_1B5;
				IL_1D0:
				if (num == 8)
				{
					443AbOc type = (443AbOc)BitConverter.ToUInt16(hrJESTBUd, 9);
					num = 9;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 11)
				{
					return jlA4fWu;
				}
				continue;
				IL_E2:
				if (num == 7)
				{
					goto IL_F3;
				}
				IL_113:
				if (num == 1)
				{
					jlA4fWu = new jlA4fWu();
					num = 2;
				}
				if (num == 5)
				{
					if ((long)hrJESTBUd.Length >= (long)((ulong)num2))
					{
						goto IL_F3;
					}
					num = 6;
				}
				if (num == 6)
				{
					throw new ArgumentException(string.Format("Size of the StringName is not equal to {0} ({1})", num2, hrJESTBUd.Length));
				}
				if (num == 4)
				{
					goto IL_1B5;
				}
				goto IL_1D0;
				IL_F3:
				jlA4fWu.0Xm = BitConverter.ToUInt32(hrJESTBUd, 4);
				num = 8;
				goto IL_113;
				IL_1B5:
				num2 = BitConverter.ToUInt32(hrJESTBUd, 0);
				num = 5;
				goto IL_1D0;
			}
			throw new ArgumentException(string.Format("Size of the StringName is less than 9 ({0})", hrJESTBUd.Length));
		}
	}
}
