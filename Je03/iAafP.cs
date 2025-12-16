using System;
using System.Text;

namespace Je03
{
	public abstract class iAafP
	{
		public abstract byte[] GetBytes();
		public override string ToString()
		{
			int num = 0;
			StringBuilder stringBuilder;
			do
			{
				if (num == 3)
				{
					stringBuilder.AppendLine();
					num = 4;
				}
				if (num == 2)
				{
					stringBuilder.AppendFormat("{0}:", base.GetType().Name);
					num = 3;
				}
				if (num == 1)
				{
					stringBuilder = new StringBuilder();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
			return stringBuilder.ToString();
		}
	}
}
