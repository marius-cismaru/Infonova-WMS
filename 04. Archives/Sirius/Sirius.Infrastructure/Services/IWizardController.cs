using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Equistat.Infrastructure.UI.ViewModels;
using Equistat.Infrastructure.UI.Wrappers;

namespace Equistat.Infrastructure.Services
{
    public interface IWizardController
    {
        bool NextPage();
        bool PreviousPage();
        void InitializePages(object alert);
        int CurrentPageIndex { get; }
        bool IsCurrentPageLast { get; }
        IWizardPage CurrentPage { get; set; }
        ObservableCollection<IWizardPage> Pages { get; set; }
        event EventHandler Finish;
        event EventHandler BeforePageChange;
    }
}
