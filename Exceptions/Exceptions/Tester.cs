using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
	class Tester
	{
		public void Method()
		{
			Console.WriteLine("Method 1 begins");
			Method2();
			Console.WriteLine("Method 1 ends");
		}

		public void Method2()
		{
			Console.WriteLine("Method 2 begins");
			Method3();
			Console.WriteLine("Method 2 ends");
		}

		public void Method3()
		{
			Console.WriteLine("Method 3 begins");
			Console.WriteLine("File opened...");
			try
			{
				var x = 0;
				var y = 12/x;
			}
			catch (Exception e)
			{
				Console.WriteLine("Caught exception {0}", e.Message);
			}
				//a finally block is guaranteed to run even if there is an exception
				//it will also run if there is no exception
			finally
			{
				Console.WriteLine("File closed...");
			}
			Console.WriteLine("Method 3 ends");
		}
	}
}
