using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.Reports
{
	public class ReportStockPackagesFilterCriteria
	{
        public int CompanyId { get; set; }
        public int ClientId { get; set; }
        public int WarehouseId { get; set; }
        public int ProductId { get; set; }
        public DateTime DateExecution { get; set; }
        public int ReceptionNumber { get; set; }

        public ReportStockPackagesFilterCriteria()
		{
            ClientId = 0;
            CompanyId = 0;
            WarehouseId = 0;
            DateExecution = DateTime.Now;
            ReceptionNumber = 0;
		}

        public string ToString(EntityModelSirius model)
        {
            StringBuilder str = new StringBuilder();
            //str.Append("Data: ");
            //str.Append(DateExecution.ToString("dd.MM.yyyy"));

            //str.Append(", Client: ");
            str.Append("Client: ");
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
            if (ReceptionNumber > 0)
            {

                str.Append(", Receptie: " + ReceptionNumber.ToString());
            }

            return str.ToString();
        }
    }
}
