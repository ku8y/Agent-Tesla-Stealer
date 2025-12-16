using System;
using System.Security.Cryptography;

namespace reJu9lk2r
{
	// Token: 0x02000059 RID: 89
	public static class eha4ad2F
	{
		// Token: 0x060001A2 RID: 418 RVA: 0x000243F4 File Offset: 0x000225F4
		public static byte[] 0aCzg(byte[] oukXRyEn)
		{
			int num = 0;
			SHA1CryptoServiceProvider sha1CryptoServiceProvider;
			do
			{
				if (num == 1)
				{
					sha1CryptoServiceProvider = new SHA1CryptoServiceProvider();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			return sha1CryptoServiceProvider.ComputeHash(oukXRyEn);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00024478 File Offset: 0x00022678
		public static byte[] 3RB(byte[] yd2DMRjPKVL, byte[] bvMFM)
		{
			int num = 0;
			HMACSHA1 hmacsha;
			do
			{
				if (num == 1)
				{
					hmacsha = new HMACSHA1(yd2DMRjPKVL);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			return hmacsha.ComputeHash(bvMFM);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00024500 File Offset: 0x00022700
		public static string h5FmNC(string tFX1ljH, int bUw7Wzi6Ud)
		{
			int num = 0;
			string text;
			do
			{
				if (num == 1)
				{
					text = "";
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
				foreach (char c in tFX1ljH)
				{
					text += (char)((int)c ^ bUw7Wzi6Ud);
				}
			}
			catch
			{
			}
			return text;
		}
	}
}
