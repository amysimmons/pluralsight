using System;
using CustomerManagementSystem.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerManagementSystem.BLTest
{
	[TestClass]
	public class ProductRepositoryTest
	{
		[TestMethod]
		public void RetreiveExisting()
		{
			//Arrange
			var productRepository = new ProductRepository();
			var expected = new Product(2)
			{
				ProductName = "xxx",
				ProductDescription = "xxx",
				CurrentPrice = 15.96M
			};

			//Act
			var actual = productRepository.Retreive(2);

			//Assert
			Assert.AreEqual(expected.ProductId, actual.ProductId);
			Assert.AreEqual(expected.ProductName, actual.ProductName);
			Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
			Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
		}
	}
}
