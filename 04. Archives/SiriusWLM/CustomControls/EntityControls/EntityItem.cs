using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.CustomControls
{
    public class EntityItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public EntityItem()
        {
            Name = "";
            Id = 0;
        }

        public EntityItem(int id, string name)
        {
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
