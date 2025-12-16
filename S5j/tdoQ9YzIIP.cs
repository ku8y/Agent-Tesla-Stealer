using System;
using System.Runtime.InteropServices;

namespace S5j
{
	// Token: 0x02000087 RID: 135
	public static class tdoQ9YzIIP
	{
		// Token: 0x06000242 RID: 578
		[DllImport("ntdll.dll", SetLastError = true)]
		public static extern ON8D3pP NtQueryObject([In] IntPtr Handle, [In] LaoL2fI5 ObjectInformationClass, [Out] IntPtr ObjectInformation, [In] int ObjectInformationLength, out int ReturnLength);

		// Token: 0x06000243 RID: 579
		[DllImport("ntdll.dll")]
		internal static extern ON8D3pP NtQuerySystemInformation([In] 2hQd SystemInformationClass, [In] IntPtr SystemInformation, [In] int SystemInformationLength, out int ReturnLength);
	}
}
