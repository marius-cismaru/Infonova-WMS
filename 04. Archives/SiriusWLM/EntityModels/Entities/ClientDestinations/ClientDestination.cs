using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels
{
    public partial class ClientDestination
    {
        public ClientDestination()
        {
            Name = string.Empty;
            Address = string.Empty;
            Company = string.Empty;
        }

        public string AddressToString()
        {
            return Address + ", " + Country.Name;
        }

        public override string ToString()
        {
            return Name + " (" + Address + ")";
        }
    }
}
