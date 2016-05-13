using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equistat.Infrastructure.Services;
using Equistat.Infrastructure.Attributes;
using Equistat.Infrastructure.BaseClasses;
using Microsoft.Practices.Unity;
using System.Data;
using System.IO;
using System.Drawing;
using Microsoft.Win32;
using OfficeOpenXml;
using OfficeOpenXml.Style;


namespace Sirius.Core.Services
{
    public class ExportSvc : ServiceBase, IExportSvc
    {
        [Service]
        public IUIManagerSvc UIManagerSvc { get; set; }
        [Service]
        public IDatabaseSvc DatabaseSvc { get; set; }

        public ExportSvc(IUnityContainer container)
            : base(container)
        {
        }

        public void AddTableHeaderRow(List<object> TitleList, System.Data.DataTable table)
        {
            foreach (object TitleString in TitleList)
            {
                table.Columns.Add(TitleString.ToString());
            }
        }

        public void AddTableRow(List<object> DataList, System.Data.DataTable table)
        {
            DataRow NewRow;
            NewRow = table.NewRow();
            if (DataList != null)
            {
                for (int i = 0; i < DataList.Count; i++)
                {
                    NewRow[i] = DataList[i];
                }
            }
            table.Rows.Add(NewRow);
        }

        public void Export2ExcelTechnicalSuport(List<XLSColumn> columns, System.Data.DataTable dt)
        {
            if (!Directory.Exists(@"XLS"))
            {
                Directory.CreateDirectory("XLS");
            }
            string datenow = DateTime.Now.ToString("dd-MM-yyyy");
            string filePath = @"XLS\Export "+ Equistat.Resources.Properties.Resources.TechnicalSupport_Title+ " "  + datenow + ".xlsx";
            string folder = Environment.CurrentDirectory;
            filePath = folder + "\\XLS\\Export " + Equistat.Resources.Properties.Resources.TechnicalSupport_Title + " " + datenow + ".xlsx";
            FileInfo file = new FileInfo(filePath);
            using (ExcelPackage pck = new ExcelPackage(file))
            {
                System.Data.DataTable tbl = new System.Data.DataTable();
                List<object> TitleList = new List<object>();
                foreach (XLSColumn xc in columns)
                {
                    TitleList.Add(xc.Title);
                }
                AddTableHeaderRow(TitleList, tbl);
                if (!pck.Workbook.Worksheets.Select(o => o.Name).Contains("Equistat")) pck.Workbook.Worksheets.Add("Equistat");
                //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1
                ExcelWorksheet ws = pck.Workbook.Worksheets[1];
                int columnIndex = 0;
                int rowIndex = 0;
                int ok = 0;
                foreach (DataRow row in dt.Rows)
                {
                    int numberr = dt.Rows.Count;
                    rowIndex++;
                    columnIndex = 0;
                    ok = 0;
                    foreach (DataColumn col in dt.Columns)
                    {
                        columnIndex++;
                        ws.Cells[rowIndex + 1, columnIndex].Value = row[col.ColumnName].ToString();
                        string cellName = row[col.ColumnName].ToString();
                        if (cellName.Equals("Break Type Name") || cellName.Equals("Tip Stationare")) { ok = 1; }
                    }
                    if (ok == 1)
                    {
                        ExcelRange rng = ws.Cells[rowIndex + 1, 1, rowIndex + 1, columnIndex];
                        rng.Style.Font.Bold = true;
                        rng.Style.Fill.PatternType = ExcelFillStyle.Solid;                      //Set Pattern for the background to Solid
                        rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(142, 189, 249));  //Set color to dark blue
                        rng.Style.Font.Color.SetColor(Color.White);
                    }
                }
                ws.Cells["A1"].LoadFromDataTable(tbl, true);
                ws.Column(1).Width = 22;
                ws.Column(2).Width = 22;
                ws.Column(3).Width = 22;
                ws.Column(4).Width = 27;
                ws.Column(5).Width = 22;
                ws.Column(6).Width = 22;
                ws.Column(7).Width = 28;
                ws.Column(8).Width = 12;
                ws.Column(9).Width = 15;
                ws.Column(10).Width = 20;
                ws.Column(11).Width = 16;
                int i = 1;

                foreach (XLSColumn xc in columns)
                {
                    ExcelRange rng = ws.Cells[1, i, 1, i];

                    rng.Style.Font.Bold = true;
                    rng.Style.Fill.PatternType = ExcelFillStyle.Solid;                      //Set Pattern for the background to Solid
                    rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(79, 129, 189));  //Set color to dark blue
                    rng.Style.Font.Color.SetColor(Color.White);
                    rng = ws.Cells[2, i, dt.Rows.Count + 2, i];
                    if (xc.Type == "number")
                    {
                        if (xc.Mask != null)
                            rng.Style.Numberformat.Format = xc.Mask;
                        rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                    }
                    else
                    {
                        rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    }
                    rng = ws.Cells[1, i];
                    rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    i++;
                }
                pck.Save();
                this.UIManagerSvc.ShowMessageBox("Date exportate in fisierul " + filePath, Resources.Properties.Resources.Confirmation_Title);
                System.Diagnostics.Process.Start(filePath);
            }
        }

        public void Export2ExcelCycles(List<XLSColumn> columns, System.Data.DataTable dt)
        {
            if (!Directory.Exists(@"XLS"))
            {
                Directory.CreateDirectory("XLS");
            }
            string datenow = DateTime.Now.ToString("dd-MM-yyyy");
            string filePath = @"XLS\Export "+ Equistat.Resources.Properties.Resources.Cycles_Title+" "+ datenow + ".xlsx";
            string folder = Environment.CurrentDirectory;
            filePath = folder + "\\XLS\\Export "+Equistat.Resources.Properties.Resources.Cycles_Title+ " "+ datenow + ".xlsx";
            FileInfo file = new FileInfo(filePath);
            using (ExcelPackage pck = new ExcelPackage(file))
            {
                System.Data.DataTable tbl = new System.Data.DataTable();
                List<object> TitleList = new List<object>();
                foreach (XLSColumn xc in columns)
                {
                    TitleList.Add(xc.Title);
                }
                AddTableHeaderRow(TitleList, tbl);
                if (!pck.Workbook.Worksheets.Select(o => o.Name).Contains("Equistat")) pck.Workbook.Worksheets.Add("Equistat");
                //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1
                ExcelWorksheet ws = pck.Workbook.Worksheets[1];
                int columnIndex = 0;
                int rowIndex = 0;
                int ok = 0;
                foreach (DataRow row in dt.Rows)
                {
                    int numberr = dt.Rows.Count;
                    rowIndex++;
                    columnIndex = 0;
                    ok = 0;
                    foreach (DataColumn col in dt.Columns)
                    {
                        columnIndex++;
                        ws.Cells[rowIndex + 1, columnIndex].Value = row[col.ColumnName].ToString();
                        string cellName = row[col.ColumnName].ToString();
                    }
                }
                ws.Cells["A1"].LoadFromDataTable(tbl, true);
                ws.Column(1).Width = 22;
                ws.Column(2).Width = 13;
                ws.Column(3).Width = 22;
                ws.Column(4).Width = 16;
                ws.Column(5).Width = 15;
                ws.Column(6).Width = 18;
                ws.Column(7).Width = 28;
                int y = 1;
                int i = 1;
                foreach (XLSColumn xc in columns)
                {
                    ExcelRange rng = ws.Cells[1, i, 1, i];

                    rng.Style.Font.Bold = true;
                    rng.Style.Fill.PatternType = ExcelFillStyle.Solid;                      //Set Pattern for the background to Solid
                    rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(79, 129, 189));  //Set color to dark blue
                    rng.Style.Font.Color.SetColor(Color.White);
                    rng = ws.Cells[2, i, dt.Rows.Count + 2, i];
                    if (xc.Type == "number")
                    {
                        if (xc.Mask != null)
                            rng.Style.Numberformat.Format = xc.Mask;
                        rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                    }
                    else
                    {
                        rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    }
                    rng = ws.Cells[1, i];
                    rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    i++;
                }
                pck.Save();
                this.UIManagerSvc.ShowMessageBox("Date exportate in fisierul " + filePath, Resources.Properties.Resources.Confirmation_Title);
                System.Diagnostics.Process.Start(filePath);
            }
        }

        public void Export2ExcelScans(List<XLSColumn> columns, System.Data.DataTable dt)
        {
            if (!Directory.Exists(@"XLS"))
            {
                Directory.CreateDirectory("XLS");
            }
            string datenow = DateTime.Now.ToString("dd-MM-yyyy");
            string filePath = @"XLS\Export "+Equistat.Resources.Properties.Resources.Scans_Title+" "+datenow + ".xlsx";
            string folder = Environment.CurrentDirectory;
            filePath = folder + "\\XLS\\Export " + Equistat.Resources.Properties.Resources.Scans_Title+" "+datenow + ".xlsx";
            FileInfo file = new FileInfo(filePath);
            using (ExcelPackage pck = new ExcelPackage(file))
            {
                System.Data.DataTable tbl = new System.Data.DataTable();
                List<object> TitleList = new List<object>();
                foreach (XLSColumn xc in columns)
                {
                    TitleList.Add(xc.Title);
                }
                AddTableHeaderRow(TitleList, tbl);
                if (!pck.Workbook.Worksheets.Select(o => o.Name).Contains("Equistat")) pck.Workbook.Worksheets.Add("Equistat");
                //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1
                ExcelWorksheet ws = pck.Workbook.Worksheets[1];
                int columnIndex = 0;
                int rowIndex = 0;
                int ok = 0;
                foreach (DataRow row in dt.Rows)
                {
                    int numberr = dt.Rows.Count;
                    rowIndex++;
                    columnIndex = 0;
                    ok = 0;
                    foreach (DataColumn col in dt.Columns)
                    {
                        columnIndex++;
                        ws.Cells[rowIndex + 1, columnIndex].Value = row[col.ColumnName].ToString();
                        string cellName = row[col.ColumnName].ToString();
                    }
                }
                ws.Cells["A1"].LoadFromDataTable(tbl, true);
                ws.Column(1).Width = 22;
                ws.Column(2).Width = 15;
                ws.Column(3).Width = 25;
                ws.Column(4).Width = 18;
                int i = 1;

                foreach (XLSColumn xc in columns)
                {
                    ExcelRange rng = ws.Cells[1, i, 1, i];
                    rng.Style.Font.Bold = true;
                    rng.Style.Fill.PatternType = ExcelFillStyle.Solid;                      //Set Pattern for the background to Solid
                    rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(79, 129, 189));  //Set color to dark blue
                    rng.Style.Font.Color.SetColor(Color.White);
                    rng = ws.Cells[2, i, dt.Rows.Count + 2, i];
                    if (xc.Type == "number")
                    {
                        if (xc.Mask != null)
                            rng.Style.Numberformat.Format = xc.Mask;
                        rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                    }
                    else
                    {
                        rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    }
                    rng = ws.Cells[1, i];
                    rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    i++;
                }
                pck.Save();
                this.UIManagerSvc.ShowMessageBox("Date exportate in fisierul " + filePath, Resources.Properties.Resources.Confirmation_Title);
                System.Diagnostics.Process.Start(filePath);
            }
        }

        public void Export2ExcelSensorsReading(List<XLSColumn> columns, System.Data.DataTable dt)
        {
            if (!Directory.Exists(@"XLS"))
            {
                Directory.CreateDirectory("XLS");
            }
            string datenow = DateTime.Now.ToString("dd-MM-yyyy");
            string filePath = @"XLS\Export "+Equistat.Resources.Properties.Resources.SensorsReading_Title+" "+datenow + ".xlsx";
            string folder = Environment.CurrentDirectory;
            filePath = folder + "\\XLS\\Export " + Equistat.Resources.Properties.Resources.SensorsReading_Title + " " +datenow + ".xlsx";
            FileInfo file = new FileInfo(filePath);
            using (ExcelPackage pck = new ExcelPackage(file))
            {
                System.Data.DataTable tbl = new System.Data.DataTable();
                List<object> TitleList = new List<object>();
                foreach (XLSColumn xc in columns)
                {
                    TitleList.Add(xc.Title);
                }
                AddTableHeaderRow(TitleList, tbl);
                if (!pck.Workbook.Worksheets.Select(o => o.Name).Contains("Equistat")) pck.Workbook.Worksheets.Add("Equistat");
                //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1
                ExcelWorksheet ws = pck.Workbook.Worksheets[1];
                int columnIndex = 0;
                int rowIndex = 0;
                int ok = 0;
                foreach (DataRow row in dt.Rows)
                {
                    int numberr = dt.Rows.Count;
                    rowIndex++;
                    columnIndex = 0;
                    ok = 0;
                    foreach (DataColumn col in dt.Columns)
                    {
                        columnIndex++;
                        ws.Cells[rowIndex + 1, columnIndex].Value = row[col.ColumnName].ToString();
                        string cellName = row[col.ColumnName].ToString();
                    }
                }
                ws.Cells["A1"].LoadFromDataTable(tbl, true);
                ws.Column(1).Width = 22;
                ws.Column(2).Width = 22;
                ws.Column(3).Width = 25;
                ws.Column(4).Width = 14;
                ws.Column(5).Width = 22;
                ws.Column(6).Width = 22;
                int i = 1;

                foreach (XLSColumn xc in columns)
                {
                    ExcelRange rng = ws.Cells[1, i, 1, i];

                    rng.Style.Font.Bold = true;
                    rng.Style.Fill.PatternType = ExcelFillStyle.Solid;                      //Set Pattern for the background to Solid
                    rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(79, 129, 189));  //Set color to dark blue
                    rng.Style.Font.Color.SetColor(Color.White);
                    rng = ws.Cells[2, i, dt.Rows.Count + 2, i];
                    if (xc.Type == "number")
                    {
                        if (xc.Mask != null)
                            rng.Style.Numberformat.Format = xc.Mask;
                        rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                    }
                    else
                    {
                        rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    }
                    rng = ws.Cells[1, i];
                    rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    i++;
                }
                pck.Save();
                this.UIManagerSvc.ShowMessageBox("Date exportate in fisierul " + filePath, Resources.Properties.Resources.Confirmation_Title);
                System.Diagnostics.Process.Start(filePath);
            }
        }

        public void SetBackground(List<XLSColumn> columns, ExcelWorksheet ws, System.Data.DataTable dt)
        {
            int i = 1;
            foreach (XLSColumn xc in columns)
            {
                ExcelRange rng = ws.Cells[1, i, 1, i];

                rng.Style.Font.Bold = true;
                rng.Style.Fill.PatternType = ExcelFillStyle.Solid;                      //Set Pattern for the background to Solid
                rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(79, 129, 189));  //Set color to dark blue
                rng.Style.Font.Color.SetColor(Color.White);
                rng = ws.Cells[2, i, dt.Rows.Count + 2, i];
                if (xc.Type == "number")
                {
                    if (xc.Mask != null)
                        rng.Style.Numberformat.Format = xc.Mask;
                    rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                }
                else
                {
                    rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                }
                rng = ws.Cells[1, i];
                rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                i++;
            }

        }

        public void LoadData(ExcelWorksheet ws, System.Data.DataTable dt)
        {
            int columnIndex = 0;
            int rowIndex = 0;
            int ok = 0;

            foreach (DataRow row in dt.Rows)
            {
                int numberr = dt.Rows.Count;
                rowIndex++;
                columnIndex = 0;
                ok = 0;
                foreach (DataColumn col in dt.Columns)
                {
                    columnIndex++;
                    ws.Cells[rowIndex + 1, columnIndex].Value = row[col.ColumnName].ToString();
                    string cellName = row[col.ColumnName].ToString();
                }
            }
        }

        public void Export2ExcelTop5(List<XLSColumn> columns, System.Data.DataTable dt,
                                     List<XLSColumn> columnsProd, System.Data.DataTable dtProd,
                                     List<XLSColumn> columnsBreaks, System.Data.DataTable dtBreaks,
                                     List<XLSColumn> columnsNormDev, System.Data.DataTable dtNormDev,
                                     List<XLSColumn> columnsLowOEE, System.Data.DataTable dtLowOEE,
                                     List<XLSColumn> columnsHighOEE, System.Data.DataTable dtHighOEE)
        {
            if (!Directory.Exists(@"XLS"))
            {
                Directory.CreateDirectory("XLS");
            }
            string datenow = DateTime.Now.ToString("dd-MM-yyyy");
            string folder = Environment.CurrentDirectory;
            string filePath = folder + "\\XLS\\Export " + Equistat.Resources.Properties.Resources.Top5_Title + " " + datenow + ".xlsx";
            FileInfo file = new FileInfo(filePath);

            using (ExcelPackage pck = new ExcelPackage(file))
            {
                //machine scraps
                System.Data.DataTable tbl = new System.Data.DataTable();
                List<object> TitleList = new List<object>();
                foreach (XLSColumn xc in columns)
                {
                    TitleList.Add(xc.Title);
                }
                AddTableHeaderRow(TitleList, tbl);
                if (!pck.Workbook.Worksheets.Select(o => o.Name).Contains(Equistat.Resources.Properties.Resources.Top5MachineScrap_Text))
                    pck.Workbook.Worksheets.Add(Equistat.Resources.Properties.Resources.Top5MachineScrap_Text);

                //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1
                ExcelWorksheet ws = pck.Workbook.Worksheets[1];
                this.LoadData(ws, dt);
                ws.Cells["A1"].LoadFromDataTable(tbl, true);
                ws.Column(1).Width = 22;
                ws.Column(2).Width = 22;
                ws.Column(3).Width = 25;
                ws.Column(4).Width = 14;
                ws.Column(5).Width = 22;
                ws.Column(6).Width = 22;
                ws.Column(7).Width = 22;
                ws.Column(8).Width = 22;
                this.SetBackground(columns, ws, dt);

                //products scraps
                System.Data.DataTable tblProd = new System.Data.DataTable();
                List<object> TitleListProd = new List<object>();
                foreach (XLSColumn xc in columnsProd)
                {
                    TitleListProd.Add(xc.Title);
                }
                AddTableHeaderRow(TitleListProd, tblProd);
                if (!pck.Workbook.Worksheets.Select(o => o.Name).Contains(Equistat.Resources.Properties.Resources.Top5ProductScrap_Text))
                    pck.Workbook.Worksheets.Add(Equistat.Resources.Properties.Resources.Top5ProductScrap_Text);

                //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1
                ExcelWorksheet ws2 = pck.Workbook.Worksheets[2];
                this.LoadData(ws2, dtProd);
                ws2.Cells["A1"].LoadFromDataTable(tblProd, true);
                ws2.Column(1).Width = 22;
                ws2.Column(2).Width = 22;
                ws2.Column(3).Width = 22;
                ws2.Column(4).Width = 70;
                ws2.Column(5).Width = 70;
                this.SetBackground(columnsProd, ws2, dtProd);

                //breaks
                System.Data.DataTable tblBreaks = new System.Data.DataTable();
                List<object> TitleListBreaks = new List<object>();
                foreach (XLSColumn xc in columnsBreaks)
                {
                    TitleListBreaks.Add(xc.Title);
                }
                AddTableHeaderRow(TitleListBreaks, tblBreaks);
                if (!pck.Workbook.Worksheets.Select(o => o.Name).Contains(Equistat.Resources.Properties.Resources.Top5Breaks_Text))
                    pck.Workbook.Worksheets.Add(Equistat.Resources.Properties.Resources.Top5Breaks_Text);

                //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1
                ExcelWorksheet ws3 = pck.Workbook.Worksheets[3];
                this.LoadData(ws3, dtBreaks);
                ws3.Cells["A1"].LoadFromDataTable(tblBreaks, true);
                ws3.Column(1).Width = 22;
                ws3.Column(2).Width = 22;
                ws3.Column(2).Width = 22;
                this.SetBackground(columnsBreaks, ws3, dtBreaks);

                //norm deviation
                System.Data.DataTable tblNormDev = new System.Data.DataTable();
                List<object> TitleListNormDev = new List<object>();
                foreach (XLSColumn xc in columnsNormDev)
                {
                    TitleListNormDev.Add(xc.Title);
                }
                AddTableHeaderRow(TitleListNormDev, tblNormDev);
                if (!pck.Workbook.Worksheets.Select(o => o.Name).Contains(Equistat.Resources.Properties.Resources.Top5NormDeviation_Text))
                    pck.Workbook.Worksheets.Add(Equistat.Resources.Properties.Resources.Top5NormDeviation_Text);

                //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1
                ExcelWorksheet ws4 = pck.Workbook.Worksheets[4];
                this.LoadData(ws4, dtNormDev);
                ws4.Cells["A1"].LoadFromDataTable(tblNormDev, true);
                ws4.Column(1).Width = 22;
                ws4.Column(2).Width = 22;
                this.SetBackground(columnsNormDev, ws4, dtNormDev);

                //lowest OEE
                System.Data.DataTable tblLowOEE = new System.Data.DataTable();
                List<object> TitleListLowOEE = new List<object>();
                foreach (XLSColumn xc in columnsLowOEE)
                {
                    TitleListLowOEE.Add(xc.Title);
                }
                AddTableHeaderRow(TitleListLowOEE, tblLowOEE);
                if (!pck.Workbook.Worksheets.Select(o => o.Name).Contains(Equistat.Resources.Properties.Resources.Top5LowestOEE_Text))
                    pck.Workbook.Worksheets.Add(Equistat.Resources.Properties.Resources.Top5LowestOEE_Text);

                //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1
                ExcelWorksheet ws5 = pck.Workbook.Worksheets[5];
                this.LoadData(ws5, dtLowOEE);
                ws5.Cells["A1"].LoadFromDataTable(tblLowOEE, true);
                ws5.Column(1).Width = 22;
                ws5.Column(2).Width = 22;
                this.SetBackground(columnsLowOEE, ws5, dtLowOEE);

                //highest OEE
                System.Data.DataTable tblHighOEE = new System.Data.DataTable();
                List<object> TitleListHighOEE = new List<object>();
                foreach (XLSColumn xc in columnsHighOEE)
                {
                    TitleListHighOEE.Add(xc.Title);
                }
                AddTableHeaderRow(TitleListHighOEE, tblHighOEE);
                if (!pck.Workbook.Worksheets.Select(o => o.Name).Contains(Equistat.Resources.Properties.Resources.Top5HighestOEE_Text))
                    pck.Workbook.Worksheets.Add(Equistat.Resources.Properties.Resources.Top5HighestOEE_Text);

                //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1
                ExcelWorksheet ws6 = pck.Workbook.Worksheets[6];
                this.LoadData(ws6, dtHighOEE);
                ws6.Cells["A1"].LoadFromDataTable(tblHighOEE, true);
                ws6.Column(1).Width = 22;
                ws6.Column(2).Width = 22;
                this.SetBackground(columnsHighOEE, ws6, dtHighOEE);

                pck.Save();
                this.UIManagerSvc.ShowMessageBox("Date exportate in fisierul " + filePath, Resources.Properties.Resources.Confirmation_Title);
                System.Diagnostics.Process.Start(filePath);
            }
        }

        public void Export2Excel(System.Data.DataTable dt)
        {
            //var excel = new Application();

            //excel.Application.Workbooks.Add(true);

            ////DataTable dt = (DataTable)dt.DataSource;

            //int columnIndex = 0;

            //foreach (DataColumn col in dt.Columns)
            //{
            //    columnIndex++;
            //    excel.Cells[1, columnIndex] = col.ColumnName;
            //}

            //int rowIndex = 0;

            //foreach (DataRow row in dt.Rows)
            //{
            //    rowIndex++;
            //    columnIndex = 0;

            //    foreach (DataColumn col in dt.Columns)
            //    {
            //        columnIndex++;
            //        excel.Cells[rowIndex + 1, columnIndex] =
            //            row[col.ColumnName].ToString();
            //    }
            //}

            //excel.Visible = true;
            //Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)excel.ActiveSheet;
            //worksheet.Activate();
        }

    }
}
