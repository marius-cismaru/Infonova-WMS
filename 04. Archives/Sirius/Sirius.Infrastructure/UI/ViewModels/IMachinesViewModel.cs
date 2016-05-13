using Equistat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IMachinesViewModel : IViewModel
    {
        Machine SelectedMachine { get; set; }
    }
}
