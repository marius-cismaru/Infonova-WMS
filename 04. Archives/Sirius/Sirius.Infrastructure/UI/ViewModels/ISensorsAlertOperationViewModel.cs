using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equistat.Data;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface ISensorsAlertOperationViewModel : IDialogViewModel
    {
        bool IsNew { set; }
        bool CanEdit { set; }

        SensorType SelectedSensorType { get; set; }
        ProductType SelectedProductType { get; set; }
        double? MinOutputValue { get; set; }
        double? MaxOutputValue { get; set; }
        bool IsSelectedMinOV { get; set; }
        bool IsSelectedMaxOV { get; set; }
    }
}
