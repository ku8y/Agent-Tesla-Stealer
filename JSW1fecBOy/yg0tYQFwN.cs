using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using Microsoft.VisualBasic.Devices;

namespace JSW1fecBOy
{
	public static class yg0tYQFwN
	{
        public static string GetHardwareInfo(yg0tYQFwN.Hardware VtFx)
        {
            ComputerInfo computerInfo = new ComputerInfo();

            switch (VtFx)
            {
                case yg0tYQFwN.Hardware.OS:
                    return computerInfo.OSFullName;

                case yg0tYQFwN.Hardware.CPU:
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        return obj["Name"].ToString();
                    }
                    return ""; 

                case yg0tYQFwN.Hardware.RAM:
                    double totalMemoryMB = Math.Round(computerInfo.TotalPhysicalMemory / 1024.0 / 1024.0, 2);
                    return totalMemoryMB + " MB";

                default:
                    return "";
            }
        }

        public enum Hardware
		{
			OS,
			CPU,
			RAM
		}
	}
}
