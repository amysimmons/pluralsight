using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
	class Program
	{
		static void Main(string[] args)
		{
			//creates an array with 5 items
			var items = new Item[5];
			Random r = new Random();
			for (int i = 0; i < items.Length; i++)
			{
				//assigning a random id to each item
				items[i] = new Item(r.Next());
			}
			Console.WriteLine("Items: ");
			foreach (Item item in items)
			{
				Console.WriteLine("ItemID = {0}", item.ID);
			}

			var myItem = items[1];
			Console.WriteLine("ID of second item = {0}", myItem.ID);

			var Authors = new String[5];
			Authors[0] = "Z";
			Authors[1] = "B";
			Authors[2] = "C";
			Authors[3] = "D";
			Authors[4] = "E";

			Console.WriteLine("Authors...");
			foreach (string s in Authors)
			{
				Console.WriteLine(s);
			}

			System.Array.Sort(Authors);

			Console.WriteLine("Authors...");
			foreach (string s in Authors)
			{
				Console.WriteLine(s);
			}

		}
	}
}
