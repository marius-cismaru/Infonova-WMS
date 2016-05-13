using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Globalization;

namespace Sirius.EntityModels
{
    public partial class DeliveryOrderProduct
    {
        public DeliveryOrderProduct()
        {
            Id = 0;
            Quantity = 0;
            WeightNet = 0;
        }

        public override string ToString()
        {
            return Product.ToString() + " | " + Quantity.ToString() + " " + Product.MeasuringUnit.Name + " | " + WeightNet.ToString("0.00", CultureInfo.InvariantCulture) + " Kg";
        }
    }
}
