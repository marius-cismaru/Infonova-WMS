using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equistat.Data;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IProductTypesOperationViewModel : IDialogViewModel
    {
        bool IsNew { set; }

        string Name { get; set; }
        double Weight { get; set; }
        string AreaOfUse { get; set; }
        int Norm { get; set; }
        int MoldPieces { get; set; }
        string Code { get; set; }
    }
}
