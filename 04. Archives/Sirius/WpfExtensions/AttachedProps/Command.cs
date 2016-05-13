using System.Windows;
using System.Windows.Controls;
using WpfExtensions.Util;

namespace WpfExtensions.AttachedProps
{
    public class Command
    {
        public static object GetParameter(DependencyObject obj)
        {
            return (object)obj.GetValue(ParameterProperty);
        }

        public static void SetParameter(DependencyObject obj, object value)
        {
            obj.SetValue(ParameterProperty, value);
        }

        public static readonly DependencyProperty ParameterProperty =
            DependencyProperty.RegisterAttached("Parameter", typeof(object), typeof(Command), new UIPropertyMetadata(null, ParameterChanged));

        private static void ParameterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var button = d as MenuItem;
            if (button == null)
            {
                return;
            }

            button.CommandParameter = e.NewValue;
            var cmd = button.Command as DelegateCommand<object>;
            if (cmd != null)
            {
                cmd.RaiseCanExecuteChanged();
            }
        }
    }
}
