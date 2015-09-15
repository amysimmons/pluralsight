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

		public bool Save()
		{
			//code that saves the defined customer 
			return true;
		}
	}
}
