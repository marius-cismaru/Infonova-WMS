using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Globalization;

namespace Sirius.EntityModels
{
    public partial class WarehouseContainer
    {
        public string CodeToString
        {
            get
            {
                string result = Name;
                if (result == string.Empty)
                {
                    result = WarehouseRow.WarehouseRoom.Code.ToString("0") + WarehouseRow.Code.ToString("00") + Interval.ToString("0") + Slot.ToString("0") + Floor.ToString("0");
                }
                return result;
            }
        }

        public string PackageExistingList
        {
            get
            {
                string result = "";
                var packageExistingList = from o in Packages
                                          where o.Delivery == null
                                          select o;
                if (packageExistingList.Count() > 0)
                {
                    result = string.Join(", ", packageExistingList);
                }
                return result;
            }
        }

        public string PackageExistingListWithQuantity
        {
            get
            {
                string result = "";

                var packageExistingList = from o in Packages
                                          where o.Delivery == null
                                          select (o.Code.Substring(0, 4) + Environment.NewLine + o.Code.Substring(4, 3) + Environment.NewLine + o.Quantity.ToString("0.00", CultureInfo.InvariantCulture));
                if (packageExistingList.Count() > 0)
                {
                    result = string.Join(", ", packageExistingList);
                }
                return result;
            }
        }

        public string LocationToString
        {
            get
            {
                return "Camera " + WarehouseRow.WarehouseRoom.Code.ToString("0") + ", randul " + WarehouseRow.Code.ToString("00") + ", intervalul " + Interval.ToString("0") + ", slotul " + Slot.ToString("0") + ", etajul " + Floor.ToString("0");
            }
        }

        public WarehouseContainer()
        {
            Interval = 1;
            Slot = 1;
            Floor = 1;
            Name = string.Empty;
            IsAvailable = true;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
