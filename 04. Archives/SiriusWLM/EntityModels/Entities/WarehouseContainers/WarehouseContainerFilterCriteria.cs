using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.WarehouseContainers
{
	public class WarehouseContainerFilterCriteria
	{
        public enum OptionsIsAvailable
        {
            [Description("- Toate -")]
            All = 0,

            [Description("Da")]
            Yes = 1,

            [Description("Nu")]
            No = 2
        }

        public enum OptionsIsLimited
        {
            [Description("- Toate -")]
            All = 0,

            [Description("Da")]
            Yes = 1,

            [Description("Nu")]
            No = 2
        }

		public string Name { get; set; }
        public int Room { get; set; }
        public int Row { get; set; }
        public int Interval { get; set; }
        public int Slot { get; set; }
        public int Floor { get; set; }
        public OptionsIsAvailable OptionIsAvailable { get; set; }
        public OptionsIsLimited OptionIsLimited { get; set; }
        public int CompanyId { get; set; }
        public int WarehouseId { get; set; }

        public WarehouseContainerFilterCriteria()
		{
            Name = string.Empty;
            Room = 0;
            Row = 0;
            Interval = 0;
            Slot = 0;
            Floor = 0;
            OptionIsAvailable = OptionsIsAvailable.All;
            OptionIsLimited = OptionsIsLimited.All;
            CompanyId = 0;
            WarehouseId = 0;
		}
	}
}
