using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
	//it is legal to implement as many interfaces as you want
	//if i were impementing from a base class it would come before the interface
	//it is not legal to implement from more than one base class
	public class Note : Storable
	{
		public void Write(object obj)
		{
			Console.WriteLine("Writng object to disk...");
		}

		public string Read()
		{
			return "Reading note from disk...";
		}

		private ReturnStatus status;

		public ReturnStatus Status
		{
			get { return status; }
			set { status = value; }
		}

		//the interfact acts as a contract and says you must have these
		//two methods and a property
		//but you can also have other methods

		public void OtherMethod()
		{
			Console.WriteLine("Some other method of Note");
		}

	}
}
