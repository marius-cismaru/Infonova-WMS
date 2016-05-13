using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels
{
    public partial class Label
    {
        public enum OptionsScope
        {
            [Description("Pachet")]
            Package = 1
        }

        public OptionsScope OptionScope
        {
            get
            {
                return (OptionsScope)Scope;
            }
            set
            {
                Scope = (int)value;
            }
        }

        public Label()
        {
            Id = 0;
            OptionScope = OptionsScope.Package;
            IsDefault = false;
            DateCreation = DateTime.Now;
            Description = string.Empty;
            ZPLCode = string.Empty;
        }

        public string ScopeToString
        {
            get
            {
                return CommonLibs.EnumsLib.GetDescription(OptionScope);
            }
        }

        public override string ToString()
        {
            return Description + " / " + DateCreation.ToString("dd.MM.yyyy");
        }
    }
}
