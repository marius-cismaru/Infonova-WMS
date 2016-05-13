using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IInputTypeOperationViewModel : IDialogViewModel
    {
        bool IsNew { set; }

        string Name { get; set; }
        string UM { get; set; }
    }
}