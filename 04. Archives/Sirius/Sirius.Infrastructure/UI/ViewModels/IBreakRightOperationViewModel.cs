using Equistat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IBreakRightOperationViewModel : IDialogViewModel
    {
        BreakType BreakType { get; set; }

        bool IsNew { set; }
    }
}
