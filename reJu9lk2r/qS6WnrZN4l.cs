using System;
using System.Security.Cryptography;
using System.Text;

namespace reJu9lk2r
{
	// Token: 0x0200005E RID: 94
	public class qS6WnrZN4l
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x00025514 File Offset: 0x00023714
		public string u73nVj(string mbZE9tGGDc, string BiJq)
		{
			int num = 0;
			UTF8Encoding utf8Encoding;
			byte[] inArray;
			MD5CryptoServiceProvider md5CryptoServiceProvider;
			do
			{
				if (num == 2)
				{
					utf8Encoding = new UTF8Encoding();
					num = 3;
				}
				if (num == 1)
				{
					inArray = null;
					num = 2;
				}
				if (num == 3)
				{
					md5CryptoServiceProvider = new MD5CryptoServiceProvider();
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
			try
			{
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider
				{
					Key = md5CryptoServiceProvider.ComputeHash(utf8Encoding.GetBytes(BiJq)),
					Mode = CipherMode.ECB,
					Padding = PaddingMode.PKCS7
				};
				byte[] bytes = utf8Encoding.GetBytes(mbZE9tGGDc);
				try
				{
					ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor();
					inArray = cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length);
				}
				finally
				{
					tripleDESCryptoServiceProvider.Clear();
					md5CryptoServiceProvider.Clear();
				}
			}
			finally
			{
				if (md5CryptoServiceProvider != null)
				{
					((IDisposable)md5CryptoServiceProvider).Dispose();
				}
			}
			return Convert.ToBase64String(inArray);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000256A8 File Offset: 0x000238A8
		public static string 3sq(string aS4A9JnOx, byte[] JS4Fa, byte[] 5mC)
		{
			int num = 0;
			string s;
			do
			{
				if (num == 2)
				{
					if (aS4A9JnOx[0] != '_')
					{
						break;
					}
					num = 3;
				}
				if (num == 1)
				{
					s = aS4A9JnOx;
					num = 2;
				}
				if (num == 3)
				{
					s = aS4A9JnOx.Substring(1);
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
			string result;
			try
			{
				byte[] array = Convert.FromBase64String(s);
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider
				{
					Key = JS4Fa,
					Mode = CipherMode.CBC,
					IV = 5mC,
					Padding = PaddingMode.None
				};
				byte[] bytes = tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(array, 0, array.Length);
				result = Encoding.UTF8.GetString(bytes);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00025824 File Offset: 0x00023A24
		public static string ndFD4zyM(byte[] 4A5, byte[] 1YUgYF0G, byte[] SyS4GdtlHQ)
		{
			int num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
			string result;
			try
			{
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider
				{
					Key = 1YUgYF0G,
					Mode = CipherMode.CBC,
					IV = SyS4GdtlHQ,
					Padding = PaddingMode.None
				};
				byte[] bytes = tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(4A5, 0, 4A5.Length);
				result = Encoding.UTF8.GetString(bytes);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00025914 File Offset: 0x00023B14
		public static byte[] BE6M1GJVa(byte[] 3NOn, byte[] qFi, byte[] hMhvLQv)
		{
			int num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
			byte[] result;
			try
			{
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider
				{
					Key = qFi,
					Mode = CipherMode.CBC,
					IV = hMhvLQv,
					Padding = PaddingMode.None
				};
				byte[] array = tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(3NOn, 0, 3NOn.Length);
				result = array;
			}
			catch
			{
				result = null;
			}
			return result;
		}
	}
}
