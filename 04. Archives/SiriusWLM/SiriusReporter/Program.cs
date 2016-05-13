using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Sirius.SiriusReporter
{
    class Program
    {
        static void WriteLog(string name, string error)
        {
            File.AppendAllText("debug.txt", Environment.NewLine + DateTime.Now.ToString() + " - " + name + Environment.NewLine + error);
        }

        static void Main(string[] args)
        {
            StringBuilder str;
            bool error;

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            if (Configuration.Main.ReadConfigFromFile() == true)
            {
                var dateNow = DateTime.Now;

                using (EntityModels.EntityModelSirius model = new EntityModels.EntityModelSirius(Configuration.Main.SQLConnectionString))
                {
                    int companyId = 1;
                    var company = model.Companies.FirstOrDefault(o => o.Id == companyId);
                    if (company != null)
                    {
                        //Send stock variation detail to RADAN
                        if (dateNow.Hour == 21)
                        {

                            EntityModels.Reports.ReportStockProductsFilterCriteria criteriaStockCurrent = new EntityModels.Reports.ReportStockProductsFilterCriteria();
                            //Send current stock report

                            EntityModels.Reports.ReportStockVariationDetailFilterCriteria criteriaStockVariation = new EntityModels.Reports.ReportStockVariationDetailFilterCriteria();
                            criteriaStockVariation.DateExecutionBegin = CommonLibs.DatesLib.GetFirstDayOfMonth(DateTime.Now.AddMonths(-2));

                            str = new StringBuilder();
                            str.AppendLine(EntityModels.Reports.ReportStockVariationDetail.ToHTML(model, criteriaStockVariation, true, false));
                            str.AppendLine("<br/><hr/><br/>");
                            str.AppendLine(EntityModels.Reports.ReportStockProducts.ToHTML(model, criteriaStockCurrent));
                            str.AppendLine("</body></html>");

                            error = CommonLibs.EmailLib.Send(company.EmailSendServer, company.EmailSendPort, company.EmailSendEncryption, company.EmailSendAddress, "RADAN Raportari Logistica", company.EmailSendUsername, company.EmailSendPassword, "radu.paliciuc@radanimpex.ro,marius.cismaru@radanimpex.ro,laurentiu.popescu@radanimpex.ro,daniela.chisiu@radanimpex.ro,ionut.faur@radanimpex.ro,antonia@radanimpex.ro", null, null, null, "Raport variatie stoc + stoc curent", str.ToString(), null);
                            if (!error)
                            {
                                WriteLog("Reports for Radan", "Error sending email");
                            }
                        }


                        //Send stock reports to clients that have the IsEmailSendReportStock set to true
                        if (dateNow.Hour == 23)
                        {
                            //Delete all xlsx files from temp
                            try
                            {
                                Directory.EnumerateFiles(System.IO.Path.GetTempPath(), "*.xlsx").ToList().ForEach(x => File.Delete(x));
                            }
                            catch
                            {
                            }

                            str = new StringBuilder();

                            var clientsToSend = model.Clients.Where(o => ((o.IsActive == true) && (o.IsEmailSendReportStock == true))).ToList();
                            foreach (var clientToSend in clientsToSend)
                            {
                                EntityModels.Reports.ReportStockProductsByClientFilterCriteria criteriaStockCurrentClient = new EntityModels.Reports.ReportStockProductsByClientFilterCriteria { ClientId = clientToSend.Id, DateExecution = dateNow };

                                str.Clear();
                                str.AppendLine("<html><body>");

                                var result = EntityModels.Reports.ReportStockProductsByClient.ToHTMLAndExcelFile(model, criteriaStockCurrentClient);

                                str.AppendLine(result.HTMLContent);
                                str.AppendLine("</body></html>");

                                error = CommonLibs.EmailLib.Send(company.EmailSendServer, company.EmailSendPort, company.EmailSendEncryption, company.EmailSendAddress, "RADAN Raportari Logistica", company.EmailSendUsername, company.EmailSendPassword, clientToSend.EmailAddressList, null, null, null, "Raport stoc curent " + clientToSend.NameShort, str.ToString(), new List<string> { result.ExcelFileName });
                                if (!error)
                                {
                                    WriteLog("Reports for clients", "Error sending email stock for " + clientToSend.NameShort);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                WriteLog("ReadConfigFromFile", "Config file not found");
            }
        }
    }
}
