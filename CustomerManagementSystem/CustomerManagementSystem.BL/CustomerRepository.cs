using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
	public class CustomerRepository
	{
		//sets up the association with address respository 
		private AddressRepository addressRepository { get; set; }

		public CustomerRepository()
		{
			addressRepository = new AddressRepository();
		}

		public Customer Retreive(int customerId)
		{
			//code that retreives the defined customer 
			Customer customer = new Customer(customerId);
			customer.AddressList = addressRepository.RetreiveByCustomerId(customerId).ToList();

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

		public bool Save(Customer customer)
		{
			//code that saves the defined customer 
			var success = true;

			if (customer.HasChanges && customer.IsValid)
			{
				if (customer.IsNew)
				{
					//call an insert stored procedure
				}
				else
				{
					//call an update stored procedure 
				}
			}
			return success;
		}
	}
}
