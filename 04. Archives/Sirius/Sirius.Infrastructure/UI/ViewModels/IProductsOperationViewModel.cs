using Equistat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IProductsOperationViewModel : IDialogViewModel
    {
        ProductType ProductType { get; set; }
        Machine Machine { get; set; }
        DateTime StartDateTime { get; set; }
        int StartH { get; set; }
        int StartM { get; set; }

        bool IsNew { set; }
    }
}
