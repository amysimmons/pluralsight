using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sleep
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter your name");
			string name = Console.ReadLine();

			Console.WriteLine("How many hours of sleep did you get last night?");
			int hoursOfSleep = int.Parse(Console.ReadLine());

			Console.WriteLine("Hello, " + name);

			if (hoursOfSleep < 8)
			{
				Console.WriteLine("You must be tired, " + name);
			}
			else
			{
				Console.WriteLine("You seem well rested, " + name);
			}
		}
	}
}
