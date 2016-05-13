using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Equistat.Infrastructure.UI;
using System.Windows.Controls;
using Equistat.Infrastructure.BaseClasses;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Equistat.Infrastructure.Attributes;
using Equistat.Infrastructure.Services;
using WpfExtensions.Util;
using Equistat.Infrastructure.Events;

namespace Sirius.Core.Services
{
    public class UIManagerSvc : ServiceBase, IUIManagerSvc
    {
        [Service]
        public IUnityContainer Container { get; set; }

        public UIManagerSvc(IUnityContainer container)
            : base(container)
        {
        }

        private ObservableCollection<PanelBase> openedPages = new ObservableCollection<PanelBase>();
        public IEnumerable<PanelBase> GetOpenedPages()
        {
            return this.openedPages;
        }

        public bool? ShowDialog(IViewModel viewModel, bool isModal = true)
        {
            var dialogWindow = this.CreateWindow(viewModel);
            bool? result = null;
            if (isModal)
            {
                result = dialogWindow.ShowDialog();
            }
            else
            {
                dialogWindow.Show();
            }
            return result;
        }

        public IDialogView CreateWindow(IViewModel viewModel)
        {
            var type = this.GetView(viewModel).GetType();
            var view = this.Container.Resolve(type) as Window;

            var dialogView = view as IDialogView;

            if (Application.Current.MainWindow.IsActive)
            {
                view.Owner = Application.Current.MainWindow;
            }
            (dialogView as Window).DataContext = viewModel;
            return dialogView;
        }

        public void OpenPage(IViewModel viewModel)
        {
            var view = this.GetView(viewModel);
            (view as UserControl).DataContext = viewModel;

            if (!this.openedPages.Any(p => p.View == view))
            {
                this.openedPages.Add(new PanelBase()
                {
                    View = view,
                    Header = viewModel.Header,
                    CloseCommand = new DelegateCommand<object>(o => this.ClosePage(o as IViewModel)),
                });
            }
            var panel = this.openedPages.FirstOrDefault(p => p.Header == viewModel.Header);
            this.EventAggregator.GetEvent<PageOpenEvent>().Publish(panel);
        }

        public void ClosePage(IViewModel viewModel)
        {
            var view = this.GetView(viewModel);
            if (this.openedPages.Any(p => p.View == view))
            {
                var panel = this.openedPages.FirstOrDefault(p => p.View == view);
                this.openedPages.Remove(panel);
            }
        }

        public void ClearPages()
        {
            this.openedPages.Clear();
        }

        IDictionary<IViewModel, IView> registeredViews = new Dictionary<IViewModel, IView>();

        public void Register(IViewModel viewModel, IView view)
        {
            this.registeredViews.Add(viewModel, view);
        }

        public IView GetView(IViewModel viewModel)
        {
            var view = this.registeredViews.FirstOrDefault(t => t.Key.GetType() == viewModel.GetType()).Value;
            return view;
        }

        public MessageBoxResult ShowMessageBox(string message, string title,
                                                MessageBoxButton buttons = MessageBoxButton.OK,
                                                MessageBoxImage icon = MessageBoxImage.Information)
        {
            return MessageBox.Show(message, title, buttons, icon);
        }
    }
}
