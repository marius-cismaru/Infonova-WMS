using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IScanTypesOperationViewModel : IDialogViewModel
    {
        string Name { get; set; }
        string Code { get; set; }

        bool IsNew { set; }
    }
}
