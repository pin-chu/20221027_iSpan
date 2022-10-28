using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			People p1 = new People();

			Employee e1 = new Employee();

			People p2 = new Employee();
			// 請問p2有哪些屬性 ?  // 2個, 以宣告的型別為準

			var obj3 = new Employee();
					

			// Employee e2 = new People();
		}
	}

	/// <summary>
	/// 人類
	/// </summary>
	public class People
	{
		public bool Gender { get; set; } // 性別
		public string SID { get; set; } // 身分證字號
	}

	public class Employee : People
	{
		public string BadgeNumber { get; set; } // 員工編號
	}
}
