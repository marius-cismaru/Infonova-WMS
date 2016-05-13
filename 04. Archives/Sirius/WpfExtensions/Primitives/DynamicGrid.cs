using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfExtensions.Primitives
{
    public class DynamicGrid : Grid
    {
        public int Columns
        {
            get { return (int)GetValue(ColumnsProperty); }
            set { SetValue(ColumnsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Columns.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ColumnsProperty =
            DependencyProperty.Register("Columns", typeof(int), typeof(DynamicGrid), new UIPropertyMetadata(OnPropertyChanged));

        public int Rows
        {
            get { return (int)GetValue(RowsProperty); }
            set { SetValue(RowsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Rows.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RowsProperty =
            DependencyProperty.Register("Rows", typeof(int), typeof(DynamicGrid), new UIPropertyMetadata(OnPropertyChanged));

        public new bool ShowGridLines
        {
            get { return (bool)GetValue(ShowGridLinesProperty); }
            set { SetValue(ShowGridLinesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ShowGridLines.  This enables animation, styling, binding, etc...
        public static readonly new DependencyProperty ShowGridLinesProperty =
            DependencyProperty.Register("ShowGridLines", typeof(bool), typeof(DynamicGrid), new UIPropertyMetadata(OnPropertyChanged));

        public Brush GridLinesColor
        {
            get { return (Brush)GetValue(GridLinesColorProperty); }
            set { SetValue(GridLinesColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for GridLinesColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GridLinesColorProperty =
            DependencyProperty.Register("GridLinesColor", typeof(Brush), typeof(DynamicGrid), new UIPropertyMetadata(OnPropertyChanged));

        private static void OnPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            (obj as DynamicGrid).RecreateGridCells();
        }

        private void RecreateGridCells()
        {
            int numRows = this.Rows;
            int currentNumRows = this.RowDefinitions.Count;

            while (numRows > currentNumRows)
            {
                this.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                currentNumRows++;
            }
            while (numRows < currentNumRows)
            {
                currentNumRows--;
                this.RowDefinitions.RemoveAt(currentNumRows);
            }

            int numCols = this.Columns;
            int currentNumCols = this.ColumnDefinitions.Count;

            while (numCols > currentNumCols)
            {
                this.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                currentNumCols++;
            }
            while (numCols < currentNumCols)
            {
                currentNumCols--;
                this.ColumnDefinitions.RemoveAt(currentNumCols);
            }

            this.UpdateLayout();
            this.InvalidateVisual();
        }

        protected override void OnRender(DrawingContext dc)
        {
            base.OnRender(dc);
            if (this.ShowGridLines)
            {
                Pen line = new Pen(this.GridLinesColor, 1);
                base.OnRender(dc);
                dc.DrawRectangle(null, line, new Rect(0, 0, this.ActualWidth, this.ActualHeight));
                double height = 0;
                foreach (var r in this.RowDefinitions)
                {
                    height += r.ActualHeight;
                    dc.DrawLine(line, new Point(0, height), new Point(this.ActualWidth, height));
                }
                double width = 0;
                foreach (var c in this.ColumnDefinitions)
                {
                    width += c.ActualWidth;
                    dc.DrawLine(line, new Point(width, this.ActualHeight), new Point(width, 0));
                }
            }
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            this.RecreateGridCells();
        }
    }
}
