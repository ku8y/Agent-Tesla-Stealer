using System;
using System.Security.Cryptography;

namespace reJu9lk2r
{
	// Token: 0x02000061 RID: 97
	public class rliYkpvg
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x00007819 File Offset: 0x00005A19
		public rliYkpvg()
		{
			this.qFQNez = Rijndael.Create();
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00027370 File Offset: 0x00025570
		public byte[] T0OOwMTlKN(byte[] hdvjXJ, byte[] Ej75xp, byte[] I4Aj)
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
				this.qFQNez.Key = Ej75xp;
				this.qFQNez.IV = I4Aj;
				this.qFQNez.Mode = CipherMode.CBC;
				this.qFQNez.Padding = PaddingMode.PKCS7;
				result = this.qFQNez.CreateEncryptor().TransformFinalBlock(hdvjXJ, 0, hdvjXJ.Length);
			}
			catch
			{
				throw;
			}
			return result;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00027450 File Offset: 0x00025650
		public byte[] w2fMtP(byte[] VCmlGM, byte[] RkZXn83T8, byte[] 3YCiBnRTBu)
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
				this.qFQNez.Mode = CipherMode.CBC;
				this.qFQNez.Key = RkZXn83T8;
				this.qFQNez.IV = 3YCiBnRTBu;
				this.qFQNez.Padding = PaddingMode.PKCS7;
				result = this.qFQNez.CreateDecryptor().TransformFinalBlock(VCmlGM, 0, VCmlGM.Length);
			}
			catch
			{
				throw;
			}
			return result;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00027530 File Offset: 0x00025730
		public byte[] jBQCTB()
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
			return this.qFQNez.Key;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00027590 File Offset: 0x00025790
		public byte[] Wb81sEYmth()
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
			return this.qFQNez.IV;
		}

		// Token: 0x040000E4 RID: 228
		private Rijndael qFQNez;
	}
}
