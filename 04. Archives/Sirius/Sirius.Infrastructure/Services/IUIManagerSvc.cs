using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equistat.Infrastructure.UI;
using Equistat.Infrastructure.BaseClasses;
using System.Windows;

namespace Equistat.Infrastructure.Services
{
    public interface IUIManagerSvc
    {
        IEnumerable<PanelBase> GetOpenedPages();
        void OpenPage(IViewModel page);
        void ClosePage(IViewModel page);
        void Register(IViewModel viewModel, IView view);
        IView GetView(IViewModel viewModel);
        bool? ShowDialog(IViewModel viewModel, bool isModal = true);
        MessageBoxResult ShowMessageBox(string message, string title,
                                        MessageBoxButton buttons = MessageBoxButton.OK,
                                        MessageBoxImage icon = MessageBoxImage.Information);
        void ClearPages();
    }
}
