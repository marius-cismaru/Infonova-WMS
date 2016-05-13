using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.Products
{
	public class ProductFilterCriteria
	{
        public string Code { get; set; }
		public string Name { get; set; }
        public int ClientId { get; set; }
        public int CompanyId { get; set; }

        public ProductFilterCriteria()
		{
            Code = string.Empty;
            Name = string.Empty;
            CompanyId = 0;
            ClientId = 0;
		}
	}
}
