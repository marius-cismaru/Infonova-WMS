using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;

namespace WpfExtensions.Extensions
{
    public static class Extensions
    {
        public static string ToReportName(this Type type)
        {
            var isTypedDataTable =
                type.IsNested &&
                type.BaseType.FullName.StartsWith("System.Data.TypedTableBase");

            if (isTypedDataTable)
            {
                // in:  Some.Namespace.CategoryDataSet+CategoryDataTable
                // out: CategoryDataSet_Category
                var match = Regex.Match(type.FullName, @"^.+\.(\w+\+\w+)DataTable$");
                return match.Groups[1].Value.Replace("+", "_");
            }
            else
            {
                // in:  Some.Namespace.TypeName
                // out: Some_Namespace_TypeName
                return type.FullName.Replace(".", "_");
            }
        }

        public static IEnumerable<T> Action<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T element in source)
            {
                action(element);
            }

            return source;
        }

        public static DataTable ToDataTable<T>(this IList<T> source)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable dt = new DataTable();
            for (int i = 0; i < properties.Count; i++)
            {
                PropertyDescriptor property = properties[i];
                Type type = property.PropertyType;
                if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    type = type.GetGenericArguments()[0];
                }
                dt.Columns.Add(property.Name, type);
            }
            object[] values = new object[properties.Count];
            foreach (T item in source)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = properties[i].GetValue(item);
                }
                dt.Rows.Add(values);
            }
            return dt;
        }

        public static int GetNumber(this string source)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var ch in source.ToCharArray())
            {
                if (char.IsDigit(ch))
                {
                    sb.Append(ch);
                }
            }
            return Int32.Parse(sb.ToString());
        }

        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
            {
                action(item);
            }
        }

        //public static List<T> WithRollup<T, TKey>(this IEnumerable<T> elements,
        //                                          Func<T, TKey> primaryKeyOfElement,
        //                                          Func<IGrouping<TKey, T>, T> calculateSubTotalElement)
        //{
        //    // Create a new list the items, subtotals, and the grand total.
        //    List<T> results = new List<T>();

        //    var lookup = elements.ToLookup(primaryKeyOfElement);
        //    foreach (var group in lookup)
        //    {
        //        // Add items in the current group
        //        results.AddRange(group);
        //        // Add subTotal for current group
        //        results.Add(calculateSubTotalElement(group));
        //    }
        //    // Add grand total
        //    results.AddRange(elements);
        //    //results.Add(grandTotalElement);

        //    return results;
        //}
    }
}
