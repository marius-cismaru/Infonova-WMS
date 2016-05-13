using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equistat.Data;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Equistat.Infrastructure.UI.ViewModels
{
    public interface IMachineDetailZoomedViewModel : IDialogViewModel
    {
        Machine SelectedMachine { get; set; }
        PlotModel SelectedPlotModel { get; set; }
        DateTime Interval { get; set; }
        string GraphicTitle { get; set; }
        string MachineBackground { get; set; }
        bool RealTime { get; set; }
        //Cycle LastCycle { get; set; }
    }
}
