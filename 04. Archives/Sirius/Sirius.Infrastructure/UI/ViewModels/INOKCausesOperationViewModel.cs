using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface INOKCausesOperationViewModel : IDialogViewModel
    {
        string Description { get; set; }
        string Code { get; set; }

        bool IsNew { set; }
    }
}
