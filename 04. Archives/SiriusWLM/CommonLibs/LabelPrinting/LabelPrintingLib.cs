using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.CommonLibs
{
    public class LabelPrintingLib
    {
        public static void Print()
        {
           /* // Allow the user to select a file.
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            if (System.Windows.Forms.DialogResult.OK == ofd.ShowDialog(this))
            {
                string str = System.IO.File.ReadAllText(ofd.FileName, Encoding.Default);
                str = str.Replace("%OrderNumber%", "RADAN Impex").Replace("%OrderDate%", "15.03.2013").Replace("%ProductCode%", "001-284765323451").Replace("%ProductBatch%", "072");
                // Allow the user to select a printer.
                System.Windows.Forms.PrintDialog pd = new System.Windows.Forms.PrintDialog();
                pd.PrinterSettings = new PrinterSettings();
                if (System.Windows.Forms.DialogResult.OK == pd.ShowDialog(this))
                {
                    // Print the file to the printer.
                    CommonLibs.LabelPrintingZPL.SendStringToPrinter(pd.PrinterSettings.PrinterName, str);
                }
            }*/
        }
    }
}
