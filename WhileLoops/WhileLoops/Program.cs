using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("How old are you? ");
			int age = Int32.Parse(Console.ReadLine());

			while (age > 0)
			{
				Console.WriteLine("Happy Birthday ");
				age--;
			}

			//a do while loop is guaranteed to run at least once
			//thats the difference between a do while and a while loop
		}
	}
}
