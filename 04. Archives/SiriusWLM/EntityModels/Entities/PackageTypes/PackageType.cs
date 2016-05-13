using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels
{
    public partial class PackageType
    {
        public PackageType()
        {
            Id = 0;
            Name = string.Empty;
            WarehouseContainerOccupancy = 1;
            WeightNetMaxSupported = 2000;
        }

        public override string ToString()
        {
            return Name + " (" + WarehouseContainerOccupancy.ToString() + "C, max. " + WeightNetMaxSupported.ToString() + " Kg)";
        }
    }
}
