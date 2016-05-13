using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.IO.Ports;

namespace Sirius.EntityModels
{
    public partial class ConfigurationVersion
    {
        public ConfigurationVersion()
        {
            Major = 0;
            Minor = 0;
        }

        public override string ToString()
        {
            return (Major + "." + Minor);
        }
    }
}
