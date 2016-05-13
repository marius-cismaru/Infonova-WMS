using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.ComponentModel;
using SysGridViewColumnHeader = System.Windows.Controls.GridViewColumnHeader;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Documents;

namespace WpfExtensions.AttachedProps
{
    public class GridView
    {
        #region Public attached properties

        public static ICommand GetCommand(DependencyObject obj)
        {
            return (ICommand)obj.GetValue(CommandProperty);
        }

        public static void SetCommand(DependencyObject obj, ICommand value)
        {
            obj.SetValue(CommandProperty, value);
        }

        // Using a DependencyProperty as the backing store for Command.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.RegisterAttached(
                "Command",
                typeof(ICommand),
                typeof(GridView),
                new UIPropertyMetadata(
                    null,
                    (o, e) =>
                    {
                        ItemsControl listView = o as ItemsControl;
                        if (listView != null)
                        {
                            if (!GetAutoSort(listView)) // Don't change click handler if AutoSort enabled
                            {
                                if (e.OldValue != null && e.NewValue == null)
                                {
                                    listView.RemoveHandler(SysGridViewColumnHeader.ClickEvent, new RoutedEventHandler(ColumnHeader_Click));
                                }
                                if (e.OldValue == null && e.NewValue != null)
                                {
                                    listView.AddHandler(SysGridViewColumnHeader.ClickEvent, new RoutedEventHandler(ColumnHeader_Click));
                                }
                            }
                        }
                    }
                )
            );

        public static bool GetIsSortContainer(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsSortContainerProperty);
        }

        public static void SetIsSortContainer(DependencyObject obj, bool value)
        {
            obj.SetValue(IsSortContainerProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsSortContainer.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsSortContainerProperty =
            DependencyProperty.RegisterAttached("IsSortContainer", typeof(bool), typeof(GridView), new UIPropertyMetadata(false));

        public static bool GetAutoSort(DependencyObject obj)
        {
            return (bool)obj.GetValue(AutoSortProperty);
        }

        public static void SetAutoSort(DependencyObject obj, bool value)
        {
            obj.SetValue(AutoSortProperty, value);
        }

        // Using a DependencyProperty as the backing store for AutoSort.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AutoSortProperty =
            DependencyProperty.RegisterAttached(
                "AutoSort",
                typeof(bool),
                typeof(GridView),
                new UIPropertyMetadata(
                    false,
                    (o, e) =>
                    {
                        var sortContainer = o as System.Windows.FrameworkElement;
                        if (sortContainer != null)
                        {
                            if (GetCommand(sortContainer) == null) // Don't change click handler if a command is set
                            {
                                bool oldValue = (bool)e.OldValue;
                                bool newValue = (bool)e.NewValue;
                                if (oldValue && !newValue)
                                {
                                    sortContainer.RemoveHandler(SysGridViewColumnHeader.ClickEvent, new RoutedEventHandler(ColumnHeader_Click));
                                }
                                if (!oldValue && newValue)
                                {
                                    sortContainer.AddHandler(SysGridViewColumnHeader.ClickEvent, new RoutedEventHandler(ColumnHeader_Click));
                                }
                            }
                        }
                    }
                )
            );

        public static string GetPropertyName(DependencyObject obj)
        {
            return (string)obj.GetValue(PropertyNameProperty);
        }

        public static void SetPropertyName(DependencyObject obj, string value)
        {
            obj.SetValue(PropertyNameProperty, value);
        }

        // Using a DependencyProperty as the backing store for PropertyName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PropertyNameProperty =
            DependencyProperty.RegisterAttached(
                "PropertyName",
                typeof(string),
                typeof(GridView),
                new UIPropertyMetadata(null)
            );

        public static bool GetShowSortGlyph(DependencyObject obj)
        {
            return (bool)obj.GetValue(ShowSortGlyphProperty);
        }

        public static void SetShowSortGlyph(DependencyObject obj, bool value)
        {
            obj.SetValue(ShowSortGlyphProperty, value);
        }

        // Using a DependencyProperty as the backing store for ShowSortGlyph.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowSortGlyphProperty =
            DependencyProperty.RegisterAttached("ShowSortGlyph", typeof(bool), typeof(GridView), new UIPropertyMetadata(true));

        public static ImageSource GetSortGlyphAscending(DependencyObject obj)
        {
            return (ImageSource)obj.GetValue(SortGlyphAscendingProperty);
        }

        public static void SetSortGlyphAscending(DependencyObject obj, ImageSource value)
        {
            obj.SetValue(SortGlyphAscendingProperty, value);
        }

        // Using a DependencyProperty as the backing store for SortGlyphAscending.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SortGlyphAscendingProperty =
            DependencyProperty.RegisterAttached("SortGlyphAscending", typeof(ImageSource), typeof(GridView), new UIPropertyMetadata(null));

        public static ImageSource GetSortGlyphDescending(DependencyObject obj)
        {
            return (ImageSource)obj.GetValue(SortGlyphDescendingProperty);
        }

        public static void SetSortGlyphDescending(DependencyObject obj, ImageSource value)
        {
            obj.SetValue(SortGlyphDescendingProperty, value);
        }

        // Using a DependencyProperty as the backing store for SortGlyphDescending.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SortGlyphDescendingProperty =
            DependencyProperty.RegisterAttached("SortGlyphDescending", typeof(ImageSource), typeof(GridView), new UIPropertyMetadata(null));

        #endregion

        #region Private attached properties

        private static SysGridViewColumnHeader GetSortedColumnHeader(DependencyObject obj)
        {
            return (SysGridViewColumnHeader)obj.GetValue(SortedColumnHeaderProperty);
        }

        private static void SetSortedColumnHeader(DependencyObject obj, SysGridViewColumnHeader value)
        {
            obj.SetValue(SortedColumnHeaderProperty, value);
        }

        // Using a DependencyProperty as the backing store for SortedColumn.  This enables animation, styling, binding, etc...
        private static readonly DependencyProperty SortedColumnHeaderProperty =
            DependencyProperty.RegisterAttached("SortedColumnHeader", typeof(SysGridViewColumnHeader), typeof(GridView), new UIPropertyMetadata(null));

        public static SortDescription? GetCurrentSortDirection(DependencyObject obj)
        {
            return (SortDescription?)obj.GetValue(CurrentSortDirectionProperty);
        }

        public static void SetCurrentSortDirection(DependencyObject obj, SortDescription? value)
        {
            obj.SetValue(CurrentSortDirectionProperty, value);
        }

        // Using a DependencyProperty as the backing store for CurrentSortDirection.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentSortDirectionProperty =
            DependencyProperty.RegisterAttached("CurrentSortDirection", typeof(SortDescription?), typeof(GridView), new UIPropertyMetadata(null));

        #endregion

        #region Column header click event handler

        private static void ColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            SysGridViewColumnHeader headerClicked = e.OriginalSource as SysGridViewColumnHeader;
            if (headerClicked != null && headerClicked.Column != null)
            {
                string propertyName = GetPropertyName(headerClicked.Column);
                if (!string.IsNullOrEmpty(propertyName))
                {
                    var sortContainer = GetSortContainer(headerClicked);
                    if (sortContainer != null)
                    {
                        ICommand command = GetCommand(sortContainer);
                        SortDescription? sortDir = GetCurrentSortDirection(sortContainer);
                        if (sortDir == null || sortDir.Value.PropertyName != propertyName)
                        {
                            SetCurrentSortDirection(sortContainer, sortDir = new SortDescription(propertyName, ListSortDirection.Ascending));
                        }
                        else if (sortDir.Value.Direction == ListSortDirection.Ascending)
                        {
                            SetCurrentSortDirection(sortContainer, sortDir = new SortDescription(propertyName, ListSortDirection.Descending));
                        }
                        else
                        {
                            SetCurrentSortDirection(sortContainer, sortDir = null);
                        }

                        if (command != null)
                        {
                            if (command.CanExecute(sortDir))
                            {
                                command.Execute(sortDir);
                            }
                            ApplyGlyph(sortContainer, sortDir, headerClicked);
                        }
                        else if (GetAutoSort(sortContainer) && (sortContainer is System.Windows.Controls.ListView))
                        {
                            var listView = sortContainer as System.Windows.Controls.ListView;
                            ApplySort(listView.Items, propertyName, listView, headerClicked);
                        }
                    }
                }
            }
        }

        #endregion

        #region Helper methods

        public static FrameworkElement GetSortContainer(FrameworkElement reference)
        {
            DependencyObject parent = VisualTreeHelper.GetParent(reference);
            while (!(parent is System.Windows.Controls.ListView) && (parent != null && !GetIsSortContainer(parent)))
            {
                parent = VisualTreeHelper.GetParent(parent);
            }
            if (parent != null && (GetIsSortContainer(parent) || parent is System.Windows.Controls.ListView))
            {
                return (FrameworkElement)parent;
            }
            else
            {
                return null;
            }
        }

        public static void ApplyGlyph(DependencyObject container, SortDescription? sortDesc, SysGridViewColumnHeader sortedColumnHeader)
        {
            SysGridViewColumnHeader currentSortedColumnHeader = GetSortedColumnHeader(container);
            if (currentSortedColumnHeader != null)
            {
                RemoveSortGlyph(currentSortedColumnHeader);
            }

            if (GetShowSortGlyph(container) && sortedColumnHeader != null && sortDesc != null)
                AddSortGlyph(
                    sortedColumnHeader,
                    sortDesc.Value.Direction,
                    sortDesc.Value.Direction == ListSortDirection.Ascending ?
                      GetSortGlyphAscending(container) :
                      GetSortGlyphDescending(container));

            SetSortedColumnHeader(container, sortedColumnHeader);
        }

        public static void ApplySort(ICollectionView view, string propertyName, System.Windows.Controls.ListView listView, SysGridViewColumnHeader sortedColumnHeader)
        {
            ListSortDirection direction = ListSortDirection.Ascending;
            SortDescription? sortDesc = null;
            if (view.SortDescriptions.Count > 0)
            {
                SortDescription currentSort = view.SortDescriptions[0];
                if (currentSort.PropertyName == propertyName)
                {
                    if (currentSort.Direction == ListSortDirection.Ascending)
                        direction = ListSortDirection.Descending;
                    else
                        direction = ListSortDirection.Ascending;
                }
                view.SortDescriptions.Clear();
            }
            if (!string.IsNullOrEmpty(propertyName))
            {
                sortDesc = new SortDescription(propertyName, direction);
                view.SortDescriptions.Add(sortDesc.Value);
            }
            ApplyGlyph(listView, sortDesc, sortedColumnHeader);
        }

        private static void AddSortGlyph(SysGridViewColumnHeader columnHeader, ListSortDirection direction, ImageSource sortGlyph)
        {
            AdornerLayer adornerLayer = AdornerLayer.GetAdornerLayer(columnHeader);
            adornerLayer.Add(
                new SortGlyphAdorner(
                    columnHeader,
                    direction,
                    sortGlyph
                    ));
        }

        private static void RemoveSortGlyph(SysGridViewColumnHeader columnHeader)
        {
            AdornerLayer adornerLayer = AdornerLayer.GetAdornerLayer(columnHeader);
            Adorner[] adorners = adornerLayer.GetAdorners(columnHeader);
            if (adorners != null)
            {
                foreach (Adorner adorner in adorners)
                {
                    if (adorner is SortGlyphAdorner)
                        adornerLayer.Remove(adorner);
                }
            }
        }

        #endregion

        #region SortGlyphAdorner nested class

        private class SortGlyphAdorner : Adorner
        {
            private SysGridViewColumnHeader _columnHeader;
            private ListSortDirection _direction;
            private ImageSource _sortGlyph;

            public SortGlyphAdorner(SysGridViewColumnHeader columnHeader, ListSortDirection direction, ImageSource sortGlyph)
                : base(columnHeader)
            {
                _columnHeader = columnHeader;
                _direction = direction;
                _sortGlyph = sortGlyph;
            }

            private Geometry GetDefaultGlyph()
            {
                double x1 = _columnHeader.ActualWidth - 20;
                double x2 = x1 + 10;
                double x3 = x1 + 5;
                double y1 = _columnHeader.ActualHeight / 2 - 3;
                double y2 = y1 + 5;

                if (_direction == ListSortDirection.Ascending)
                {
                    double tmp = y1;
                    y1 = y2;
                    y2 = tmp;
                }

                PathSegmentCollection pathSegmentCollection = new PathSegmentCollection();
                pathSegmentCollection.Add(new LineSegment(new Point(x2, y1), true));
                pathSegmentCollection.Add(new LineSegment(new Point(x3, y2), true));

                PathFigure pathFigure = new PathFigure(
                    new Point(x1, y1),
                    pathSegmentCollection,
                    true);

                PathFigureCollection pathFigureCollection = new PathFigureCollection();
                pathFigureCollection.Add(pathFigure);

                PathGeometry pathGeometry = new PathGeometry(pathFigureCollection);
                return pathGeometry;
            }

            protected override void OnRender(DrawingContext drawingContext)
            {
                base.OnRender(drawingContext);

                if (_sortGlyph != null)
                {
                    double x = _columnHeader.ActualWidth - 20;
                    double y = _columnHeader.ActualHeight / 2 - 5;
                    Rect rect = new Rect(x, y, 10, 10);
                    drawingContext.DrawImage(_sortGlyph, rect);
                }
                else
                {
                    drawingContext.DrawGeometry(Brushes.Gray, new Pen(Brushes.Gray, 1.0), GetDefaultGlyph());
                }
            }
        }

        #endregion
    }
}
