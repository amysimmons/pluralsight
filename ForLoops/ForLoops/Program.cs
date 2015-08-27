using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			for (int i = 0; i < 10; i++)
			{
				Console.Write("Happy birthday! ");
			}

			Console.WriteLine("\nTaDa!!");

			//++i says increment and then assign
			//i++ says assign and then increment 
			*/

			/*
			int i = 0;
			for (;;)
			{
				++i;
				if (i == 5)
				{
					continue;
				}
				Console.WriteLine("Happy birthday! {0}", i);

				if (i > 10)
				{
					break;
				}
			}
			*/

			for (int i = 0; i < 2000; i++)
			{
				if (i % 100 == 0)
				{
					Console.WriteLine("Happy birthday! {0}", i);
				}
			}

		}

	}
}
