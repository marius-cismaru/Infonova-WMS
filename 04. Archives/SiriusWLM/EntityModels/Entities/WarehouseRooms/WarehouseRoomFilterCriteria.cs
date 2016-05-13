using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.WarehouseRooms
{
	public class WarehouseRoomFilterCriteria
	{
        public int CompanyId { get; set; }
        public int WarehouseId { get; set; }
        public int Code { get; set; }

        public WarehouseRoomFilterCriteria()
		{
            CompanyId = 0;
            WarehouseId = 0;
            Code = 0;
		}
	}
}
