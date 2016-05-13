using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Equistat.Infrastructure.Services
{
    public struct XLSColumn
    {
        public string Title;
        public string Mask;
        public string Type;
    }

    public interface IExportSvc
    {
        void AddTableHeaderRow(List<object> TitleList, System.Data.DataTable table);
        void AddTableRow(List<object> DataList, System.Data.DataTable table);
        void Export2Excel(DataTable dt);
        void Export2ExcelTechnicalSuport(List<XLSColumn> xlsColumns, DataTable dt);
        void Export2ExcelScans(List<XLSColumn> xlsColumns, DataTable dt);
        void Export2ExcelSensorsReading(List<XLSColumn> xlsColumns, DataTable dt);
        void Export2ExcelCycles(List<XLSColumn> xlsColumns, DataTable dt);
        void Export2ExcelTop5(List<XLSColumn> columns, System.Data.DataTable dt,
                              List<XLSColumn> columnsProd, System.Data.DataTable dt2,
                              List<XLSColumn> columnsBreaks, System.Data.DataTable dtBreaks,
                              List<XLSColumn> columnsNormDev, System.Data.DataTable dtNormDev,
                              List<XLSColumn> columnsLowOEE, System.Data.DataTable dtLowOEE,
                              List<XLSColumn> columnsHighOEE, System.Data.DataTable dtHighOEE);
    }
}
