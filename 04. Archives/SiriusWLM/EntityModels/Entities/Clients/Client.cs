using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels
{
    public partial class Client
    {
        public Client()
        {
            Id = 0;
            DateCreation = DateTime.Now;
            NameLong = string.Empty;
            NameShort = string.Empty;
            NameSymbol3 = string.Empty;
            NameSymbol1 = string.Empty;
            IsActive = true;
        }

        public override string ToString()
        {
            return NameShort;
        }
    }
}
