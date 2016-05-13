using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equistat.Infrastructure.UI;
using Equistat.Infrastructure.UI.Wrappers;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IWizardPage : IViewModel
    {
        void Initialize(object alert);
        bool IsSelected { get; set; }
        int Decrement { get; set; }
        WizardOption SelectedOption { get; }
        IEnumerable<WizardOption> SelectedOptions { get; }
        bool IsValid();
    }
}
