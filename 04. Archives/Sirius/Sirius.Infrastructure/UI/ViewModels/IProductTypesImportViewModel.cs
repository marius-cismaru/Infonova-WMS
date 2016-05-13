using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IProductTypesImportViewModel : IDialogViewModel
    {
        string FilePath { get; set; }
    }
}
