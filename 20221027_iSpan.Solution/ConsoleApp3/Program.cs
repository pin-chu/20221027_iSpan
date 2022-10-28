using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Member member = new Member("allen");
			Member member2 = new Member();
			Member member3 = new Member("allen", "allen@gmail.com");
			Member member4 = new Member(18, "allen"); // 叫用Member 建構函數
			member4.Create();// 叫用 Create method
		}
	}

	  class Member {
		// 多載(over loading),同名稱,但參數不同
		public Member()// 建構函數, 如果沒寫,會自動生成
		{

		}
		public Member(string name)
		{

		}

		public Member(string name, string email)
		{

		}
		public Member(string name, int age)
		{

		}
		public Member( int age, string name)
		{

		}
		
		public void Create()
		{

		}

		public string Name { get; set; }
		public string Email { get; set; }
	}
}
