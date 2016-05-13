using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.Reports
{
	public class ReportReceptionsFilterCriteria
	{
        public int CompanyId { get; set; }
        public int ClientId { get; set; }
        public int WarehouseId { get; set; }
        public int ProductId { get; set; }
        public int ReceptionNumber { get; set; }
        public int DeliveryNumber { get; set; }
        public DateTime? DateExecutionBegin { get; set; }
        public DateTime? DateExecutionEnd { get; set; }

        public ReportReceptionsFilterCriteria()
		{
            ClientId = 0;
            CompanyId = 0;
            WarehouseId = 0;
            DateExecutionBegin = CommonLibs.DatesLib.GetFirstDayOfMonth();
            DateExecutionEnd = null;
            ReceptionNumber = 0;
            DeliveryNumber = 0;
		}

        public string ToString(EntityModelSirius model)
        {
            StringBuilder str = new StringBuilder();
            str.Append("Data: ");
            if ((DateExecutionBegin.HasValue) && (DateExecutionEnd.HasValue))
            {
                str.Append("Intre " + DateExecutionBegin.Value.ToString("dd.MM.yyyy") + " si " + DateExecutionEnd.Value.ToString("dd.MM.yyyy"));
            }
            else
            {
                if (DateExecutionBegin.HasValue)
                {
                    str.Append("Din " + DateExecutionBegin.Value.ToString("dd.MM.yyyy"));
                }
                else
                {
                    if (DateExecutionEnd.HasValue)
                    {
                        str.Append("Pana in " + DateExecutionEnd.Value.ToString("dd.MM.yyyy"));
                    }
                    else
                    {
                        str.Append("Toate");
                    }
                }
            }
            str.Append(", Client: ");
            if (ClientId <= 0)
            {
                str.Append("Toti");
            }
            else
            {
                var client = Clients.ClientCollection.GetById(model, ClientId, false);
                str.Append(client != null ? client.ToString() : "-");
            }

            str.Append(", Depozit: ");
            if (WarehouseId <= 0)
            {
                str.Append("Toate");
            }
            else
            {
                var warehouse = Warehouses.WarehouseCollection.GetById(model, WarehouseId, false);
                str.Append(warehouse != null ? warehouse.ToString() : "-");
            }

            str.Append(", Articol: ");
            if (ProductId <= 0)
            {
                str.Append("Toate");
            }
            else
            {
                var product = Products.ProductCollection.GetById(model, ProductId, false);
                str.Append(product != null ? product.ToString() : "-");
            }
            if (DeliveryNumber > 0)
            {

                str.Append(", Livrare nr.: " + DeliveryNumber.ToString());
            }
            if (ReceptionNumber > 0)
            {

                str.Append(", Receptie nr.: " + ReceptionNumber.ToString());
            }

            return str.ToString();
        }
    }
}
