using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface ICycleTypesOperationViewModel : IDialogViewModel
    {
        string Name { get; set; }

        bool IsNew { set; }
    }
}
