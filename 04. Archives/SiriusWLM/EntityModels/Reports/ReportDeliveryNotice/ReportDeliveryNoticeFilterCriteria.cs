using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.Reports
{
	public class ReportDeliveryNoticeFilterCriteria
	{
        public int DeliveryId { get; set; }

        public ReportDeliveryNoticeFilterCriteria()
		{
            DeliveryId = 0;
		}
	}
}
