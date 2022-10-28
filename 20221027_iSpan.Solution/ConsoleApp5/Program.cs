using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Employee emp = new Employee { Salary=30000};
			Sales emp2 = new Sales { Bonus=15000, Salary=20000};

			Employee[] employees = new Employee[] { emp, emp2 };
			foreach (Employee employee in employees)
			{
				Console.WriteLine(employee.GetSalary());
			}
			
		}
	}
	public class Employee
	{
		public int Salary { get; set; } // 月薪
		public virtual int GetSalary() // 計算應付月薪
		{
			return Salary;
		}
	}
	public class Sales : Employee
	{
		public int Bonus { get; set; } // 獎金
		public override int GetSalary() // 計算應付月薪
		{
			return Salary + Bonus;
		}
	}

}
