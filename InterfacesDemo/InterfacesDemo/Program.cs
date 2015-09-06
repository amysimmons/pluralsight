using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var storableObjects = new List<Storable>();
			Note myNote = new Note();
			storableObjects.Add(myNote);
			DBEntry myDbEntry = new DBEntry();
			storableObjects.Add(myDbEntry);
			myDbEntry = new DBEntry();
			storableObjects.Add(myDbEntry);
			myNote = new Note();
			storableObjects.Add(myNote);
			myNote = new Note();
			storableObjects.Add(myNote);

			//for each Storable tpye in storableObjects
			foreach (Storable storable in storableObjects)
			{
				//the note will write it to the disk and the
				//db entry will write it to the database
				//wherever you expect an object you can pass null 
				//instead, indicating that there is no object to be passed 
				storable.Write(null);
				Console.WriteLine(storable.Read());
			}

		}
	}
}
