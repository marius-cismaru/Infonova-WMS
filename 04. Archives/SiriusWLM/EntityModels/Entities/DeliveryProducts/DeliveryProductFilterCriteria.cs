using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.DeliveryProducts
{
	public class DeliveryProductFilterCriteria
	{
        public int DeliveryId { get; set; }

        public DeliveryProductFilterCriteria()
		{
            DeliveryId = 0;
		}
	}
}
