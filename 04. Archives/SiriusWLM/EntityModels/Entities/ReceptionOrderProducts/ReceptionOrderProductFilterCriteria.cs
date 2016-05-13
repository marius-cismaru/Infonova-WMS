using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.ReceptionOrderProducts
{
	public class ReceptionOrderProductFilterCriteria
	{
        public int ReceptionId { get; set; }

        public ReceptionOrderProductFilterCriteria()
		{
            ReceptionId = 0;
		}
	}
}
