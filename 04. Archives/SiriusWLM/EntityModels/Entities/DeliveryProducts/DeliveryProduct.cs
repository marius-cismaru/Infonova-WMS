using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels
{
    public partial class DeliveryProduct
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public double QuantityOrder { get; set; }
        public double QuantityDelivery { get; set; }
        public double QuantityDifference { get { return QuantityOrder - QuantityDelivery; } }
        public int PackageCount { get; set; }

        public DeliveryProduct()
        {
            Id = 0;
            Product = null;
            QuantityOrder = 0;
            QuantityDelivery = 0;
            PackageCount = 0;
        }

        public override string ToString()
        {
            return (Product != null ? Product.ToString() : "-") + " | " + QuantityOrder.ToString() + " | " + QuantityDelivery.ToString() + " | " + QuantityDifference.ToString();
        }
    }
}
