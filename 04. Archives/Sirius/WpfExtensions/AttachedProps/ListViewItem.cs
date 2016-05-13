using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace WpfExtensions.AttachedProps
{
    public class ListViewItem
    {
        public static bool GetKeepSelectedIntoView(DependencyObject obj)
        {
            return (bool)obj.GetValue(KeepSelectedIntoViewProperty);
        }

        public static void SetKeepSelectedIntoView(DependencyObject obj, bool value)
        {
            obj.SetValue(KeepSelectedIntoViewProperty, value);
        }

        // Using a DependencyProperty as the backing store for KeepSelectedIntoView.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty KeepSelectedIntoViewProperty =
            DependencyProperty.RegisterAttached("KeepSelectedIntoView", typeof(bool), typeof(ListViewItem), new UIPropertyMetadata(OnPropertyChanged));

        public static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var listView = d as System.Windows.Controls.ListView;
            if (listView == null) return;

            if (ListViewItem.GetKeepSelectedIntoView(listView))
            {
                listView.AddHandler(System.Windows.Controls.ListView.SelectionChangedEvent, new RoutedEventHandler(OnSelectionChanged));
            }
            else
            {
                listView.RemoveHandler(System.Windows.Controls.ListView.SelectionChangedEvent, new RoutedEventHandler(OnSelectionChanged));
            }
        }

        private static void OnSelectionChanged(object sender, RoutedEventArgs args)
        {
            var listView = sender as System.Windows.Controls.ListView;
            listView.ScrollIntoView(listView.SelectedItem);
        }
    }
}
