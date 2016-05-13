using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.CommonLibs
{
    public class Validation
    {
        public bool IsSuccess { get; set; }
        public string ErrorText { get; set; }

        public Validation()
        {
            IsSuccess = true;
            ErrorText = string.Empty;
        }

        public string ValidateString(TextBox textBoxInput)
        {
            string result = textBoxInput.Text.Trim();

            if (result == string.Empty)
            {
                IsSuccess = false;
                ErrorText += " - " + textBoxInput.Tag.ToString() + ": trebuie sa nu fie vid";
            }

            return result;
        }
    }
}
