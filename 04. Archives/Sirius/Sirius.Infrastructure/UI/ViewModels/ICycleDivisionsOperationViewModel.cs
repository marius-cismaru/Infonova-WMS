using Equistat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface ICycleDivisionsOperationViewModel : IDialogViewModel
    {
        string Name { get; set; }
        int Order { get; set; }
        SensorType SensorType { get; set; }
        int SensorValue { get; set; }
        int MaxTime { get; set; }

        bool IsNew { set; }
        bool CanEdit { set; }
    }
}
