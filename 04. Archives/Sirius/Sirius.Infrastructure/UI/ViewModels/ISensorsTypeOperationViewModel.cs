using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data = System.Data;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface ISensorsTypeOperationViewModel : IDialogViewModel
    {
        bool IsNew { set; }

        string TypeName { get; set; }
        Data.InputType InputType { get; set; }
        double MinInputValue { get; set; }
        double MaxInputValue { get; set; }
        Data.OutputType OutputType { get; set; }
        double MinOutputValue { get; set; }
        double MaxOutputValue { get; set; }
        int CalibrationInterval { get; set; }
        bool IsVisibleOnLiveBoard { get; set; }
    }
}
