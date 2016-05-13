using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Globalization;

namespace Sirius.EntityModels
{
    public partial class Package
    {
        public Package()
        {
            Id = 0;
            Code = string.Empty;
        }

        public string QuantityDescription
        {
            get { return Quantity.ToString("0.00", CultureInfo.InvariantCulture); }
        }

        public string WeightNetDescription
        {
            get { return WeightNet.ToString("0.00", CultureInfo.InvariantCulture); }
        }

        public string WeightGrossDescription
        {
            get { return WeightGross.ToString("0.00", CultureInfo.InvariantCulture); }
        }

        public override string ToString()
        {
            return Code;
        }

        public string ToStringForPicking()
        {
            return (Code + " - " + (Reception.Number.ToString() + " / " + Reception.DateCreation.ToString("dd.MM.yyyy")) + " - " + QuantityDescription + " " + Product.MeasuringUnit.Name + " - " + WeightNetDescription + " Kg - " + WeightGrossDescription + " Kg - " + WarehouseContainer.CodeToString);
        }
    }
}
