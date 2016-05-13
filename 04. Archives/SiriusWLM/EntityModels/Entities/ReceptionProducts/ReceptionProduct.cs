using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels
{
    public partial class ReceptionProduct
    {
        public double QuantityDifference
        {
            get { return QuantityReception - QuantityOrder; }
        }

        public ReceptionProduct()
        {
            Id = 0;
            QuantityOrder = 0;
            QuantityReception = 0;
            Batch = string.Empty;
            IsQualityOK = true;
            Origin = "RO";
            Temperature = 0;
            Observation = string.Empty;
            PackageCount = 0;
        }

        public override string ToString()
        {
            return Product.ToString() + " | " + QuantityOrder.ToString() + " | " + QuantityReception.ToString() + " | " + (QuantityDifference).ToString();
        }
    }
}
