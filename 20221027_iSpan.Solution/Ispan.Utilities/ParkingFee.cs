using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan.Utilities
{
	public class ParkingFee
	{
		public int CalcFee(int minutes)
		{
			int hours = (int)Math.Ceiling((double)minutes / 60d);
			int fee = hours * 5;

			return Math.Min(fee, 30);
		}
	}
}
