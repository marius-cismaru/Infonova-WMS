using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.ComponentModel;
using System.Drawing;

namespace Sirius.CustomControls
{
    public class EntityGridView : DataGridView
    {
        [Category("Custom")]
        [Description("Displays a message in the DataGridView when no records are displayed in it.")]
        [DefaultValue(typeof(string), "")]
        public string EmptyDataText { get; set; }

        protected override void PaintBackground(Graphics graphics, Rectangle clipBounds, Rectangle gridBounds)
        {
            RectangleF ef;
            base.PaintBackground(graphics, clipBounds, gridBounds);
            if ((this.Enabled && (this.RowCount == 0)) && (this.EmptyDataText.Length > 0))
            {
                string emptyText = this.EmptyDataText;
                ef = new RectangleF(4f, (float)(this.ColumnHeadersHeight + 4), (float)(this.Width - 8), (float)((this.Height - this.ColumnHeadersHeight) - 8));
                graphics.DrawString(emptyText, this.Font, Brushes.Black, ef);
            }
        }

        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            //this method overrides the DataGridView's RowPostPaint event 
            //in order to automatically draw numbers on the row header cells
            //and to automatically adjust the width of the column containing
            //the row header cells so that it can accommodate the new row
            //numbers,

            //store a string representation of the row number in 'strRowNumber'
            string strRowNumber = (e.RowIndex + 1).ToString();

            //prepend leading zeros to the string if necessary to improve
            //appearance. For example, if there are ten rows in the grid,
            //row seven will be numbered as "07" instead of "7". Similarly, if 
            //there are 100 rows in the grid, row seven will be numbered as "007".
            while (strRowNumber.Length < this.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

            //determine the display size of the row number string using
            //the DataGridView's current font.
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);

            //adjust the width of the column that contains the row header cells 
            //if necessary
            if (this.RowHeadersWidth < (int)(size.Width + 20)) this.RowHeadersWidth = (int)(size.Width + 20);

            //this brush will be used to draw the row number string on the
            //row header cell using the system's current ControlText color
            Brush b = SystemBrushes.ControlText;

            //draw the row number string on the current row header cell using
            //the brush defined above and the DataGridView's default font
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

            //call the base object's OnRowPostPaint method
            base.OnRowPostPaint(e);
            //end OnRowPostPaint method
        }

        public EntityGridView()
            : base()
        {
            EmptyDataText = "Nu exista inregistrari";
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RowHeadersVisible = true;
            //MultiSelect = false;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //perform any necessary customization initialization here
            //end default constructor
        }

        public void SetCustomColumns(GridViewColumn[] customColumns)
        {
            if (Columns.Count == 0)
            {
                DataGridViewTextBoxColumn columnNew;
                Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Id",
                    Width = 20,
                    Visible = false,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                });
                DataGridViewContentAlignment align;
                DataGridViewAutoSizeColumnMode autoSizeMode;
                foreach (var column in customColumns)
                {
                    align = DataGridViewContentAlignment.MiddleCenter;
                    autoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                    switch (column.Align.ToUpper())
                    {
                        case ("L"): align = DataGridViewContentAlignment.MiddleLeft; break;
                        case ("R"): align = DataGridViewContentAlignment.MiddleRight; break;
                        case ("C"): align = DataGridViewContentAlignment.MiddleCenter; break;
                    }
                    if (column.IsAutoSizeModeFill)
                    {
                        autoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    columnNew = new DataGridViewTextBoxColumn
                    {
                        HeaderText = column.Name,
                        Width = column.Width,
                        MinimumWidth = column.Width,
                        DefaultCellStyle = new DataGridViewCellStyle { Alignment = align },
                        AutoSizeMode = autoSizeMode
                    };
                    if (column.IsAutoSizeModeFill)
                    {
                        columnNew.MinimumWidth = columnNew.Width;
                    }
                    Columns.Add(columnNew);
                }
            }
        }

        public void SetItems(List<string[]> items)
        {
            int currentId = GetSelectedId();
            Rows.Clear();
            foreach (var item in items)
            {
                Rows.Add(item);
            }
            SetSelectedId(currentId);
        }

        public int GetSelectedId()
        {
            int id = 0;

            if (SelectedCells.Count > 0)
            {
                int.TryParse(SelectedCells[0].Value.ToString(), out id);
            }

            return id;
        }

        public List<int> GetSelectedIdList()
        {
            List<int> result = new List<int>();
            int id;
            if (SelectedRows.Count > 0)
            {
                for (int i = 0; i < SelectedRows.Count; i++)
                {
                    int.TryParse(SelectedRows[i].Cells[0].Value.ToString(), out id);
                    result.Add(id);
                }
            }

            return result;
        }

        public void SetSelectedId(int id)
        {
            int tempId;
            for (int i = 0; i < Rows.Count; i++)
            {
                int.TryParse(Rows[i].Cells[0].Value.ToString(), out tempId);
                if (tempId == id)
                {
                    if (Rows[i].Cells.Count > 1)
                    {
                        CurrentCell = Rows[i].Cells[1];
                    }
                }
            }
        }
    }

	public class GridViewColumn
	{
		public string Name { get; set; }

		public int Width { get; set; }

		public string Align { get; set; }

        public bool IsAutoSizeModeFill { get; set; }

		public GridViewColumn()
		{
			Name = "";
			Width = -1;
			Align = "";
            IsAutoSizeModeFill = false;
		}

		public GridViewColumn(string name)
		{
			Name = name;
			Width = -1;
			Align = "";
            IsAutoSizeModeFill = false;
		}

        public GridViewColumn(string name, int width, string align)
        {
            Name = name;
            Width = width;
            Align = align;
            IsAutoSizeModeFill = false;
        }

		public GridViewColumn(string name, int width, string align, bool isAutoSizeModeFill)
		{
			Name = name;
			Width = width;
			Align = align;
            IsAutoSizeModeFill = isAutoSizeModeFill;
		}
	}
}
