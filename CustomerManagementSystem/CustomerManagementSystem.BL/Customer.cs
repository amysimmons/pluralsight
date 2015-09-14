using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
	public class Customer
	{
		//constructor method 
		public Customer()
		{
				
		}

		public Customer(int customerId)
		{
			//any time you're in a class the this keyword is referencing the instance of the class
			this.CustomerId = customerId;
		}

		//auto properties
		public static int InstanceCount { get; set; }
		public int CustomerId { get; private set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string EmailAddress { get; set; }
		public string EHomeAddress { get; set; }
		public string WorkAddress { get; set; }
		public string FullName
		{
			get
			{
				string fullName = LastName;
				if (!string.IsNullOrWhiteSpace(FirstName))
				{
					if (!string.IsNullOrWhiteSpace(fullName))
					{
						fullName += ", ";
					}
					fullName += FirstName;
				}
				return fullName;
			}
		}

		public Customer Retreive(int customerId)
		{
			//code that retreives the defined customer 
			return new Customer();
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

		public bool Validate()
		{
			var isValid = true;

			if(string.IsNullOrWhiteSpace(LastName)) isValid = false;
			if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

			return isValid;
		}
	}
}


