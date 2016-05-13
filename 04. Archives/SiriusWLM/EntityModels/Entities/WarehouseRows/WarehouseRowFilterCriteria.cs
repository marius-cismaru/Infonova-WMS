using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.WarehouseRows
{
	public class WarehouseRowFilterCriteria
	{
        public enum OptionsIsLimited
        {
            [Description("- Toate -")]
            All = 0,

            [Description("Da")]
            Yes = 1,

            [Description("Nu")]
            No = 2
        }

        public int CompanyId { get; set; }
        public int WarehouseId { get; set; }
        public int WarehouseRoomId { get; set; }
        public int Code { get; set; }
        public OptionsIsLimited OptionIsLimited { get; set; }

        public WarehouseRowFilterCriteria()
		{
            CompanyId = 0;
            WarehouseId = 0;
            WarehouseRoomId = 0;
            Code = 0;
            OptionIsLimited = OptionsIsLimited.All;
		}
	}
}
