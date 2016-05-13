using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace WpfExtensions.Validators
{
    public class RangeValidationRule : ValidationRule
    {
        public double StartValue { get; set; }
        public double EndValue { get; set; }
        public string CustomMessage { get; set; }

        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            double result;
            if (value != null && Double.TryParse(value.ToString(), out result))
            {
                if (result >= this.StartValue && result <= this.EndValue)
                {
                    return new ValidationResult(true, null);
                }
                else
                {
                    return new ValidationResult(false, this.CustomMessage);
                }
            }
            else
            {
                return new ValidationResult(false, "Valoarea introdusa nu este numerica");
            }
        }
    }
}
