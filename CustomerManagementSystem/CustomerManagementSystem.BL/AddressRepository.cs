using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
	public class AddressRepository
	{
		public Address Retreive(int addressId)
		{
			//code that retreives the defined customer 
			Address address = new Address(addressId);

			if (addressId == 1)
			{
				address.StreetLine1 = "xxx";
				address.StreetLine2 = "xxx";
				address.City = "xxx";
				address.StateProvince = "xxx";
				address.PostCode = "xxx";
				address.Country = "xxx";
			}

			return address;
		}

		public IEnumerable<Address> RetreiveByCustomerId(int customerId)
		{
			//returns a list of all addresses for a particular customer
			var addressList = new List<Address>();
			Address address = new Address(1)
			{
				AddressType = 1,
				StreetLine1 = "xxx",
				StreetLine2 = "xxx",
				City = "xxx",
				StateProvince = "xxx",
				PostCode = "xxx",
				Country = "xxx"
			};
			addressList.Add(address);

			address = new Address(2)
			{
				AddressType = 2,
				StreetLine1 = "xxx",
				StreetLine2 = "xxx",
				City = "xxx",
				StateProvince = "xxx",
				PostCode = "xxx",
				Country = "xxx"
			};
			addressList.Add(address);

			return addressList;
		}

		public bool Save(Address address)
		{
			//code that saves the defined customer 
			var success = true;

			if (address.HasChanges && address.IsValid)
			{
				if (address.IsNew)
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
