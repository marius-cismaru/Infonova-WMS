using Equistat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface ITechnicalSupportOperationViewModel : IDialogViewModel
    {
        DateTime BeginDate { get; set; }
        int BeginHour { get; set; }
        int BeginMinute { get; set; }
        DateTime EndDate { get; set; }
        int EndHour { get; set; }
        int EndMinute { get; set; }
        BreakType BreakType { get; set; }
        bool IsBegin { get; set; }
        bool IsEnd { get; set; }

        bool IsNew { set; }
    }
}
