using Equistat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IBreakTypesOperationViewModel : IDialogViewModel
    {
        string Name { get; set; }
        string Code { get; set; }
        Color Color { get; set; }
        bool IsPlanned { get; set; }
        bool IsAvailabilityAffected { get; set; }
        bool IsGlobalBreak { get; set; }

        bool IsNew { set; }
    }
}
