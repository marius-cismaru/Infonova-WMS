using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equistat.Infrastructure.UI.Wrappers;
using Equistat.Data;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IUserSettingsOperationViewModel : IDialogViewModel
    {
        int RealtimeDisplayMinutes { get; set; }
        User User { get; set; }
    }
}
