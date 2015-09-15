using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
	public class CustomerRepository
	{
		public Customer Retreive(int customerId)
		{
			//code that retreives the defined customer 
			Customer customer = new Customer(1);

			if (customerId == 1)
			{
				customer.EmailAddress = "xxx";
				customer.FirstName = "xxx";
				customer.LastName = "xxx";
			}

			return customer;
		}

		public List<Customer> Retreive()
		{
			//returns a list of all customers 
			return new List<Customer>();
		}

		public bool Save()
		{
			//code that saves the defined customer 
			return true;
		}
	}
}
