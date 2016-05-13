using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.EntityModel;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels
{
    public partial class WarehouseRow
    {
        public WarehouseRow()
        {
            Id = 0;
            IsInverted = false;
            IsLimited = true;
            Code = 1;
        }

        public string PackagesPerClientToString
        {
            get
            {
                List<string> result = new List<string>();

                using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
                {

                    var packageList = from o in model.Packages
                                      where (o.WarehouseContainer.WarehouseRow.Id == Id) && (o.Delivery == null)
                                      group o by o.Reception.Client into p
                                      orderby p.Key.NameShort
                                      select new
                                      {
                                          ClientRef = p.Key,
                                          PackageCount = p.Count()
                                      };

                    foreach (var obj in packageList.ToList())
                    {
                        result.Add(obj.ClientRef.ToString() + ": " + obj.PackageCount.ToString());
                    }
                }

                return string.Join(", ", result);
            }
        }

        public int WarehouseContainersCountVacant
        {
            get
            {
                int result = 0;
                using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
                {
                    result = model.WarehouseContainers.Where(o => o.WarehouseRow.Id == Id && o.IsAvailable && ((!IsLimited) || ((IsLimited) && (o.Packages.All(p => p.Delivery != null))))).Count();
                }
                return result;
            }
        }

        public override string ToString()
        {
            return Code.ToString() + (IsInverted ? "*" : "");
        }
    }
}
