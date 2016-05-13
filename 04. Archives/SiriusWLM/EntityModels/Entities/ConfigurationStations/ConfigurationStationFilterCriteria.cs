using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.ConfigurationStations
{
	public class ConfigurationStationFilterCriteria
	{
        public string StationName { get; set; }

        public ConfigurationStationFilterCriteria()
		{
            StationName = string.Empty;
		}
	}
}
