using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.Packages
{
	public class PackageFilterCriteria
	{
        public enum OptionsIsExisting
        {
            [Description("- Toate -")]
            All = 0,

            [Description("Da")]
            Yes = 1,

            [Description("Nu")]
            No = 2
        }

        public OptionsIsExisting OptionIsExisting { get; set; }
        public int CompanyId { get; set; }
        public int ClientId { get; set; }
        public int WarehouseId { get; set; }
        public int ProductId { get; set; }
        public string Code { get; set; }
        public string WarehouseContainerName { get; set; }
        public int ReceptionNumber { get; set; }
        public int DeliveryNumber { get; set; }

        public PackageFilterCriteria()
		{
            OptionIsExisting = OptionsIsExisting.Yes;
            CompanyId = 0; 
            ClientId = 0;
            WarehouseId = 0;
            ProductId = 0;
            Code = string.Empty;
            WarehouseContainerName = string.Empty;
            ReceptionNumber = 0;
            DeliveryNumber = 0;
		}
	}
}
