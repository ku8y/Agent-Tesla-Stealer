using System;
using System.Runtime.InteropServices;

namespace PK42
{
	// Token: 0x02000064 RID: 100
	public static class IEF
	{
		// Token: 0x060001E2 RID: 482
		[DllImport("bcrypt.dll")]
		public static extern uint BCryptOpenAlgorithmProvider(out IntPtr phAlgorithm, [MarshalAs(UnmanagedType.LPWStr)] string pszAlgId, [MarshalAs(UnmanagedType.LPWStr)] string pszImplementation, uint dwFlags);

		// Token: 0x060001E3 RID: 483
		[DllImport("bcrypt.dll")]
		public static extern uint BCryptCloseAlgorithmProvider(IntPtr hAlgorithm, uint flags);

		// Token: 0x060001E4 RID: 484
		[DllImport("bcrypt.dll")]
		public static extern uint BCryptGetProperty(IntPtr hObject, [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, byte[] pbOutput, int cbOutput, ref int pcbResult, uint flags);

		// Token: 0x060001E5 RID: 485
		[DllImport("bcrypt.dll", EntryPoint = "BCryptSetProperty")]
		internal static extern uint BCryptSetAlgorithmProperty(IntPtr hObject, [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, byte[] pbInput, int cbInput, int dwFlags);

		// Token: 0x060001E6 RID: 486
		[DllImport("bcrypt.dll")]
		public static extern uint BCryptImportKey(IntPtr hAlgorithm, IntPtr hImportKey, [MarshalAs(UnmanagedType.LPWStr)] string pszBlobType, out IntPtr phKey, IntPtr pbKeyObject, int cbKeyObject, byte[] pbInput, int cbInput, uint dwFlags);

		// Token: 0x060001E7 RID: 487
		[DllImport("bcrypt.dll")]
		public static extern uint BCryptDestroyKey(IntPtr hKey);

		// Token: 0x060001E8 RID: 488
		[DllImport("bcrypt.dll")]
		public static extern uint BCryptEncrypt(IntPtr hKey, byte[] pbInput, int cbInput, ref IEF.TDsnUlQTh pPaddingInfo, byte[] pbIV, int cbIV, byte[] pbOutput, int cbOutput, ref int pcbResult, uint dwFlags);

		// Token: 0x060001E9 RID: 489
		[DllImport("bcrypt.dll")]
		internal static extern uint BCryptDecrypt(IntPtr hKey, byte[] pbInput, int cbInput, ref IEF.TDsnUlQTh pPaddingInfo, byte[] pbIV, int cbIV, byte[] pbOutput, int cbOutput, ref int pcbResult, int dwFlags);

		// Token: 0x060001EA RID: 490
		[DllImport("Advapi32")]
		public static extern bool IsTextUnicode(byte[] buf, int len, ref IEF.7nl opt);

		// Token: 0x040000EB RID: 235
		public const uint VjuZx5ry7 = 0U;

		// Token: 0x040000EC RID: 236
		public const uint 8ytkYjqAR = 8U;

		// Token: 0x040000ED RID: 237
		public const uint Ih616ULxQ7 = 4U;

		// Token: 0x040000EE RID: 238
		public static readonly byte[] eXA0VImi5 = BitConverter.GetBytes(1296188491);

		// Token: 0x040000EF RID: 239
		public static readonly string 19BPk1xR = "ObjectLength";

		// Token: 0x040000F0 RID: 240
		public static readonly string kMN9gxn = "ChainingModeGCM";

		// Token: 0x040000F1 RID: 241
		public static readonly string dcu4h9Bdas = "AuthTagLength";

		// Token: 0x040000F2 RID: 242
		public static readonly string DbDbVKRi5 = "ChainingMode";

		// Token: 0x040000F3 RID: 243
		public static readonly string VdYfvXgR = "KeyDataBlob";

		// Token: 0x040000F4 RID: 244
		public static readonly string eDsPIG = "AES";

		// Token: 0x040000F5 RID: 245
		public static readonly string uT99 = "Microsoft Primitive Provider";

		// Token: 0x040000F6 RID: 246
		public static readonly int KIDOEgu1y = 1;

		// Token: 0x040000F7 RID: 247
		public static readonly int OrQH9 = 1;

		// Token: 0x040000F8 RID: 248
		public static readonly uint YwmfMC = 3221266434U;

		// Token: 0x02000065 RID: 101
		public struct mVN9THzzB
		{
			// Token: 0x060001EC RID: 492 RVA: 0x000078C7 File Offset: 0x00005AC7
			public mVN9THzzB(string pszAlgId, int cbSalt)
			{
				this.qVM5V = pszAlgId;
				this.a7j5 = cbSalt;
			}

			// Token: 0x040000F9 RID: 249
			[MarshalAs(UnmanagedType.LPWStr)]
			public string qVM5V;

			// Token: 0x040000FA RID: 250
			public int a7j5;
		}

		// Token: 0x02000066 RID: 102
		public struct TDsnUlQTh : IDisposable
		{
			// Token: 0x060001ED RID: 493 RVA: 0x00029714 File Offset: 0x00027914
			public TDsnUlQTh(byte[] iv, byte[] aad, byte[] tag)
			{
				this = default(IEF.TDsnUlQTh);
				this.LUURq0vZkO = IEF.OrQH9;
				this.kU0U1 = Marshal.SizeOf(typeof(IEF.TDsnUlQTh));
				if (iv != null)
				{
					this.4W22 = iv.Length;
					this.A8AGyVhWej = Marshal.AllocHGlobal(this.4W22);
					Marshal.Copy(iv, 0, this.A8AGyVhWej, this.4W22);
				}
				if (aad != null)
				{
					this.BHFwtwc9 = aad.Length;
					this.YqYRpwb6 = Marshal.AllocHGlobal(this.BHFwtwc9);
					Marshal.Copy(aad, 0, this.YqYRpwb6, this.BHFwtwc9);
				}
				if (tag != null)
				{
					this.Z7Y = tag.Length;
					this.UN4PWEaMbQ = Marshal.AllocHGlobal(this.Z7Y);
					Marshal.Copy(tag, 0, this.UN4PWEaMbQ, this.Z7Y);
					this.Nbkuwq5fio = tag.Length;
					this.OWtL6JOhEb = Marshal.AllocHGlobal(this.Nbkuwq5fio);
				}
			}

			// Token: 0x060001EE RID: 494 RVA: 0x000297F4 File Offset: 0x000279F4
			public void Dispose()
			{
				if (this.A8AGyVhWej != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(this.A8AGyVhWej);
				}
				if (this.UN4PWEaMbQ != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(this.UN4PWEaMbQ);
				}
				if (this.YqYRpwb6 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(this.YqYRpwb6);
				}
				if (this.OWtL6JOhEb != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(this.OWtL6JOhEb);
				}
			}

			// Token: 0x040000FB RID: 251
			public int kU0U1;

			// Token: 0x040000FC RID: 252
			public int LUURq0vZkO;

			// Token: 0x040000FD RID: 253
			public IntPtr A8AGyVhWej;

			// Token: 0x040000FE RID: 254
			public int 4W22;

			// Token: 0x040000FF RID: 255
			public IntPtr YqYRpwb6;

			// Token: 0x04000100 RID: 256
			public int BHFwtwc9;

			// Token: 0x04000101 RID: 257
			public IntPtr UN4PWEaMbQ;

			// Token: 0x04000102 RID: 258
			public int Z7Y;

			// Token: 0x04000103 RID: 259
			public IntPtr OWtL6JOhEb;

			// Token: 0x04000104 RID: 260
			public int Nbkuwq5fio;

			// Token: 0x04000105 RID: 261
			public int JTU1cUL2P;

			// Token: 0x04000106 RID: 262
			public long tQh;

			// Token: 0x04000107 RID: 263
			public int pxOxzRP;
		}

		// Token: 0x02000067 RID: 103
		public struct 7OEHM
		{
			// Token: 0x04000108 RID: 264
			public int DQCrGq;

			// Token: 0x04000109 RID: 265
			public int xj08lrdXdc;

			// Token: 0x0400010A RID: 266
			public int KhNZ1Fq3WL;
		}

		// Token: 0x02000068 RID: 104
		public struct lkJ
		{
			// Token: 0x060001EF RID: 495 RVA: 0x000078D7 File Offset: 0x00005AD7
			public lkJ(string alg)
			{
				this.qVM5V = alg;
				this.sdKC = IntPtr.Zero;
				this.tZ3xb7 = 0;
			}

			// Token: 0x0400010B RID: 267
			[MarshalAs(UnmanagedType.LPWStr)]
			public string qVM5V;

			// Token: 0x0400010C RID: 268
			public IntPtr sdKC;

			// Token: 0x0400010D RID: 269
			public int tZ3xb7;
		}

		// Token: 0x02000069 RID: 105
		public enum f4t8Y
		{
			// Token: 0x0400010F RID: 271
			Wud31nrfwl = 1,
			// Token: 0x04000110 RID: 272
			G9JoZ7AMUom,
			// Token: 0x04000111 RID: 273
			WxiTu7joYM,
			// Token: 0x04000112 RID: 274
			1pXLzQoqY = 5,
			// Token: 0x04000113 RID: 275
			kECO,
			// Token: 0x04000114 RID: 276
			A6x,
			// Token: 0x04000115 RID: 277
			nMt3H = 1007
		}

		// Token: 0x0200006A RID: 106
		[Flags]
		public enum 7nl
		{
			// Token: 0x04000117 RID: 279
			ST7 = 1,
			// Token: 0x04000118 RID: 280
			M7f3TS8 = 16,
			// Token: 0x04000119 RID: 281
			vK5 = 2,
			// Token: 0x0400011A RID: 282
			8NtwtfFp7 = 32,
			// Token: 0x0400011B RID: 283
			1JjdHwQF = 4,
			// Token: 0x0400011C RID: 284
			7rIMJEK = 64,
			// Token: 0x0400011D RID: 285
			5G8LmT7Og = 8,
			// Token: 0x0400011E RID: 286
			VWwN = 128,
			// Token: 0x0400011F RID: 287
			kjGVU = 256,
			// Token: 0x04000120 RID: 288
			LMvpn88zBj = 512,
			// Token: 0x04000121 RID: 289
			iwKi8cP0l = 1024,
			// Token: 0x04000122 RID: 290
			lm5tu = 4096,
			// Token: 0x04000123 RID: 291
			YimDt04u4 = 15,
			// Token: 0x04000124 RID: 292
			f8U9 = 240,
			// Token: 0x04000125 RID: 293
			fknyAD = 3840,
			// Token: 0x04000126 RID: 294
			lH1ftkjj0 = 61440
		}
	}
}
