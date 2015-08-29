using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class Item
	{
		public int ID { get; set; }
		public string Name { get; set; }

		public virtual void Purchase()
		{
			Console.WriteLine("Purchasing {0}", Name);
		}

		public static List<Item> GetItems(int numToGet)
		{
			var random = new Random();
			var newList = new List<Item>();
			Item newItem;
			for (int i = 0; i < numToGet; i++)
			{
				newItem = new Item(){ID = random.Next(), Name = "My item" + i.ToString()};
				newList.Add(newItem);
			}

			//var newItem = new Item() {ID = 101, Name = "MyItem"};
			return newList;
		}
	}

	//all software IS A kind of item
	//because we inherit from item, software already has an id a name
	class Software : Item
	{
		public string ISBN { get; set; }

		public override void Purchase()
		{
			Console.WriteLine("My ID is {0} and my ISBN is {1}",
				ID, ISBN);
		}

	}

	class Hardware : Item
	{
		public string SerialNumber { get; set; }
	}

	//computer and peripheral are kinds of hardware, which makes them kinds of items
	class Computer : Hardware
	{
		public string CPUType { get; set; }
		public string Disks { get; set; }
		public override void Purchase()
		{
			base.Purchase();
			Console.WriteLine("my CPUType is {0}", CPUType);
		}
	}

	class Peripheral : Hardware
	{
		string Description { get; set; }
	}

	//NOTE: normally you would create one file per class
}
