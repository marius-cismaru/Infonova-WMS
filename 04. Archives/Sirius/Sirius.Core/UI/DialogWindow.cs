using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equistat.Infrastructure.UI;
using System.Windows;

namespace Sirius.Core.UI
{
    public class DialogWindow : Window, IDialogView
    {
        protected virtual void OnOk(object sender, RoutedEventArgs args)
        {
            if (this.CanOk())
            {
                this.DialogResult = true;
                this.Close();
            }
        }

        protected virtual void OnCancel(object sender, RoutedEventArgs args)
        {
            this.DialogResult = false;
            this.Close();
        }

        protected virtual bool CanOk()
        {
            var dialogContext = this.DataContext as IDialogViewModel;
            if (dialogContext != null)
            {
                return dialogContext.DoValidation();
            }
            else
            {
                return true;
            }
        }
    }
}
