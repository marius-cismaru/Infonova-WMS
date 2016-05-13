using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels
{
    public partial class Company
    {
        public string ClientList
        {
            get
            {
                string result = "- Niciunul -";
                if (Clients.Count > 0)
                {
                    result = string.Join(", ", Clients);
                }
                return result;
            }
        }

        public Company()
        {
            Id = 0;
            NameLong = string.Empty;
            NameShort = string.Empty;
            NumberRegistry = string.Empty;
            NumberFiscal = string.Empty;
            CapitalAmount = string.Empty;
            Phone = string.Empty;
            Fax = string.Empty;
            Address = string.Empty;
        }

        public override string ToString()
        {
            return NameShort;
        }
    }
}
