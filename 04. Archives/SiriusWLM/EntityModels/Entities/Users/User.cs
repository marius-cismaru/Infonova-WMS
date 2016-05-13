using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels
{
    public partial class User
    {
        public User()
        {
            DateCreation = DateTime.Now;
            Name = string.Empty;
            NumberPersonal = string.Empty;
            NumberID = string.Empty;
            DateBirth = new DateTime(2000, 1, 1);
            DateEmployment = null;
            DateResignation = null;
            Username = string.Empty;
            Password = string.Empty;
            BelongsToDomain = false;
            DomainName = string.Empty;
            IsActive = true;
        }

        public string CompanyList
        {
            get
            {
                string result = "- Niciuna -";
                if (Companies.Count > 0)
                {
                    result = string.Join(", ", Companies);
                }
                return result;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
