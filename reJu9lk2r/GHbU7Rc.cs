using System;
using System.Security.Cryptography;
using System.Text;

namespace reJu9lk2r
{
	// Token: 0x0200005A RID: 90
	public static class GHbU7Rc
	{
		// Token: 0x060001A5 RID: 421 RVA: 0x000245FC File Offset: 0x000227FC
		public static string ZDzD1h(byte[] gtG1MQ0fcLM, DataProtectionScope jvEdAa = DataProtectionScope.CurrentUser)
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
			string result;
			try
			{
				result = Encoding.UTF8.GetString(ProtectedData.Unprotect(gtG1MQ0fcLM, null, jvEdAa));
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00024698 File Offset: 0x00022898
		public static byte[] Izg99u(byte[] xne4, DataProtectionScope fUq = DataProtectionScope.CurrentUser)
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
			byte[] result;
			try
			{
				result = ProtectedData.Unprotect(xne4, null, fUq);
			}
			catch
			{
				result = null;
			}
			return result;
		}
	}
}
