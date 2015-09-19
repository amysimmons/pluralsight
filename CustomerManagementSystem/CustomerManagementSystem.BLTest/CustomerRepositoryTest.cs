using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using CustomerManagementSystem.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerManagementSystem.BLTest
{
	[TestClass]
	public class CustomerRepositoryTest
	{
		[TestMethod]
		public void RetreiveExisting()
		{
			//Arrange
			var customerRepository = new CustomerRepository();
			var expected = new Customer(1)
			{
				EmailAddress = "xxx",
				FirstName = "xxx",
				LastName = "xxx"
			};

			//Act
			var actual = customerRepository.Retreive(1);

			//Assert
			Assert.AreEqual(expected.CustomerId, actual.CustomerId);
			Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
			Assert.AreEqual(expected.FirstName, actual.FirstName);
			Assert.AreEqual(expected.LastName, actual.LastName);
		}

		[TestMethod]
		public void RetreiveExistingWithAddress()
		{
			//Arrange
			var customerRepository = new CustomerRepository();
			var expected = new Customer(1)
			{
				EmailAddress = "xxx",
				FirstName = "xxx",
				LastName = "xxx",
				AddressList = new List<Address>()
				{
					new Address()
					{
						AddressType = 1,
						StreetLine1 = "xxx",
						StreetLine2 = "xxx",
						City = "xxx",
						StateProvince = "xxx",
						PostCode = "xxx",
						Country = "xxx"
					},
					new Address()
					{
						AddressType = 2,
						StreetLine1 = "xxx",
						StreetLine2 = "xxx",
						City = "xxx",
						StateProvince = "xxx",
						PostCode = "xxx",
						Country = "xxx"
					}
				}
			};

			//Act
			var actual = customerRepository.Retreive(1);

			//Assert
			Assert.AreEqual(expected.CustomerId, actual.CustomerId);
			Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
				//more here

			for (int i = 0; i < 1; i++)
			{
				Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
				Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
					//more here 
			}
		}
	}
}
