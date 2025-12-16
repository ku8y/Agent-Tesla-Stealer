using System;
using System.Web.Script.Serialization;

namespace rCOGWW
{
	// Token: 0x02000052 RID: 82
	public class y5l84
	{
		// Token: 0x06000183 RID: 387 RVA: 0x0001FFF8 File Offset: 0x0001E1F8
		public string njGJT6W<T>(T h9S73bacA8)
		{
			int num = 0;
			JavaScriptSerializer javaScriptSerializer;
			do
			{
				if (num == 1)
				{
					javaScriptSerializer = new JavaScriptSerializer();
					num = 2;
				}
				if (num == 2)
				{
					javaScriptSerializer.MaxJsonLength = int.MaxValue;
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			return javaScriptSerializer.Serialize(h9S73bacA8);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000200A8 File Offset: 0x0001E2A8
		public T ehXXPvnprk<T>(string MdaqjYbwu)
		{
			int num = 0;
			JavaScriptSerializer javaScriptSerializer;
			do
			{
				if (num == 2)
				{
					javaScriptSerializer.MaxJsonLength = int.MaxValue;
					num = 3;
				}
				if (num == 1)
				{
					javaScriptSerializer = new JavaScriptSerializer();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			return javaScriptSerializer.Deserialize<T>(MdaqjYbwu);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00020154 File Offset: 0x0001E354
		public object N6aXRAbcR(string Gab97PM0, Type pRoQ0w)
		{
			int num = 0;
			JavaScriptSerializer javaScriptSerializer;
			do
			{
				if (num == 2)
				{
					javaScriptSerializer.MaxJsonLength = int.MaxValue;
					num = 3;
				}
				if (num == 1)
				{
					javaScriptSerializer = new JavaScriptSerializer();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			return javaScriptSerializer.Deserialize(Gab97PM0, pRoQ0w);
		}
	}
}
