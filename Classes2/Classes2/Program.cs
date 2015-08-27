using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
	class Employee
	{
		public int Age { get; set; }
		public string Name { get; set; }
		public double Salary { get; set; }
		public DateTime StartingDate { get; set; }
		public string PhoneNumber { get; set; }

		//this is a standard method of the class
		public void Bonus(double bonusPercent)
		{
			Salary += Salary*bonusPercent;
		}

		//this is a construtor method
		public Employee(int age, string name, double salary, DateTime startingDate)
		{
			Age = age;
			Name = name;
			Salary = salary;
			StartingDate = startingDate;
		}

		//this means we can still construct an employee with no parameters 
		//as required by the constructor method
		public Employee()
		{
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			//there are three ways to get data into a new employee instance

			//1. assign the data 
			Employee Dave = new Employee();
			Dave.Age = 35;
			Console.WriteLine("Dave's age is {0}", Dave.Age);

			//2. initialize any or all of the properties 
			Employee Amy = new Employee()
			{
				Age = 22,
				Name = "Amy Simmons",
				Salary = 200000,
				StartingDate = new DateTime(2015, 7, 20),
				PhoneNumber = "made up phone no"
			};
			Console.WriteLine("Amy's age is {0}, she started on {1}, her salary is {2}", 
				Amy.Age, Amy.StartingDate, Amy.Salary);

			//3a. use a standard method 
			Employee Tom = new Employee()
			{
				Age = 50,
				Name = "Tom",
				Salary = 100,
				StartingDate = new DateTime(2015, 7, 20),
				PhoneNumber = "made up phone no"
			};
			Console.WriteLine("Tom's age is {0}, he started on {1}, his salary is {2}",
				Tom.Age, Tom.StartingDate, Tom.Salary);
			Tom.Bonus(0.05);
			Console.WriteLine("Tom's age is {0}, he started on {1}, his salary is {2}",
				Tom.Age, Tom.StartingDate, Tom.Salary);

			//3b. use a constructor method
			Employee Mary = new Employee(25, "Mary Jones", 60000, new DateTime(2015, 7, 26));
			Console.WriteLine("Mary's age is {0}, her name is {1}, her salary is {2}, she started on {3}",
				Mary.Age, Mary.Name, Mary.Salary, Mary.StartingDate);
		}
	}
}
