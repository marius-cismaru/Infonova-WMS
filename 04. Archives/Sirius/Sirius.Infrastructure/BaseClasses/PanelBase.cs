using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equistat.Infrastructure.UI;
using WpfExtensions.Util;

namespace Equistat.Infrastructure.BaseClasses
{
    public class PanelBase
    {
        public PanelBase()
        { }

        public IView View { get; set; }
        public string Header { get; set; }
        public DelegateCommand<object> CloseCommand { get; set; }
    }
}
