using Ispan.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
	internal class ParkingFeeTests
	{
		[Test]
		public void CalcFee_一小時_傳回5元() {
			var obj = new ParkingFee();
			int minutes = 60;
			int expected = 5; // 預期五元

			int actual = obj.CalcFee(minutes);

			Assert.AreEqual(expected, actual);
		}

		[TestCase(59, 5)]
		[TestCase(61, 10)]
		public void CalcFee_不足一小時要無條件進位(int minutes, int expected)
		{
			var obj = new ParkingFee();
			
			int actual = obj.CalcFee(minutes);

			Assert.AreEqual(expected, actual);
		}

		[TestCase(360)]
		[TestCase(361)]
		public void CalcFee_每天最多收30元(int minutes)
		{
			int expected = 30;
			var obj = new ParkingFee();

			int actual = obj.CalcFee(minutes);

			Assert.AreEqual(expected, actual);
		}
	}
}
