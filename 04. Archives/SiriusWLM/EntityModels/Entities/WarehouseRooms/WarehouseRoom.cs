using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels
{
    public partial class WarehouseRoom
    {
        public string RowList
        {
            get
            {
                string result = "(0)";
                if (WarehouseRows.Count > 0)
                {
                    result = "(" + WarehouseRows.Count.ToString() + ") - " + string.Join(", ", WarehouseRows);
                }
                return result;
            }
        }

        public WarehouseRoom()
        {
            Id = 0;
            Code = 1;
        }

        public int WarehouseContainersCountVacant
        {
            get
            {
                int result = 0;
                using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
                {
                    result = model.WarehouseContainers.Where(o => o.WarehouseRow.WarehouseRoom.Id == Id && o.IsAvailable && ((!o.WarehouseRow.IsLimited) || ((o.WarehouseRow.IsLimited) && (o.Packages.All(p => p.Delivery != null))))).Count();
                }
                return result;
            }
        }

        public override string ToString()
        {
            return Code.ToString();
        }
    }
}
