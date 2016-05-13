using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.ClientDestinations
{
	public class ClientDestinationFilterCriteria
	{
		public string Name { get; set; }
        public int CompanyId { get; set; }
        public int ClientId { get; set; }

		public ClientDestinationFilterCriteria()
		{
			Name = string.Empty;
            CompanyId = 0;
            ClientId = 0;
		}
	}
}
