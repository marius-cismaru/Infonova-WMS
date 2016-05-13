using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Sirius.EntityModels.WarehouseContainers
{
    public class WarehouseContainerLocation
    {
        public WarehouseContainer Container { get; set; }
        public Rectangle Location { get; set; }
        public bool IsEmpty { get; set; }
        public bool IsSelected { get; set; }
        public bool HasNewPackage { get; set; }

        public WarehouseContainerLocation()
        {
            Container = null;
            Location = new Rectangle(0, 0, 0, 0);
            IsSelected = false;
        }

        public void RenderOnGraphics(Graphics graphics)
        {
            Pen pen = Pens.Black;
            Brush brush = Brushes.White;
            if (IsSelected) brush = Brushes.GreenYellow;
            if (HasNewPackage) brush = Brushes.Yellow;
            if ((Container.WarehouseRow.IsLimited) && (!IsEmpty) && (!HasNewPackage)) brush = Brushes.AntiqueWhite;
            if (!Container.IsAvailable) brush = Brushes.LightGray;

            graphics.DrawRectangle(pen, Location);
            graphics.FillRectangle(brush, Location.X + 1, Location.Y + 1, Location.Width - 1, Location.Height - 1);
            Font fontPackageCode = new Font("Arial", 8);
            graphics.DrawString(Container.PackageExistingListWithQuantity, fontPackageCode, Brushes.Black, Location);
        }
    }
}