using System;
using CustomerManagementSystem.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerManagementSystem.BLTest
{
	[TestClass]
	public class CustomerTest
	{
		[TestMethod]
		public void FullNameTestValid()
		{
			//arrange
			Customer customer = new Customer();
			customer.FirstName = "Amy";
			customer.LastName = "Simmons";

			string expected = "Simmons, Amy";

			//act
			string actual = customer.FullName;

			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void FullNameFirstNameEmpty()
		{
			//arrange
			Customer customer = new Customer();
			customer.LastName = "Simmons";
			string expected = "Simmons";

			//act
			string actual = customer.FullName;

			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void FullNameLastNameEmpty()
		{
			//arrange
			Customer customer = new Customer();
			customer.FirstName = "Amy";
			string expected = "Amy";

			//act
			string actual = customer.FullName;

			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void StaticTest()
		{
			//arrange
			var c1 = new Customer();
			c1.FirstName = "Bilbo";
			Customer.InstanceCount += 1;

			var c2 = new Customer();
			c2.FirstName = "Frodo";
			Customer.InstanceCount += 1;

			var c3 = new Customer();
			c3.FirstName = "Rosie";
			Customer.InstanceCount += 1;

			//assert
			Assert.AreEqual(Customer.InstanceCount, 3);
		}

		[TestMethod]
		public void ValidateValid()
		{
			//arrange
			var customer = new Customer();
			customer.LastName = "Dylan";
			customer.EmailAddress = "bob@dylan.com";

			var expected = true;

			//act
			var actual = customer.Validate();

			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ValidateInvalid()
		{
			//arrange
			var customer = new Customer();
			customer.LastName = "Dylan";
			customer.EmailAddress = "";

			var expected = false;

			//act
			var actual = customer.Validate();

			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}
