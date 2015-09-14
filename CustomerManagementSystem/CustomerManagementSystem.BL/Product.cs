using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
	public class Product
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

		public Product Retreive(int productId)
		{
			return new Product();
		}

		public List<Product> Retreive()
		{
			return new List<Product>();
		}

		public bool Save()
		{
			return true;
		}

		public bool Validate()
		{
			var isValid = true;
			return isValid;
		}
	}
}
