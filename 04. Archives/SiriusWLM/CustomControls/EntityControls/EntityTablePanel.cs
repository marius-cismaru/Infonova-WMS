using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Sirius.CustomControls
{
	public partial class EntityTablePanel: TablePanel
	{
        public EntityTablePanel()
            : base()
        {
            //AutoScroll = true;
            SetStyle(ControlStyles.Selectable, true);
        }

        protected override void OnCellPaint(TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == 0)
            {
                Graphics g = e.Graphics;
                Rectangle r = e.CellBounds;
                g.FillRectangle(Brushes.LightGray, r);
            }
            base.OnCellPaint(e);
        }
	}
}
