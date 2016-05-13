using Equistat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface ICycleDivisionResetSensorsOperationViewModel : IDialogViewModel
    {
        SensorType SensorType { get; set; }
        int SensorValue { get; set; }

        bool IsNew { set; }
    }
}
