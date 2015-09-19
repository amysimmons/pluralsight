using System;
using CustomerManagementSystem.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerManagementSystem.BLTest
{
	[TestClass]
	public class OrderRepositoryTest
	{
		[TestMethod]
		public void RetreiveExisting()
		{
			//Arrange
			var orderRepository = new OrderRepository();
			var expected = new Order(3)
			{
				OrderDate = new DateTimeOffset()
			};

			//Act
			var actual = orderRepository.Retreive(3);

			//Assert
			Assert.AreEqual(expected.OrderId, actual.OrderId);
			Assert.AreEqual(expected.OrderDate, actual.OrderDate);
		}

		[TestMethod]
		public void RetrieveOrderDisplayTest()
		{
			//arrange
			//var orderRepository = new OrderRepository();

		}
	}
}
