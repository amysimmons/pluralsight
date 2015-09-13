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

	}
}
