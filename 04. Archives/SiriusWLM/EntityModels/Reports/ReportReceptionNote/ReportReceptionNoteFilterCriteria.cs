using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.Reports
{
	public class ReportReceptionNoteFilterCriteria
	{
        public int ReceptionId { get; set; }

        public ReportReceptionNoteFilterCriteria()
		{
            ReceptionId = 0;
		}
	}
}
