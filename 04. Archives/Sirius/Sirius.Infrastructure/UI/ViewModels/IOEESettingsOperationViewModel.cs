using Equistat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IOEESettingsOperationViewModel : IDialogViewModel
    {
        bool IsEdit { get; set; }
        double Minimum { get; set; }
        double Maximum { get; set; }
        bool IsBlinking { get; set; }
        Color SelectedColor { get; set; }
    }
}
