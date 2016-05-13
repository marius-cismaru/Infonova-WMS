using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.CustomControls
{
    public class EntityCheckedListBox: System.Windows.Forms.CheckedListBox
    {
        public EntityCheckedListBox()
            : base()
        {
            SelectionMode = System.Windows.Forms.SelectionMode.One;
        }

        public void SetItems(List<EntityItem> items, List<int> selectedIds)
        {
            Items.Clear();
            Items.AddRange(items.ToArray());
            SetSelectedIds(selectedIds);
        }

        public List<int> GetSelectedIds()
        {
            List<int> selectedIds = new List<int>();

            if (SelectedItems.Count > 0)
            {
                foreach (var selectedItem in SelectedItems)
                {
                    var item = selectedItem as EntityItem;
                    if (item != null)
                    {
                        selectedIds.Add(item.Id);
                    }
                    
                }
            }

            return selectedIds;
        }

        public void SetSelectedIds(List<int> selectedIds)
        {
            if (selectedIds != null)
            {
                if ((selectedIds.Count > 0) && (SelectedItems.Count > 0))
                {
                    foreach (var id in selectedIds)
                    {
                        for(int i=0;i<Items.Count; i++)
                        {
                            var item = Items[i] as EntityItem;
                            if (item != null)
                            {
                                if (item.Id == id)
                                {
                                    SetSelected(i, true);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
