using System;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace JSW1fecBOy
{
	// Token: 0x0200006F RID: 111
	public static class E3VK3NFAO
	{
		// Token: 0x06000200 RID: 512 RVA: 0x0002ACDC File Offset: 0x00028EDC
		public static string GenerateHardwareInfo()
		{
			string text;
			try
			{
				text = E3VK3NFAO.ComputeMd5Hash(MD5.Create(), E3VK3NFAO.GetMachineId() + E3VK3NFAO.GetCpuId() + E3VK3NFAO.GetMacAddress());
				if (text.Contains(" "))
				{
					text = text.Replace(" ", "");
				}
			}
			catch
			{
				text = "None";
			}
			return text;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0002ADB8 File Offset: 0x00028FB8
		private static string GetCpuId()
		{
			string result;
			try
			{
				string text = string.Empty;
				ManagementClass managementClass = new ManagementClass("win32_processor");
				ManagementObjectCollection instances = managementClass.GetInstances();
				foreach (ManagementObject managementObject in instances.Cast<ManagementObject>())
				{
					text = managementObject.Properties["processorID"].Value.ToString();
				}
				result = text;
			}
			catch
			{
				result = "77da0dea-4c41-4480-9d87-96069dd22491";
			}
			return result;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0002AEE4 File Offset: 0x000290E4
		private static string GetMacAddress()
		{
			string result;
			try
			{
				ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
				string text = string.Empty;
				foreach (ManagementBaseObject managementBaseObject in managementClass.GetInstances())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					if (text.Equals(string.Empty))
					{
						if (Convert.ToBoolean(managementObject["IPEnabled"]))
						{
							text = managementObject["MacAddress"].ToString();
						}
						managementObject.Dispose();
					}
					text = text.Replace(":", string.Empty);
				}
				result = text;
			}
			catch
			{
				result = "b71fb856-2747-4d41-8025-d1d028708eeb";
			}
			return result;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0002B054 File Offset: 0x00029254
		private static string GetMachineId()
		{
			string result;
			try
			{
				ManagementClass managementClass = new ManagementClass("Win32_BaseBoard");
				string text = string.Empty;
				foreach (ManagementBaseObject managementBaseObject in managementClass.GetInstances())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					text += managementObject["SerialNumber"].ToString();
				}
				result = text;
			}
			catch
			{
				result = "3d01e57b-ace9-4305-9780-71538c92f267";
			}
			return result;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0002B178 File Offset: 0x00029378
		public static string ComputeMd5Hash(MD5 md5, string input)
		{
			byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < hashBytes.Length; i++)
			{
				if (i % 2 == 0 && i != hashBytes.Length - 1 && i > 0)
				{
					sb.Append("-");
				}

				sb.Append(hashBytes[i].ToString("x2"));
			}

			return sb.ToString().ToUpper();
		}
	}
}
