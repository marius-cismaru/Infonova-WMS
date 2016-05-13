using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equistat.Infrastructure.UI;
using Microsoft.Practices.Unity;

namespace Equistat.Infrastructure.BaseClasses
{
    public class DialogViewModelBase : ViewModelBase, IDialogViewModel
    {
        public DialogViewModelBase(IUnityContainer container)
            : base(container)
        {
        }

        public Func<bool> Validate { get; set; }
        public virtual bool DoValidation()
        {
            if (this.Validate != null)
            {
                return this.Validate();
            }
            else
            {
                return true;
            }
        }
    }
}
