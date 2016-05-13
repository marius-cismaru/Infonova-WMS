using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.ClientUsers
{
	public class ClientUserFilterCriteria
	{
        public int CompanyId { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }

		public ClientUserFilterCriteria()
		{
            CompanyId = 0;
            ClientId = 0;
            Name = string.Empty;
		}
	}
}
