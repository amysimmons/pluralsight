using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
	public class Customer
	{
		//auto properties
		public int CustomerId { get; private set; }

		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string EmailAddress { get; set; }
		public string EHomeAddress { get; set; }
		public string WorkAddress { get; set; }

		public string FullName
		{
			get { return LastName + ", " + FirstName; }
		}
	}


}


