using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.Companies
{
	public class CompanyFilterCriteria
	{
		public string FilterName { get; set; }

        public int RestrictionAssignUserId { get; set; }

        public int RestrictionNotAssignUserId { get; set; }

		public CompanyFilterCriteria()
		{
			FilterName = string.Empty;
            RestrictionAssignUserId = 0;
            RestrictionNotAssignUserId = 0;
		}
	}
}
