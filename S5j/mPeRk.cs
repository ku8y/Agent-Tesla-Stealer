using System;
using System.Runtime.InteropServices;
using System.Text;

namespace S5j
{
	// Token: 0x02000088 RID: 136
	public static class mPeRk
	{
		// Token: 0x06000244 RID: 580
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool CloseHandle(IntPtr hObject);

		// Token: 0x06000245 RID: 581
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr OpenProcess(37AayiVwbE processAccess, bool bInheritHandle, uint processId);

		// Token: 0x06000246 RID: 582
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr GetCurrentProcess();

		// Token: 0x06000247 RID: 583
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DuplicateHandle(IntPtr hSourceProcessHandle, IntPtr hSourceHandle, IntPtr hTargetProcessHandle, out IntPtr lpTargetHandle, uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, tDRvYQBcmK options);

		// Token: 0x06000248 RID: 584
		[DllImport("kernel32.dll")]
		public static extern uint QueryDosDevice(string lpDeviceName, StringBuilder lpTargetPath, uint ucchMax);

		// Token: 0x06000249 RID: 585
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CreateFileMapping(IntPtr hFile, IntPtr lpFileMappingAttributes, pgwITr flProtect, uint dwMaximumSizeHigh, uint dwMaximumSizeLow, [MarshalAs(UnmanagedType.LPStr)] string lpName);

		// Token: 0x0600024A RID: 586
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr MapViewOfFile(IntPtr hFileMappingObject, GPq dwDesiredAccess, uint dwFileOffsetHigh, uint dwFileOffsetLow, uint dwNumberOfBytesToMap);

		// Token: 0x0600024B RID: 587
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool UnmapViewOfFile(IntPtr lpBaseAddress);

		// Token: 0x0600024C RID: 588
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CreateFile(string FileName, uint DesiredAccess, uint ShareMode, IntPtr SecurityAttributes, uint CreationDisposition, uint FlagsAndAttributes, IntPtr hTemplateFile);

		// Token: 0x0600024D RID: 589
		[DllImport("kernel32.dll", BestFitMapping = true, CharSet = CharSet.Ansi)]
		public static extern bool WriteFile(IntPtr hFile, IntPtr buffer, uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, IntPtr lpOverlapped);

		// Token: 0x0600024E RID: 590
		[DllImport("kernel32.dll")]
		public static extern bool GetFileSizeEx(IntPtr hFile, out long lpFileSize);

		// Token: 0x0600024F RID: 591
		[DllImport("kernel32.dll")]
		public static extern y0EBGg GetFileType(IntPtr hFile);

		// Token: 0x06000250 RID: 592
		[DllImport("kernel32.dll")]
		public static extern uint GetLastError();
	}
}
