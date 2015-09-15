using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
	class Address
	{

		public Address()
		{
			
		}

		public Address(int addressId)
		{
			this.AddressId = addressId;
		}

		public int AddressId { get; private set; }
		public int AddressType { get; set; }
		public string StreetLine1 { get; set; }
		public string StreetLine2 { get; set; }
		public string City { get; set; }
		public string StateProvince { get; set; }
		public string PostCode { get; set; }
		public string Country { get; set; }

		public bool Validate()
		{
			var isValid = true;

			if (string.IsNullOrWhiteSpace(StreetLine1)) isValid = false;
			if (string.IsNullOrWhiteSpace(City)) isValid = false;
			if (string.IsNullOrWhiteSpace(StateProvince)) isValid = false;
			if (string.IsNullOrWhiteSpace(PostCode)) isValid = false;
			if (string.IsNullOrWhiteSpace(Country)) isValid = false;

			return isValid;
		}
	}
}
