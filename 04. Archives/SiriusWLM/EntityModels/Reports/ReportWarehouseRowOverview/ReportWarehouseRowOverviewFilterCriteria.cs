using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.Reports
{
	public class ReportWarehouseRowOverviewFilterCriteria
	{
        public int WarehouseRowId { get; set; }

        public ReportWarehouseRowOverviewFilterCriteria()
		{
            WarehouseRowId = 0;
		}
	}
}
