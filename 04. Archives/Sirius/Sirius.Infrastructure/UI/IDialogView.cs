using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI
{
    public interface IDialogView : IView
    {
        bool? ShowDialog();
        void Show();
    }
}
