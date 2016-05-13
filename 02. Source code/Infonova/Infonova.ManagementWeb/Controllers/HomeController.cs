using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Infonova.ManagementWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var rand = new Random(DateTime.Now.Millisecond);
            using (var model = Infonova.Data.Models.Infonova.ModelInfonova.GetNewModel())
            {
                ViewBag.Title = "Stoc curent " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
                ViewBag.Message = model.Companies.FirstOrDefault().NameFull;

                var stock = new Models.StockViewModel();

                var articles = model.Articles.OrderBy(o => o.NameFull);
                foreach (var article in articles)
                {
                    stock.StockList.Add(new Models.StockItemViewModel
                    {
                        Article = article.NameFull + " (" + article.Code + ")",
                        ArticleCategory = article.ArticleSubGroup.ArticleGroup.ArticleCategory.Name,
                        ArticleGroup = article.ArticleSubGroup.ArticleGroup.Name,
                        ArticleSubGroup = article.ArticleSubGroup.Name,
                        Quantity = (1000 * rand.NextDouble()).ToString("0"),
                        MU = (article.IsCalibrated ? " Buc" : " Kg")
                    });
                }

                ViewBag.Stock = stock;
            }

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Adaugare comanda de vanzare noua";

            var saleOrder = new Models.AddSaleOrderViewModel();
            var stock = new Models.StockViewModel();

            using (var model = Infonova.Data.Models.Infonova.ModelInfonova.GetNewModel())
            {
                saleOrder.Collaborators = model.Collaborators.Where(o => o.IsRelationCustomer).Select(o => o.NameFull).ToList();
                saleOrder.Companies = model.Companies.Select(o => o.NameFull).ToList();
                saleOrder.Employees = model.Employees.Select(o => (o.NameFirst + " " + o.NameLast)).ToList();

                var rand = new Random(DateTime.Now.Millisecond);
                var articles = model.Articles.OrderBy(o => o.NameFull);
                foreach (var article in articles)
                {
                    stock.StockList.Add(new Models.StockItemViewModel
                    {
                        Article = article.NameFull + " (" + article.Code + ")",
                        ArticleCategory = article.ArticleSubGroup.ArticleGroup.ArticleCategory.Name,
                        ArticleGroup = article.ArticleSubGroup.ArticleGroup.Name,
                        ArticleSubGroup = article.ArticleSubGroup.Name,
                        Quantity = (1000 * rand.NextDouble()).ToString("0"),
                        MU = (article.IsCalibrated ? " Buc" : " Kg")
                    });
                }

                var articles2 = model.Articles.OrderBy(o => o.NameFull).Take(2);
                foreach (var article in articles2)
                {
                    saleOrder.Items.Add(new Models.SaleOrderItemViewModel
                    {
                        Article = article.NameFull + " (" + article.Code + ")",
                        Quantity = Math.Round((1000 * rand.NextDouble()), 2),
                        MU = (article.IsCalibrated ? " Buc" : " Kg"),
                         Price = Math.Round((10 * rand.NextDouble()), 2)
                    });
                }
            }

            ViewBag.Stock = stock;
            ViewBag.SaleOrder = saleOrder;

            return View();
        }
    }
}