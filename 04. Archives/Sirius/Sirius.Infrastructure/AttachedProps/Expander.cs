using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Equistat.Infrastructure.Events;
using Equistat.Infrastructure.Services;
using Microsoft.Practices.Composite.Events;
using Microsoft.Practices.Unity;
using WpfExtensions.Converters;

namespace Equistat.Infrastructure.AttachedProps
{
    public static class Expander
    {
        public static bool GetEnableUserRights(DependencyObject obj)
        {
            return (bool)obj.GetValue(EnableUserRightsProperty);
        }

        public static void SetEnableUserRights(DependencyObject obj, bool value)
        {
            obj.SetValue(EnableUserRightsProperty, value);
        }

        // Using a DependencyProperty as the backing store for EnableUserRights.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EnableUserRightsProperty =
            DependencyProperty.RegisterAttached("EnableUserRights", typeof(bool), typeof(Expander), new UIPropertyMetadata(OnPropertyChanged));

        public static void OnPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var ex = obj as System.Windows.Controls.Expander;
            if (ex != null)
            {
                expanders.Add(ex);

                var unityContainer = Application.Current.Resources["Unity"] as UnityContainer;
                var eventAggregator = unityContainer.Resolve<IEventAggregator>();

                eventAggregator.GetEvent<LoginEvent>().Subscribe(OnLogin);
            }
        }

        private static List<System.Windows.Controls.Expander> expanders = new List<System.Windows.Controls.Expander>();
        private static void OnLogin(int userid)
        {
            var unityContainer = Application.Current.Resources["Unity"] as UnityContainer;
            var loginSvc = unityContainer.Resolve<ILoginSvc>();

            VisibilityConverter converter = new VisibilityConverter();

            foreach (var item in expanders)
            {
                string header = item.Header is TextBlock ? ((TextBlock)item.Header).Text : item.Header.ToString();

                bool canAccess = loginSvc.CanUserAccess(item.Header.ToString());
                item.Visibility = (Visibility)converter.Convert(canAccess, null, null, null);

                item.InvalidateVisual();
            }
        }
    }
}
