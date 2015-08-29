using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			var newWarehouse = new Warehouse("Warehouse 1", 101);
			var myItem = newWarehouse.FindAndRetunItem(101);
			Console.WriteLine("my new item is " + myItem.Name);

			var myComputer = new Computer();
			myComputer.ID = 102;

			Item mySecondComputer = new Computer();
			mySecondComputer.ID = 103;
			Computer mySecondComputer2 = mySecondComputer as Computer;
			mySecondComputer2.CPUType = "i7";
			string myCPUType = mySecondComputer2.CPUType;
			mySecondComputer2.Name = "Jupiter";

			mySecondComputer2.Purchase();

			Software mySoftware = new Software();
			mySoftware.Name = "Foo";
			mySoftware.ID = 101;
			mySoftware.ISBN = "1234";
			mySoftware.Purchase();

			Item newItem = Item.GetItem();
			Console.WriteLine("New item ID = {0}, name = {1}", newItem.ID, newItem.Name);
		}
	}
}
