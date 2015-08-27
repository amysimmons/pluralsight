using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanValues
{
	class Program
	{
		static void Main(string[] args)
		{
			bool myFirstBoolean = 3 + 2 == 5;
			Console.WriteLine(myFirstBoolean.ToString());

			bool mySecondBoolean = 3 + 2 > 5;
			Console.WriteLine(mySecondBoolean.ToString());

			bool bothAreTrue = myFirstBoolean && mySecondBoolean; 
			Console.WriteLine("bothAreTrue evaluates " + bothAreTrue);

			bool oneIsTrue = myFirstBoolean || mySecondBoolean;
			Console.WriteLine("oneIsTrue evaluates {0} becayse one expression is true", oneIsTrue);

			bool reverseMyFirstBoolean = !myFirstBoolean;
			Console.WriteLine("My first boolean is {0} but my reversed boolean is {1}", myFirstBoolean, reverseMyFirstBoolean);
		}
	}
}
