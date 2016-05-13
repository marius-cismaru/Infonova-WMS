using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfExtensions.Util;

namespace Equistat.Infrastructure.UI.Wrappers
{
    public class WizardOption// : ObservableObject
    {
        public WizardOption()
        {
        }

        public WizardOption(object value, string header, int increment = 1)
        {
            this.Value = value;
            this.Header = header;
            this.Increment = increment;
        }

        public bool IsSelected { get; set; }
        public string Header { get; set; }
        public object Value { get; set; }
        public IList<object> Data { get; set; }
        public int Increment { get; set; }
    }
}