using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
	public class Order : EntityBase
	{
		//constructor 
		public Order()
		{
			
		}

		public Order(int orderId)
		{
			this.OrderId = orderId;
		}

		//when the order repository populates an order, 
		//these properties will be populated 
		public int CustomerId { get; set; }
		public int ShippingAddressId { get; set; }

		public int OrderId { get; private set; }
		public DateTimeOffset? OrderDate { get; set; }
		public List<OrderItem> OrderItems { get; set; }

		public override bool Validate()
		{
			var isValid = true;
			if (OrderDate == null) isValid = false;
			return isValid;
		}

	}
}
