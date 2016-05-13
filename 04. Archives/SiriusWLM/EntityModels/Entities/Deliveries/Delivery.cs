using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels
{
    public partial class Delivery
    {
        public enum OptionsOrderType
        {
            [Description("Email")]
            Email = 1,

            [Description("Comanda")]
            Command = 2,

            [Description("Convorbire")]
            Call = 3
        }

        public OptionsOrderType OptionOrderType
        {
            get { return (OptionsOrderType)OrderType; }
            set { OrderType = (int)value; }
        }

        public string OrderToString
        {
            get
            {
                return CommonLibs.EnumsLib.GetDescription(OptionOrderType) + " " + OrderNumber + " / " + OrderDate.ToString("dd.MM.yyyy");
            }
        }

        public enum OptionsPickMethod
        {
            [Description("Manual")]
            Manual = 1,

            [Description("Automatic FIFO - Data productie")]
            AutoFIFODateProduction = 2
        }

        public OptionsPickMethod OptionPickMethod { get; set; }

        public Delivery()
        {
            Number = 1;
            OptionOrderType = OptionsOrderType.Email;
            OrderNumber = string.Empty;
            OrderDate = DateTime.Now;
            RepresentativeName = string.Empty;
            RepresentativeID = string.Empty;
            Conveyance = string.Empty;
            Seal = string.Empty;
            Comment = string.Empty;
            DateCreation = DateTime.Now;

            OptionPickMethod = OptionsPickMethod.AutoFIFODateProduction;
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
            return Number + " / " + DateCreation.ToString("dd.MM.yyyy");
        }
    }
}
