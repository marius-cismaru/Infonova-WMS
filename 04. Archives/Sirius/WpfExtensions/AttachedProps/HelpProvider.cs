using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfExtensions.AttachedProps
{
    public static class HelpProvider
    {
        #region Properties
        public static string HelpNamespace { get; set; }
        //public static bool HelpEnabled { get; set; }
        //public static string NotFoundTopic { get; set; }
        #endregion Properties

        #region AttachedProperties
        //public static readonly DependencyProperty HelpEnabledProperty
        //   = DependencyProperty.RegisterAttached("HelpEnabled", typeof(bool), typeof(HelpProvider));
        //public static bool IsHelpEnabled(DependencyObject obj)
        //{
        //   return (bool)obj.GetValue(HelpProvider.HelpEnabledProperty);
        //}
        //public static void SetHelpEnabled(DependencyObject obj, bool value)
        //{
        //   obj.SetValue(HelpProvider.HelpEnabledProperty, value);
        //}

        //public static readonly DependencyProperty HelpMessageProperty
        //   = DependencyProperty.RegisterAttached("HelpMessage", typeof(string), typeof(HelpProvider));
        //public static string GetHelpMessage(DependencyObject obj)
        //{
        //   return (string)obj.GetValue(HelpProvider.HelpMessageProperty);
        //}
        //public static void SetHelpMessage(DependencyObject obj, string value)
        //{
        //   obj.SetValue(HelpProvider.HelpMessageProperty, value);
        //}

        public static readonly DependencyProperty HelpTopicProperty
           = DependencyProperty.RegisterAttached("HelpTopic", typeof(string), typeof(HelpProvider));
        public static string GetHelpTopic(DependencyObject obj)
        {
            return (string)obj.GetValue(HelpProvider.HelpTopicProperty);
        }
        public static void SetHelpTopic(DependencyObject obj, string value)
        {
            obj.SetValue(HelpProvider.HelpTopicProperty, value);
        }


        //public static readonly DependencyProperty HelpKeywordProperty
        //   = DependencyProperty.RegisterAttached("HelpKeyword", typeof(string), typeof(HelpProvider));
        //public static string GetHelpKeyword(DependencyObject obj)
        //{
        //   return (string)obj.GetValue(HelpProvider.HelpKeywordProperty);
        //}
        //public static void SetHelpKeyword(DependencyObject obj, string value)
        //{
        //   obj.SetValue(HelpProvider.HelpKeywordProperty, value);
        //}

        //public static readonly DependencyProperty HelpNavigatorProperty
        //   = DependencyProperty.RegisterAttached("HelpNavigator", typeof(HelpNavigator), typeof(HelpProvider),
        //                                         new PropertyMetadata(HelpNavigator.TableOfContents));
        //public static HelpNavigator GetHelpNavigator(DependencyObject obj)
        //{
        //   return (HelpNavigator)obj.GetValue(HelpProvider.HelpNavigatorProperty);
        //}
        //public static void SetHelpNavigator(DependencyObject obj, HelpNavigator value)
        //{
        //   obj.SetValue(HelpProvider.HelpNavigatorProperty, value);
        //}
        #endregion AttachedProperties

        static HelpProvider()
        {
            CommandManager.RegisterClassCommandBinding(typeof(FrameworkElement),
                                                       new CommandBinding(ApplicationCommands.Help, HelpProvider.OnHelpExecuted));
        }

        private static Form helpForm;

        private static void OnHelpExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(HelpProvider.HelpNamespace)
            || !File.Exists(HelpProvider.HelpNamespace))
            {
                return;
            }

            DependencyObject element = sender as DependencyObject;
            while (element != null)
            {
                //if (HelpProvider.IsHelpEnabled(element))
                {
                    //if (Control.MouseButtons != MouseButtons.None)
                    //{
                    //   string message = HelpProvider.GetHelpMessage(element);
                    //   if (!string.IsNullOrEmpty(message))
                    //   {
                    //      Point point = Mouse.GetPosition(Mouse.DirectlyOver);
                    //      Help.ShowPopup(null, message, Control.MousePosition);
                    //      e.Handled = true;
                    //      break;
                    //   }
                    //}

                    string topic = HelpProvider.GetHelpTopic(element);
                    if (!string.IsNullOrEmpty(topic))
                    {
                        if (helpForm == null)
                        {
                            helpForm = new Form();
                        }
                        Help.ShowHelp(helpForm, HelpProvider.HelpNamespace, HelpNavigator.Topic, topic);
                        e.Handled = true;
                        break;
                    }
                }
                element = VisualTreeHelper.GetParent(element);
            }

            if (!e.Handled)
            {
                Help.ShowHelp(null, HelpProvider.HelpNamespace);
                e.Handled = true;
            }
        }
    }
}
