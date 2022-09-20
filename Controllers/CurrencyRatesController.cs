using InsertRekrutacja.Models;
using InsertRekrutacja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsertRekrutacja.Controllers
{
    public class CurrencyRatesController : Controller
    {
        private CurrencyDbService dbService = new CurrencyDbService();
        private NBPApiService apiService = new NBPApiService();

        public ActionResult Index()
        {
            IEnumerable<CurrencyRate> rates = apiService.FetchCurrentRates();
            dbService.StoreRates(rates);
            return View(rates);
        }
    }
}