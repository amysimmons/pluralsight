using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratedConstant
{
	class Program
	{
		enum Color
		{
			Red,
			Orange,
			Green,
			Blue
		}

		static void Main(string[] args)
		{
			Color favorite = Color.Blue;

			switch (favorite)
			{
				case Color.Red:
					Console.WriteLine("You chose red");
					break;
				case Color.Orange:
					Console.WriteLine("You chose orange");
					break;
				case Color.Green:
					Console.WriteLine("You chose green");
					break;
				case Color.Blue:
					Console.WriteLine("You chose blue");
					break;
				default:
					Console.WriteLine("Not a color");
					break;
			}
		}
	}
}
