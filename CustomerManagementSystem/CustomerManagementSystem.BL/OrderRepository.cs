using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
	public class OrderRepository
	{
		public Order Retreive(int orderId)
		{
			//code that retreives the defined customer 
			Order order = new Order(orderId);

			if (orderId == 3)
			{
				order.OrderDate = new DateTimeOffset();
			}

			return order;
		}

		public List<Order> Retreive()
		{
			//returns a list of all customers 
			return new List<Order>();
		}

		public OrderDisplay RetreiveOrderDisplay(int orderId)
		{
			OrderDisplay orderDisplay = new OrderDisplay();

			if (orderId == 10)
			{
				orderDisplay.FirstName = "xxx";
				orderDisplay.LastName = "xxx";
				orderDisplay.OrderDate = new DateTimeOffset();
				orderDisplay.ShippingAddress = new Address()
				{
					AddressType = 1,
					StreetLine1 = "xxx",
					StreetLine2 = "xxx",
					City = "xxx",
					StateProvince = "xxx",
					Country = "xxx",
					PostCode = "xxx"
				};
			}

			orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();

			if (orderId == 10)
			{
				var orderDisplayItem = new OrderDisplayItem()
				{
					ProductName = "xxx",
					PurchasePrice = 15.9M,
					OrderQuantitiy = 1
				};

				orderDisplay.orderDisplayItemList.Add(orderDisplayItem);

				orderDisplayItem = new OrderDisplayItem()
				{
					ProductName = "xxx",
					PurchasePrice = 6M,
					OrderQuantitiy = 1
				};

				orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
			}
			return orderDisplay;
		}

		public bool Save(Order order)
		{
			//code that saves the defined customer 
			return true;
		}
	}
}
