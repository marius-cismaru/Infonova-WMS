using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels
{
    public partial class ClientUser
    {
        public ClientUser()
        {
            DateCreation = DateTime.Now;
            IsActive = true;
            Name = string.Empty;
            Username = string.Empty;
            Password = string.Empty;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
