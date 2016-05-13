using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.Transfers
{
	public class TransferFilterCriteria
	{
        public int CompanyId { get; set; }
        public int ClientId { get; set; }
        public int WarehouseId { get; set; }
        public int ProductId { get; set; }
        public string PackageCode { get; set; }
        public string WarehouseContainerNameSource {get;set;}
        public string WarehouseContainerNameDestination {get;set;}
        public DateTime? DateCreationBegin { get; set; }
        public DateTime? DateCreationEnd { get; set; }

        public TransferFilterCriteria()
		{
            CompanyId = 0;
            ClientId = 0;
            WarehouseId = 0;
            ProductId = 0;
            PackageCode = string.Empty;
            WarehouseContainerNameSource = string.Empty;
            WarehouseContainerNameDestination = string.Empty;
            DateCreationBegin = CommonLibs.DatesLib.GetFirstDayOfMonth();
            DateCreationEnd = null;
		}
	}
}
