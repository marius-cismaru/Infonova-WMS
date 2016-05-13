using Equistat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IBreakPlanOperationViewModel : IDialogViewModel
    {
        BreakType BreakType { get; set; }
        bool IsPlanned { get; set; }
        User User { get; set; }
        bool IsOEEAffected { get; set; }
        bool IsGlobalBreak { get; set; }
        Machine Machine { get; set; }
        DateTime StartHour { get; set; }
        DateTime EndHour { get; set; }
        DaySchemaName DaySchema { get; set; }
        Shift Shift { get; set; }

        bool IsNew { set; }
    }
}
