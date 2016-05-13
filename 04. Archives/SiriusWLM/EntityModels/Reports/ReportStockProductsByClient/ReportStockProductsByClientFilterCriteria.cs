using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Sirius.EntityModels.Reports
{
    public class ReportStockProductsByClientFilterCriteria
    {
        public int ClientId { get; set; }
        public DateTime DateExecution { get; set; }

        public ReportStockProductsByClientFilterCriteria()
        {
            ClientId = 0;
            DateExecution = DateTime.Now;
        }

        public string ToString(EntityModelSirius model)
        {
            StringBuilder str = new StringBuilder();

            var client = Clients.ClientCollection.GetById(model, ClientId, false);
            str.Append(client != null ? client.NameShort : string.Empty);

            str.Append("_");
            str.Append(DateExecution.ToString("yyyy-MM-dd"));

            return str.ToString();
        }
    }
}
