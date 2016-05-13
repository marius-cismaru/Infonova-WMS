using Equistat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IMachineSensorsOperationViewModel : IDialogViewModel
    {
        string Name { get; set; }
        int ChannelCode { get; set; }
        string SerialNumber { get; set; }
        Machine SelectedMachine { get; set; }
        SensorType SensorType { get; set; }
        double MinimumLimit { get; set; }
        double MaximumLimit { get; set; }
        bool IsMinLimitChecked { get; set; }
        bool IsMaxLimitChecked { get; set; }

        bool IsNew { set; }
    }
}
