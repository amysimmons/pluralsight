using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class Warehouse
	{
		public int ID { get; set; }
		public string WarehouseName { get; set; }

		public Warehouse(string Name, int ID)
		{
			WarehouseName = Name;
			//this says assign to the id of this object the id that was passed in
			this.ID = ID;
		}

		public Item FindAndRetunItem(int itemID)
		{
			Item returnItem = new Item() {ID = 101, Name = "Microsoft Office"};
			return returnItem;
		}
	}
}
