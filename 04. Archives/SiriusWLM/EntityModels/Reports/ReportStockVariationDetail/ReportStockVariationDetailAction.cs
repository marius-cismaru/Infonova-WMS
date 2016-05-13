using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.EntityModels.Reports
{
    public class ReportStockVariationDetailAction
    {
        public DateTime DateExecution { get; set; }
        public int PackageCountCurrent {get;set;}
        public int PackageCountVariationIn { get; set; }
        public int PackageCountVariationOut { get; set; }
        public double WeightNetCurrent { get; set; }
        public double WeightNetVariationIn { get; set; }
        public double WeightNetVariationOut { get; set; }
        public double WeightGrossCurrent { get; set; }
        public double WeightGrossVariationIn { get; set; }
        public double WeightGrossVariationOut { get; set; }
        public List<string> Receptions { get; set; }
        public List<string> Deliveries { get; set; }
        public string ReceptionDeliveryClientSymbol { get; set; }
        public int ReceptionDeliveryNumber { get; set; }

        public string ReceptionsDeliveriesToString
        {
            get
            {
                string result = string.Empty;
                result = Receptions.Count > 0 ? ("Receptii: " + string.Join(", ", Receptions)) : string.Empty;
                if (Deliveries.Count > 0)
                {
                    if (result != string.Empty)
                    {
                        result += " - Livrari: ";
                    }
                    else
                    {
                        result = "Livrari: ";
                    }
                    result += string.Join(", ", Deliveries);
                }
                return result;
            }
        }

        public ReportStockVariationDetailAction()
        {
            DateExecution = DateTime.Now;
            PackageCountCurrent = 0;
            PackageCountVariationIn = 0;
            PackageCountVariationOut = 0;
            WeightGrossCurrent = 0;
            WeightGrossVariationIn = 0;
            WeightGrossVariationOut = 0;
            WeightNetCurrent = 0;
            WeightNetVariationIn = 0;
            WeightNetVariationOut = 0;
            Receptions = new List<string>();
            Deliveries = new List<string>();
            ReceptionDeliveryClientSymbol = string.Empty;
            ReceptionDeliveryNumber = 0;
        }

        public static ReportStockVariationDetailAction GetInitialStockStatus(ReportStockVariationDetailFilterCriteria criteria)
        {
            ReportStockVariationDetailAction result = new ReportStockVariationDetailAction();

            using (EntityModelSirius model = new EntityModelSirius(Configuration.Main.SQLConnectionString))
            {
                DateTime criteriaDateExecution = criteria.DateExecutionBegin.HasValue ? CommonLibs.DatesLib.CreateSameDateWithNewTime(criteria.DateExecutionBegin.Value.AddDays(-1), 23, 59, 59) : new DateTime(2000, 1, 1, 23, 59, 59);

                var packageList = (from o in model.Packages
                                   where ((criteria.CompanyId == 0) || (o.Reception.Client.Company.Id == criteria.CompanyId)) && ((criteria.ClientId == 0) || (o.Reception.Client.Id == criteria.ClientId)) && ((criteria.WarehouseId == 0) || (o.Reception.Warehouse.Id == criteria.WarehouseId)) && ((criteria.ProductId == 0) || (o.Product.Id == criteria.ProductId)) && (o.Reception.DateCreation <= criteriaDateExecution) && ((o.Delivery == null) || (o.Delivery.DateCreation > criteriaDateExecution))
                                   select o).ToList();
                result.DateExecution = criteriaDateExecution;
                if ((packageList.Count) > 0)
                {
                    result.PackageCountCurrent = packageList.Count;
                    result.WeightGrossCurrent = packageList.Sum(o => o.WeightGross);
                    result.WeightNetCurrent = packageList.Sum(o => o.WeightNet);
                }
            }

            return result;
        }
    }
}
