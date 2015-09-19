using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

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

		private String _ProductName;

		public String ProductName
		{
			get
			{
				return _ProductName.InsertSpaces();
			}
			set { _ProductName = value; }
		}
		
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
