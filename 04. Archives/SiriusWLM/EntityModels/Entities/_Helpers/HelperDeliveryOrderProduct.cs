using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Sirius.EntityModels
{
    public class HelperDeliveryOrderProduct
    {
        public int Product_Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductMU { get; set; }
        public double Quantity { get; set; }
        public double WeightNet { get; set; }

        public List<HelperDeliveryPackage> Packages { get; set; }

        public string QuantityDescription
        {
            get { return Quantity.ToString("0.00", CultureInfo.InvariantCulture); }
        }

        public double QuantityPicked
        {
            get { return Packages.Sum(o => o.Quantity); }
        }

        public string QuantityPickedDescription
        {
            get { return QuantityPicked.ToString("0.00", CultureInfo.InvariantCulture); }
        }

        public double QuantityDifference
        {
            get { return (Packages.Sum(o => o.Quantity) - Quantity); }
        }

        public string QuantityDifferenceDescription
        {
            get { return QuantityDifference.ToString("0.00", CultureInfo.InvariantCulture); }
        }

        public string WeightNetDescription
        {
            get { return WeightNet.ToString("0.00", CultureInfo.InvariantCulture); }
        }

        public HelperDeliveryOrderProduct()
        {
            Product_Id = 0;
            Quantity = 0;
            WeightNet = 0;

            Packages = new List<HelperDeliveryPackage>();
        }

        public override string ToString()
        {
            return (ProductName + " (" + ProductCode + ") - Cantitate: " + QuantityDescription + " " + ProductMU);
        }

        public string ToStringForPicking()
        {
            return (ProductName + " (" + ProductCode + ") [" + ProductMU + "] - Comanda: " + QuantityDescription + " - Picking: " + QuantityPickedDescription + " - Diferenta: " + QuantityDifferenceDescription + " - Pachete: " + Packages.Count.ToString());
        }
    }
}
