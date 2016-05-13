using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IDaysSchemaOperationViewModel : IDialogViewModel
    {
        int SelectedDay { get; set; }
        bool HasBreak { get; set; }
        bool IsNew { set; }
        bool AllDays { get; set; }
    }
}
