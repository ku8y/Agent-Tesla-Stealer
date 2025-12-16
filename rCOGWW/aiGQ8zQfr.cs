using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace rCOGWW
{
	// Token: 0x02000054 RID: 84
	public class aiGQ8zQfr
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600018D RID: 397 RVA: 0x000077A0 File Offset: 0x000059A0
		// (set) Token: 0x0600018E RID: 398 RVA: 0x000077A8 File Offset: 0x000059A8
		public string djJriQ { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600018F RID: 399 RVA: 0x000077B1 File Offset: 0x000059B1
		// (set) Token: 0x06000190 RID: 400 RVA: 0x000077B9 File Offset: 0x000059B9
		public List<KeyValuePair<string, string>> rVBLiIz8abw { get; private set; }

		// Token: 0x06000191 RID: 401 RVA: 0x00020770 File Offset: 0x0001E970
		public aiGQ8zQfr(string FileName)
		{
			List<byte> list = new List<byte>();
			this.rVBLiIz8abw = new List<KeyValuePair<string, string>>();
			using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(FileName)))
			{
				int i = 0;
				int num = (int)binaryReader.BaseStream.Length;
				while (i < num)
				{
					list.Add(binaryReader.ReadByte());
					i++;
				}
			}
			string text = BitConverter.ToString(this.NABgAY(list.ToArray(), 0, 4, false)).Replace("-", "");
			string text2 = BitConverter.ToString(this.NABgAY(list.ToArray(), 4, 4, false)).Replace("-", "");
			int num2 = BitConverter.ToInt32(this.NABgAY(list.ToArray(), 12, 4, true), 0);
			if (text.Equals("00061561"))
			{
				this.djJriQ = "Berkelet DB";
				if (text2.Equals("00000002"))
				{
					this.djJriQ += " 1.85 (Hash, version 2, native byte-order)";
				}
				int num3 = int.Parse(BitConverter.ToString(this.NABgAY(list.ToArray(), 56, 4, false)).Replace("-", ""));
				int num4 = 1;
				while (this.rVBLiIz8abw.Count < num3)
				{
					string[] array = new string[(num3 - this.rVBLiIz8abw.Count) * 2];
					for (int j = 0; j < (num3 - this.rVBLiIz8abw.Count) * 2; j++)
					{
						array[j] = BitConverter.ToString(this.NABgAY(list.ToArray(), num2 * num4 + 2 + j * 2, 2, true)).Replace("-", "");
					}
					Array.Sort<string>(array);
					for (int k = 0; k < array.Length; k += 2)
					{
						int num5 = Convert.ToInt32(array[k], 16) + num2 * num4;
						int num6 = Convert.ToInt32(array[k + 1], 16) + num2 * num4;
						int num7 = (k + 2 >= array.Length) ? (num2 + num2 * num4) : (Convert.ToInt32(array[k + 2], 16) + num2 * num4);
						string @string = Encoding.ASCII.GetString(this.NABgAY(list.ToArray(), num6, num7 - num6, false));
						string value = BitConverter.ToString(this.NABgAY(list.ToArray(), num5, num6 - num5, false));
						if (@string != null && @string.Replace(" ", "") != string.Empty)
						{
							this.rVBLiIz8abw.Add(new KeyValuePair<string, string>(@string, value));
						}
					}
					num4++;
				}
				return;
			}
			this.djJriQ = "Unknow database format";
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00020A74 File Offset: 0x0001EC74
		public string YB9tukTTV(string jpWvC)
		{
			int num = 0;
			List<KeyValuePair<string, string>>.Enumerator enumerator;
			while (num != 2)
			{
				if (num == 1)
				{
					enumerator = this.rVBLiIz8abw.GetEnumerator();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 3)
				{
					string result;
					return result;
				}
			}
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, string> keyValuePair = enumerator.Current;
					if (keyValuePair.Key == jpWvC)
					{
						return keyValuePair.Value;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return string.Empty;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00020B84 File Offset: 0x0001ED84
		private byte[] NABgAY(byte[] wVUgbF9iZCZ, int g0p, int jcY, bool D006MktG)
		{
			int num = 0;
			byte[] array;
			for (;;)
			{
				int num2;
				if (num == 3)
				{
					num2 = g0p;
					num = 4;
				}
				if (num == 4)
				{
					goto IL_AA;
				}
				if (num == 1)
				{
					array = new byte[jcY];
					num = 2;
				}
				if (num == 10)
				{
					Array.Reverse(array);
					num = 11;
				}
				if (num == 8)
				{
					goto IL_AA;
				}
				goto IL_C5;
				IL_187:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 11)
				{
					break;
				}
				continue;
				IL_C5:
				int num3;
				if (num == 2)
				{
					num3 = 0;
					num = 3;
				}
				if (num == 6)
				{
					num3++;
					num = 7;
				}
				if (num == 9)
				{
					if (!D006MktG)
					{
						break;
					}
					num = 10;
				}
				if (num == 7)
				{
					num2++;
					num = 8;
				}
				if (num != 5)
				{
					goto IL_187;
				}
				IL_16C:
				array[num3] = wVUgbF9iZCZ[num2];
				num = 6;
				goto IL_187;
				IL_AA:
				if (num2 >= g0p + jcY)
				{
					num = 9;
					goto IL_C5;
				}
				goto IL_16C;
			}
			return array;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00020D54 File Offset: 0x0001EF54
		private byte[] iOr9GNXaD(byte[] OWuKn6pgji)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Array.Reverse(OWuKn6pgji);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			return OWuKn6pgji;
		}
	}
}
