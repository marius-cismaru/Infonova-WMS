using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels
{
    public partial class Transfer
    {
        public Transfer()
        {
            Id = 0;
            DateCreation = DateTime.Now;
        }

        public override string ToString()
        {
            return Package.Code + ": " + WarehouseContainerSource.Name + " -> " + WarehouseContainerDestination.Name + " (" + DateCreation.ToString("dd.MM.yyyy") + ")";
        }
    }
}
