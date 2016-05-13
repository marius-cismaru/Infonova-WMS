using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equistat.Data;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IShiftsOperationViewModel : IDialogViewModel
    {
        string Name { get; set; }
        int StartH { get; set; }
        int StartM { get; set; }
        int EndH { get; set; }
        int EndM { get; set; }
        DateTime ModifiedDate { get; set; }

        bool IsNew { set; }
    }
}
