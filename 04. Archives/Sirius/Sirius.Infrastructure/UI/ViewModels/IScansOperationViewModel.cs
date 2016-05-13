using Equistat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IScansOperationViewModel : IDialogViewModel
    {
        DateTime DateTime { get; set; }
        ScanType ScanType { get; set; }
        Machine Machine { get; set; }
        int Value { get; set; }

        bool IsNew { set; }
    }
}
