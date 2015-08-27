using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Pick a number between 1 and 5: ");
			int choice = int.Parse(Console.ReadLine());

			switch (choice)
			{
				case 5:
					Console.WriteLine("You picked the biggest legal value");
					break;
				case 4:
					Console.WriteLine("You chose 4");
					break;
				case 3:
					Console.WriteLine("You chose 3");
					break;
				case 2:
					Console.WriteLine("You chose 2");
					break;
				case 1:
					Console.WriteLine("You chose 1");
					break;
				default:
					Console.WriteLine("Bad Number");
					break;
			}
		}
	}
}
