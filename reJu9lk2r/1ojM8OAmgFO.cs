using System;

namespace reJu9lk2r
{
	// Token: 0x0200005B RID: 91
	public class 1ojM8OAmgFO
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x00024720 File Offset: 0x00022920
		public q3iR8 Xuk(byte[] fH0X)
		{
			int num = 0;
			q3iR8 q3iR;
			for (;;)
			{
				if (num != 6)
				{
					goto IL_4B;
				}
				1ojM8OAmgFO.wM33s wM33s;
				int num2;
				byte[] array;
				int length;
				switch (wM33s)
				{
				case 1ojM8OAmgFO.wM33s.OjQkxi:
				{
					q3iR.35ejV.Add(new q3iR8
					{
						fQjLHGgOkH7 = 1ojM8OAmgFO.wM33s.OjQkxi,
						EUK9l = (int)fH0X[num2 + 1]
					});
					array = new byte[(int)fH0X[num2 + 1]];
					length = ((num2 + 2 + (int)fH0X[num2 + 1] > fH0X.Length) ? (fH0X.Length - (num2 + 2)) : ((int)fH0X[num2 + 1]));
					Array.Copy(fH0X, num2 + 2, array, 0, length);
					q3iR8[] array2 = q3iR.35ejV.ToArray();
					q3iR.35ejV[array2.Length - 1].UfibxSIi = array;
					num2 = num2 + 1 + q3iR.35ejV[array2.Length - 1].EUK9l;
					goto IL_6F0;
				}
				case 1ojM8OAmgFO.wM33s.gadu:
				case 1ojM8OAmgFO.wM33s.gmOKB:
					goto IL_6F0;
				case 1ojM8OAmgFO.wM33s.nNSw4se3:
				{
					q3iR.35ejV.Add(new q3iR8
					{
						fQjLHGgOkH7 = 1ojM8OAmgFO.wM33s.nNSw4se3,
						EUK9l = (int)fH0X[num2 + 1]
					});
					array = new byte[(int)fH0X[num2 + 1]];
					length = ((num2 + 2 + (int)fH0X[num2 + 1] > fH0X.Length) ? (fH0X.Length - (num2 + 2)) : ((int)fH0X[num2 + 1]));
					Array.Copy(fH0X, num2 + 2, array, 0, length);
					q3iR8[] array3 = q3iR.35ejV.ToArray();
					q3iR.35ejV[array3.Length - 1].UfibxSIi = array;
					num2 = num2 + 1 + q3iR.35ejV[array3.Length - 1].EUK9l;
					goto IL_6F0;
				}
				case 1ojM8OAmgFO.wM33s.uxDVh:
				{
					q3iR.35ejV.Add(new q3iR8
					{
						fQjLHGgOkH7 = 1ojM8OAmgFO.wM33s.uxDVh,
						EUK9l = (int)fH0X[num2 + 1]
					});
					array = new byte[(int)fH0X[num2 + 1]];
					length = ((num2 + 2 + (int)fH0X[num2 + 1] > fH0X.Length) ? (fH0X.Length - (num2 + 2)) : ((int)fH0X[num2 + 1]));
					Array.Copy(fH0X, num2 + 2, array, 0, length);
					q3iR8[] array4 = q3iR.35ejV.ToArray();
					q3iR.35ejV[array4.Length - 1].UfibxSIi = array;
					num2 = num2 + 1 + q3iR.35ejV[array4.Length - 1].EUK9l;
					goto IL_6F0;
				}
				default:
					num = 7;
					goto IL_4B;
				}
				IL_C5:
				if (num == 5)
				{
					wM33s = (1ojM8OAmgFO.wM33s)fH0X[num2];
					num = 6;
				}
				if (num == 12)
				{
					goto IL_263;
				}
				if (num == 7)
				{
					if (wM33s != 1ojM8OAmgFO.wM33s.IdhKimMqD)
					{
						goto IL_6F0;
					}
					num = 8;
				}
				if (num == 9)
				{
					q3iR.fQjLHGgOkH7 = 1ojM8OAmgFO.wM33s.IdhKimMqD;
					num = 10;
				}
				if (num != 8)
				{
					goto IL_183;
				}
				if (q3iR.EUK9l == 0)
				{
					num = 9;
					goto IL_183;
				}
				goto IL_208;
				IL_252:
				if (num == 15)
				{
					goto IL_263;
				}
				goto IL_288;
				IL_183:
				if (num == 3)
				{
					goto IL_6FE;
				}
				if (num == 2)
				{
					num2 = 0;
					num = 3;
				}
				if (num == 14)
				{
					array = new byte[(int)fH0X[num2 + 1]];
					num = 15;
				}
				if (num != 13)
				{
					goto IL_252;
				}
				IL_208:
				q3iR.35ejV.Add(new q3iR8
				{
					fQjLHGgOkH7 = 1ojM8OAmgFO.wM33s.IdhKimMqD,
					EUK9l = (int)fH0X[num2 + 1]
				});
				num = 14;
				goto IL_252;
				IL_288:
				if (num == 11)
				{
					array = new byte[q3iR.EUK9l];
					num = 12;
				}
				if (num == 0)
				{
					num = 1;
				}
				int num3;
				if (num == 16)
				{
					num3 = array.Length;
					goto IL_306;
				}
				continue;
				IL_263:
				if (array.Length <= fH0X.Length - (num2 + 2))
				{
					num = 16;
					goto IL_288;
				}
				num3 = fH0X.Length - (num2 + 2);
				IL_306:
				length = num3;
				Array.Copy(fH0X, num2 + 2, array, 0, length);
				q3iR.35ejV.Add(this.Xuk(array));
				num2 = num2 + 1 + (int)fH0X[num2 + 1];
				goto IL_6F0;
				IL_4B:
				if (num == 1)
				{
					q3iR = new q3iR8();
					num = 2;
				}
				if (num == 10)
				{
					q3iR.EUK9l = fH0X.Length - (num2 + 2);
					num = 11;
				}
				if (num != 4)
				{
					goto IL_C5;
				}
				IL_B3:
				num = 5;
				goto IL_C5;
				IL_6FE:
				if (num2 >= fH0X.Length)
				{
					break;
				}
				goto IL_B3;
				IL_6F0:
				num2++;
				goto IL_6FE;
			}
			return q3iR;
		}

		// Token: 0x0200005C RID: 92
		public enum wM33s
		{
			// Token: 0x040000D2 RID: 210
			IdhKimMqD = 48,
			// Token: 0x040000D3 RID: 211
			OjQkxi = 2,
			// Token: 0x040000D4 RID: 212
			gadu,
			// Token: 0x040000D5 RID: 213
			nNSw4se3,
			// Token: 0x040000D6 RID: 214
			gmOKB,
			// Token: 0x040000D7 RID: 215
			uxDVh
		}
	}
}
