using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sirius.EntityModels
{
    public class HelperDeliveryPackage
    {
        public int Package_Id { get; set; }
        public string ProductMU { get; set; }
        public double Quantity { get; set; }
        public double WeightNet { get; set; }
        public double WeightGross { get; set; }
        public double ProductConversionFactorKg { get; set; }
        public string PackageType { get; set; }
        public string Code { get; set; }
        public string Batch { get; set; }
        public int ReceptionNumber { get; set; }
        public DateTime ReceptionDate { get; set; }
        public string WarehouseContainer { get; set; }

        public HelperDeliveryPackage PackageChild { get; set; }

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

        public HelperDeliveryPackage()
        {
            Package_Id = -1;
            ProductConversionFactorKg = 1;
        }

        public override string ToString()
        {
            return (Code + " - " + (ReceptionNumber.ToString() + " / "  + ReceptionDate.ToString("dd.MM.yyyy")) + " - " + QuantityDescription + " " + ProductMU + " - " + WeightNetDescription + " Kg - " + WeightGrossDescription + " Kg - " + WarehouseContainer + (PackageChild != null ? (" - Original: " + (Quantity + PackageChild.Quantity).ToString("0.00", CultureInfo.InvariantCulture) + " " + ProductMU) : string.Empty));
        }
    }
}
