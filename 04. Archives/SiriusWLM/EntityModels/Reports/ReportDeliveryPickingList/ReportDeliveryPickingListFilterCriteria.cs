using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.Reports
{
	public class ReportDeliveryPickingListFilterCriteria
	{
        public Delivery Delivery { get; set; }
        public List<Package> PackageList { get; set; }

        public ReportDeliveryPickingListFilterCriteria()
		{
            Delivery = null;
            PackageList = new List<Package>();
		}

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            if (Delivery != null)
            {
                str.Append("Livrare: ");
                str.Append(Delivery.ToString());

                str.Append(", Client: ");
                str.Append(Delivery.Client.ToString());

                str.Append(", Depozit: ");
                str.Append(Delivery.Warehouse.ToString());
            }
            return str.ToString();
        }
	}
}
