using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI
{
    public interface IDialogViewModel : IViewModel
    {
        Func<bool> Validate { get; set; }
        bool DoValidation();
    }
}
