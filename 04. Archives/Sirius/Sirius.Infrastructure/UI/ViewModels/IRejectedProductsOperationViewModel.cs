using Equistat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IRejectedProductsOperationViewModel : IDialogViewModel
    {
        Machine Machine { get; set; }
        ProductType ProductType { get; set; }
        DateTime Date { get; set; }
        NOKState State { get; set; }
        Cause Cause { get; set; }

        bool IsNew { set; }
    }
}
