using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equistat.Data;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IMachineDetailsViewModel : IDialogViewModel
    {
        Machine SelectedMachine { get; set; }
        int IndicatorsMinutes { get; set; }
        //Cycle LastCycle { get; set; }
    }
}
