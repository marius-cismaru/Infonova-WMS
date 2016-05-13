using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels
{
    public partial class Product
    {
        public string IdToString
        {
            get
            {
                return Id.ToString("000000");
            }
        }

        public Product()
        {
            ConversionFactorKg = 1;
        }

        public override string ToString()
        {
            return Code + " - " + Name + " [" + MeasuringUnit.ToString() + "]";
        }
    }
}
