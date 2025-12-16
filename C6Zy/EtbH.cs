using System;
using System.Collections.Generic;

namespace C6Zy
{
	public interface EtbH
	{
		List<WTitxI2m> Grab();

		string SsJyWlASpp { get; }

		public string Name;

		public EtbH() { }

		public EtbH(string name)
		{
			Name = name;
		}
	}
}
