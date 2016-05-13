using Equistat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface ISensorsViewModel : IViewModel
    {
        Machine SelectedMachine { get; set; }
    }
}
