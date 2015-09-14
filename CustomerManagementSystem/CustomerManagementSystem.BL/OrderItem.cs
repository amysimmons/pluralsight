using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
	public class OrderItem
	{
		//constructor 
		public OrderItem()
		{
			
		}

		public OrderItem(int orderItemId)
		{
			this.OrderItemId = orderItemId;
		}

		public int OrderItemId { get; private set; }
		public int ProductId { get; set; }
		public int OrderQuantity { get; set; }
		public decimal? PurchasePrice { get; set; }


		public OrderItem Retreive(int productId)
		{
			return new OrderItem();
		}

		public List<OrderItem> Retreive()
		{
			return new List<OrderItem>();
		}

		public bool Save()
		{
			return true;
		}

		public bool Validate()
		{
			var isValid = true;

			if (ProductId <= 0) isValid = false;
			if (OrderQuantity <= 0) isValid = false;
			if (PurchasePrice == null) isValid = false;

			return isValid;
		}
	}
}
