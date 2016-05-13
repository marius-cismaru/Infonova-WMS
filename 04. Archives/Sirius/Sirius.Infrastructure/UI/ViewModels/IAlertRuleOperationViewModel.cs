using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IAlertRuleOperationViewModel : IDialogViewModel
    {
        void Initialize(object alert);
    }
}
