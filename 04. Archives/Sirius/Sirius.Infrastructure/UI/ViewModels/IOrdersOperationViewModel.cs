using Equistat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IOrdersOperationViewModel : IDialogViewModel
    {
        ProductType ProductType { get; set; }
        Machine Machine { get; set; }
        DateTime StartDateTime { get; set; }
        int StartH { get; set; }
        int StartM { get; set; }
        string OrderCode { get; set; }

        bool IsNew { set; }
    }
}
