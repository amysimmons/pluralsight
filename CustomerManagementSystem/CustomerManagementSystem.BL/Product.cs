using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
	public class Product : EntityBase
	{
		//constructor method 
		public Product()
		{
			
		}

		public Product(int productId)
		{
			this.ProductId = productId;
		}

		public int ProductId { get; private set; }
		public string ProductName { get; set; }
		public string ProductDescription { get; set; }
		public Decimal? CurrentPrice { get; set; }

		public override bool Validate()
		{
			var isValid = true;

			if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
			if (CurrentPrice == null) isValid = false;

			return isValid;
		}
	}
}
