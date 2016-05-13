using Equistat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IUnplannedBreaksOperationViewModel : IDialogViewModel
    {
        BreakType BreakType { get; set; }
        DateTime StartDate { get; set; }
        int SDateHour { get; set; }
        int SDateMinute { get; set; }
        DateTime EndDate { get; set; }
        int EDateHour { get; set; }
        int EDateMinute { get; set; }
        Machine Machine { get; set; }
        DateTime ScanDate { get; set; }
        int ScanDateHour { get; set; }
        int ScanDateMinute { get; set; }

        bool IsNew { set; }
    }
}
