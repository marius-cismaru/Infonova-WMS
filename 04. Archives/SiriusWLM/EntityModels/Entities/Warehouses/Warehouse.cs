using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels
{
    public partial class Warehouse
    {
        public string RoomList
        {
            get
            {
                string result = "";
                if (WarehouseRooms.Count > 0)
                {
                    result = string.Join(", ", WarehouseRooms);
                }
                return result;
            }
        }

        public Warehouse()
        {
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
