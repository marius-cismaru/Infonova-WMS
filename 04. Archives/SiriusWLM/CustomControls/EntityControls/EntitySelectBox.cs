using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.CustomControls
{
    public class EntitySelectBox: System.Windows.Forms.ComboBox
    {
        public EntitySelectBox()
            : base()
        {
            DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        public void SetItems(List<EntityItem> items, int selectedId, bool showOptionAll)
        {
            Items.Clear();
            if (showOptionAll)
            {
                Items.Add(new EntityItem(0, "- Tot - "));
            }
            Items.AddRange(items.ToArray());
            SetSelectedId(selectedId);
        }

        public int GetSelectedId()
        {
            int selectedId = 0;

            if (SelectedItem != null)
            {
                var item = SelectedItem as EntityItem;
                if (item != null)
                {
                    selectedId = item.Id;
                }
            }

            return selectedId;
        }

        public void SetSelectedId(int selectedId)
        {
            if (Items.Count > 0)
            {
                if (selectedId > 0)
                {
                    bool itemFound = false;
                    foreach (EntityItem item in Items)
                    {
                        if (item.Id == selectedId)
                        {
                            SelectedItem = item;
                            itemFound = true;
                        }
                    }
                    if (!itemFound)
                    {
                        SelectedIndex = 0;
                    }
                }
                else
                {
                    SelectedIndex = 0;
                }
            }
        }
    }
}
