using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.ReceptionProducts
{
	public class ReceptionProductFilterCriteria
	{
        public int ReceptionId { get; set; }

        public ReceptionProductFilterCriteria()
		{
            ReceptionId = 0;
		}
	}
}
