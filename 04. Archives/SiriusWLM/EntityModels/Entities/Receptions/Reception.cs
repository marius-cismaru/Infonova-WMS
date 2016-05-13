using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels
{
    public partial class Reception
    {
        public enum OptionsOrderType
        {
            [Description("Aviz")]
            Notice = 1,

            [Description("Factura")]
            Invoice = 2,

            [Description("Comanda")]
            Command = 3,

            [Description("Convorbire")]
            Call = 4,

            [Description("Email")]
            Email = 5
        }

        public OptionsOrderType OptionOrderType
        {
            get
            {
                return (OptionsOrderType)OrderType;
            }
            set
            {
                OrderType = (int)value;
            }
        }

        public string OrderToString
        {
            get
            {
                return CommonLibs.EnumsLib.GetDescription(OptionOrderType) + " " + OrderNumber + " / " + OrderDate.ToString("dd.MM.yyyy");
            }
        }

        public Reception()
        {
            Number = 1;
            OptionOrderType = OptionsOrderType.Notice;
            OrderNumber = string.Empty;
            OrderDate = DateTime.Now;
            RepresentativeName = string.Empty;
            RepresentativeID = string.Empty;
            Conveyance = string.Empty;
            BatchList = string.Empty;
            Comment = string.Empty;
            DateCreation = DateTime.Now;
        }

        public string IdToString
        {
            get
            {
                return Id.ToString("000000");
            }
        }

        public override string ToString()
        {
            return Client.NameSymbol1 + Number + " / " + DateCreation.ToString("dd.MM.yyyy");
        }
    }
}
