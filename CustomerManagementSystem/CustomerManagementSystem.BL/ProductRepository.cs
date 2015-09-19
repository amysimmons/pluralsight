using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
	public class ProductRepository
	{
		public Product Retreive(int productId)
		{
			//code that retreives the defined customer 
			Product product = new Product(productId);

			if (productId == 2)
			{
				product.ProductName = "xxx";
				product.ProductDescription = "xxx";
				product.CurrentPrice = 15.96M;
			}

			return product;
		}

		public List<Product> Retreive()
		{
			//returns a list of all customers 
			return new List<Product>();
		}

		public bool Save(Product product)
		{
			//code that saves the defined customer 
			var success = true;

			if (product.HasChanges && product.IsValid)
			{
				if (product.IsNew)
				{
					//call an insert stored procedure
				}
				else
				{
					//call an update stored procedure 
				}
			}
			return success;
		}
	}
}
