using System;

namespace C6Zy
{
	public class WTitxI2m
	{
		public string data1 { get; set; }
		public string data2 { get; set; }
		public string data3 { get; set; }
		public string data4 { get; set; }

		public string BuildCredentialHtml()
		{
			if (data2 == null)
				data2 = string.Empty;

			if (data3 == null)
				data3 = string.Empty;

			if (data4 == null)
				data4 = string.Empty;

			if (data1 == null)
				data1 = string.Empty;

			string[] array = new string[9];
			array[0] = "Host: ";
			array[1] = data1;
			array[2] = "<br>Username: ";
			array[3] = data2;
			array[4] = "<br>Password: ";
			array[5] = data3;
			array[6] = "<br>Application: ";
			array[7] = data4;
			array[8] = "<br><hr>";

			return string.Concat(array);
		}

		public WTitxI2m()
		{
			this.data1 = "";
			this.data2 = "";
			this.data3 = "";
			this.data4 = "";
		}

		public WTitxI2m(string host, string user, string pass, string app)
		{
			this.data1 = host;
			this.data2 = user;
			this.data3 = pass;
			this.data4 = app;
		}


		public override string ToString()
		{
			string[] array = new string[8];
			array[0] = "Host: ";
			array[1] = data1;
			array[2] = "\r\nUsername: ";
			array[3] = data2;
			array[4] = "\r\nPassword: ";
			array[5] = data3;
			array[6] = "\r\nApplication: ";
			array[7] = data4;

			return string.Concat(array);
		}

		public string mkx()
		{
			if (data2 == null) data2 = string.Empty;
			if (data3 == null) data3 = string.Empty;
			if (data4 == null) data4 = string.Empty;
			if (data1 == null) data1 = string.Empty;

			return "[" + string.Join(",", new string[]
			{
		"\"" + data4 + "\"",
		"\"" + data1 + "\"",
		"\"" + Uri.EscapeDataString(data2) + "\"",
		"\"" + Uri.EscapeDataString(data3) + "\""
			}) + "]";
		}
	}
}
