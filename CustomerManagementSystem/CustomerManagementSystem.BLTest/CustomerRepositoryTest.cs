using System;
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
	}
}
