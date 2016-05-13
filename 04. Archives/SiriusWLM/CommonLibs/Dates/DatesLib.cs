using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.CommonLibs
{
    public static class DatesLib
    {
        public static DateTime GetFirstDayOfMonth(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }

        public static DateTime GetFirstDayOfMonth()
        {
            return GetFirstDayOfMonth(DateTime.Now);
        }

        public static DateTime GetLastDayOfMonth(DateTime dateTime)
        {
            DateTime firstDayOfMonth = GetFirstDayOfMonth(dateTime);
            return firstDayOfMonth.AddMonths(1).AddDays(-1);
        }

        public static DateTime GetLastDayOfMonth()
        {
            return GetLastDayOfMonth(DateTime.Now);
        }

        public static void PopulateSelectBoxWithMonths(CustomControls.EntitySelectBox selectBox, int selectedMonth, bool showOptionAll)
        {
            List<CustomControls.EntityItem> items = new List<CustomControls.EntityItem>();
            
            items.Add(new CustomControls.EntityItem(1, "Ianuarie"));
            items.Add(new CustomControls.EntityItem(2, "Februarie"));
            items.Add(new CustomControls.EntityItem(3, "Martie"));
            items.Add(new CustomControls.EntityItem(4, "Aprilie"));
            items.Add(new CustomControls.EntityItem(5, "Mai"));
            items.Add(new CustomControls.EntityItem(6, "Iunie"));
            items.Add(new CustomControls.EntityItem(7, "Iulie"));
            items.Add(new CustomControls.EntityItem(8, "August"));
            items.Add(new CustomControls.EntityItem(9, "Septembrie"));
            items.Add(new CustomControls.EntityItem(10, "Octombrie"));
            items.Add(new CustomControls.EntityItem(11, "Noiembrie"));
            items.Add(new CustomControls.EntityItem(12, "Decembrie"));

            selectBox.SetItems(items, selectedMonth, showOptionAll);
        }

        public static DateTime CreateSameDateWithNewTime(DateTime originalDate, int hour, int minute, int second)
        {
            return new DateTime(originalDate.Year, originalDate.Month, originalDate.Day, hour, minute, second);
        }
    }
}
