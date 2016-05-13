using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.DeliveryOrderProducts
{
	public class DeliveryOrderProductFilterCriteria
	{
        public int DeliveryId { get; set; }

        public DeliveryOrderProductFilterCriteria()
		{
            DeliveryId = 0;
		}
	}
}
