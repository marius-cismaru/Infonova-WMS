using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace WpfExtensions.AttachedProps
{
    public static class TextBox
    {
        public static bool GetSelectAllOnFocus(DependencyObject obj)
        {
            return (bool)obj.GetValue(SelectAllOnFocusProperty);
        }

        public static void SetSelectAllOnFocus(DependencyObject obj, bool value)
        {
            obj.SetValue(SelectAllOnFocusProperty, value);
        }

        // Using a DependencyProperty as the backing store for SelectAllOnFocus.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectAllOnFocusProperty =
            DependencyProperty.RegisterAttached("SelectAllOnFocus", typeof(bool), typeof(TextBox), new UIPropertyMetadata(false, OnPropertyChanged));

        private static void OnPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var textbox = sender as System.Windows.Controls.TextBox;

            if (textbox != null)
            {
                if ((bool)e.NewValue)
                {
                    textbox.GotKeyboardFocus += OnKeyboardFocusSelectText;
                    textbox.PreviewMouseLeftButtonDown += OnMouseLeftButtonDownSetFocus;
                }
                else
                {
                    textbox.GotKeyboardFocus -= OnKeyboardFocusSelectText;
                    textbox.PreviewMouseLeftButtonDown -= OnMouseLeftButtonDownSetFocus;
                }
            }
        }

        private static void OnKeyboardFocusSelectText(object sender, KeyboardFocusChangedEventArgs e)
        {
            var textBox = e.OriginalSource as System.Windows.Controls.TextBox;
            if (textBox != null)
            {
                textBox.SelectAll();
            }
        }

        private static void OnMouseLeftButtonDownSetFocus(object sender, MouseButtonEventArgs e)
        {
            var textBox = e.Source as System.Windows.Controls.TextBox;

            if (textBox == null)
                return;

            if (!textBox.IsKeyboardFocusWithin)
            {
                textBox.Focus();
                e.Handled = true;
            }
        }
    }
}