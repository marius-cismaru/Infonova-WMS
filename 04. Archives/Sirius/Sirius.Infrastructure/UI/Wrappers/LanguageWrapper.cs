using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.Wrappers
{
    public class LanguageWrapper
    {
        public LanguageWrapper(string language)
        {
            this.Value = language;
            this.DisplayName = CultureInfo.GetCultureInfo(language).DisplayName;
        }

        public string Value { get; set; }
        public string DisplayName { get; set; }
    }
}
