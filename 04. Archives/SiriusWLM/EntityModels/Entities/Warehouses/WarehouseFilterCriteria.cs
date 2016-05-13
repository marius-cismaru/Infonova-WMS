using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.Warehouses
{
	public class WarehouseFilterCriteria
	{
		public string Name { get; set; }
        public int CompanyId { get; set; }

        public WarehouseFilterCriteria()
		{
			Name = string.Empty;
            CompanyId = 0;
		}
	}
}
