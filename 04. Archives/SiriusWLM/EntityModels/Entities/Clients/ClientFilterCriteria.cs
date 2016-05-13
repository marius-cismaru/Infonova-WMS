using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.Clients
{
	public class ClientFilterCriteria
	{
		public string Name { get; set; }

        public int CompanyId { get; set; }
        public int ClientId { get; set; }

		public ClientFilterCriteria()
		{
			Name = string.Empty;
            CompanyId = 0;
            ClientId = 0;
		}
	}
}
