using System;
using System.Runtime.InteropServices;

namespace S5j
{
	// Token: 0x0200007C RID: 124
	public struct zz8ZXGH : IDisposable
	{
		// Token: 0x0600023F RID: 575 RVA: 0x00007A4D File Offset: 0x00005C4D
		public zz8ZXGH(string s)
		{
			this.gx0uEUq3gJ = (ushort)(s.Length * 2);
			this.rPgP5Lx8 = this.gx0uEUq3gJ + 2;
			this.MP8t4Bq8JF9 = Marshal.StringToHGlobalUni(s);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0002DBCC File Offset: 0x0002BDCC
		public void Dispose()
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.MP8t4Bq8JF9 = IntPtr.Zero;
					num = 3;
				}
				if (num == 1)
				{
					Marshal.FreeHGlobal(this.MP8t4Bq8JF9);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0002DC70 File Offset: 0x0002BE70
		public override string ToString()
		{
			int num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
			return Marshal.PtrToStringUni(this.MP8t4Bq8JF9);
		}

		// Token: 0x0400015E RID: 350
		public ushort gx0uEUq3gJ;

		// Token: 0x0400015F RID: 351
		public ushort rPgP5Lx8;

		// Token: 0x04000160 RID: 352
		private IntPtr MP8t4Bq8JF9;
	}
}
