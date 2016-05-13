using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equistat.Data;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface ISensorsOperationViewModel : IDialogViewModel
    {
        bool IsNew { set; }

        string Name { get; set; }
        SensorType SensorType { get;  set; }
        Calibration Calibration { get; set; }
        int InputValue { get; set; }
        int OutPutValue { get; set; }
        Machine Machine { get; set; }  
    }
}
