using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
	public class Order
	{
		//constructor 
		public Order()
		{
			
		}

		public Order(int orderId)
		{
			this.OrderId = orderId;
		}

		public int OrderId { get; private set; }
		public DateTimeOffset? OrderDate { get; set; }

		public Order Retreive(int productId)
		{
			return new Order();
		}

		public List<Order> Retreive()
		{
			return new List<Order>();
		}

		public bool Save()
		{
			return true;
		}

		public bool Validate()
		{
			var isValid = true;
			if (OrderDate == null) isValid = false;
			return isValid;
		}
	}
}
