using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sirius.CustomControls
{
	public partial class TreeViewMenu: TreeView
	{
        public TreeViewMenu()
            : base()
        {
            ItemHeight = 25;
            ImageList = new ImageList();
            ImageList.Images.Add(global::Sirius.CustomControls.Properties.Resources.icon_16_win_folder_close);
            ImageList.Images.Add(global::Sirius.CustomControls.Properties.Resources.icon_16_win_folder_open);
            ImageList.Images.Add(global::Sirius.CustomControls.Properties.Resources.icon_16_win_document_empty);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (GetNodeAt(e.X, e.Y) != null)
            {
                Cursor = Cursors.Hand;
            }
            else
            {
                Cursor = Cursors.Default;
            }

            base.OnMouseMove(e);
        }

        protected override void OnNodeMouseClick(TreeNodeMouseClickEventArgs e)
        {
            e.Node.Toggle();
            SelectedNode = e.Node;

            base.OnNodeMouseClick(e);
        }
	}
}
