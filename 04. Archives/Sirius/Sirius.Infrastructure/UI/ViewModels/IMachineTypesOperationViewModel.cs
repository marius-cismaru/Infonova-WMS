using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equistat.Data;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IMachineTypesOperationViewModel : IDialogViewModel
    {
        bool CanEdit { set; }
        bool IsNew { set; }

        IEnumerable<SensorType> SelectedSensorsTypes { get; }
        IEnumerable<SensorType> UnselectedSensorsTypes { get; }
        string TypeName { get; set; }
        string Vendor { get; set; }
        string Description { get; set; }
        int MachineTypeID { get; set; }
        CycleType CycleType { get; set; }
    }
}
