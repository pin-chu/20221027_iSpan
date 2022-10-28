using Ispan.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var obj2 = new MyMath();
			obj2.GetTotal(111, 0.8);

			var obj = new MyMath();
			int price = 1890;
			double discount = 0.05;

			int total = obj.GetTotal(price, discount);
			Console.WriteLine(total);
		}
	}
}
