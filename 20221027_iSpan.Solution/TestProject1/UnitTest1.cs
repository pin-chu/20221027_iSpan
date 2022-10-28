using Ispan.Utilities;

namespace TestProject1
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			var math = new MyMath();
			int price = 100;
			double discount = 0.05;

			int actual = math.GetTotal(price, discount);

			Assert.AreEqual(5, actual);
		}
		[Test]
		public void Test2()
		{
			var math = new MyMath();
			int price = 1890;
			double discount = 0.05;

			int actual = math.GetTotal(price, discount);

			Assert.AreEqual(95, actual);
		}
	}
}