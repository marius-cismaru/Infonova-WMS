using Equistat.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface ICalibrationOperationViewModel : IDialogViewModel
    {
        bool IsNew { set; }
        ObservableCollection<ReadingItem> ReadingsList { get; }

        DateTime Date { get; set; }
        double Read  { get; set; }
        double Result { get; set; }
        //double Offset { get; set; }
    }

    public class ReadingItem
    {
        public double Read { get; set; }
        public double Result { get; set; }
    }
}
