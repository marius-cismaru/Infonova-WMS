using Equistat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IBreaksPlanOperationViewModel : IDialogViewModel
    {
        BreakType BreakType { get; set; }
        int StartH { get; set; }
        int StartM { get; set; }
        int EndH { get; set; }
        int EndM { get; set; }
        Machine Machine { get; set; }
        DaySchemaName SchemaName { get; set; }
        DateTime LastModifiedDate { get; set; }

        bool IsNew { set; }
    }
}
