using System;
using CustomerManagementSystem.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerManagementSystem.BLTest
{
	[TestClass]
	public class AddressRepositoryTest
	{
		[TestMethod]
		public void RetreiveExisting()
		{
			//Arrange
			var addressRepository = new AddressRepository();
			var expected = new Address(1)
			{
				AddressType = 0,
				StreetLine1 = "xxx",
				StreetLine2 = "xxx",
				City = "xxx",
				StateProvince = "xxx",
				PostCode = "xxx",
				Country = "xxx"
			};

			//Act
			var actual = addressRepository.Retreive(1);

			//Assert
			Assert.AreEqual(expected.AddressId, actual.AddressId);
			Assert.AreEqual(expected.StreetLine1, actual.StreetLine1);
		}
	}
}
