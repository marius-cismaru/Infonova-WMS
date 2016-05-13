using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.Deliveries
{
	public class DeliveryFilterCriteria
	{
        public int CompanyId { get; set; }
        public int ClientId { get; set; }
        public int WarehouseId { get; set; }
        public int Number { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? DateCreationBegin { get; set; }
        public DateTime? DateCreationEnd { get; set; }

        public DeliveryFilterCriteria()
		{
            ClientId = 0;
            CompanyId = 0;
            WarehouseId = 0;
            Number = 0;
            OrderNumber = string.Empty;
            DateCreationBegin = CommonLibs.DatesLib.GetFirstDayOfMonth();
            DateCreationEnd = null;
		}
	}
}
