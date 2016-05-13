using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IAppSettingsOperationViewModel : IDialogViewModel
    {
        int IndicatorsIntervalMinutes { get; set; }
        int RealtimeDisplayMinutes { get; set; }
        //int RefreshSensorsSeconds { get; set; }
        int RefreshAlertsSeconds { get; set; }
        int RefreshIndicatorsMinutes { get; set; }
        int RefreshCycleSeconds { get; set; }
        int RefreshLiveBoardSeconds { get; set; }
        string Language { get; set; }
        string SMTPAddress { get; set; }
        int SMTPPort { get; set; }
        bool IsSSL { get; set; }
        string SenderEmail { get; set; }
        string SenderPassword { get; set; }
    }
}
