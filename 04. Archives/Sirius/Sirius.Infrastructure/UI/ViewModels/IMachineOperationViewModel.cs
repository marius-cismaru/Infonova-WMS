using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equistat.Data;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IMachineOperationViewModel : IDialogViewModel
    {
        bool IsNew { set; }
        bool CanEdit { set; }

        MachineType MachineType { get; set; }
        string Description { get; set; }
        int Row { get; set; }
        int Column { get; set; }
        int BrokenMoldPieces { get; set; }
    }
}
