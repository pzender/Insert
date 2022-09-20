using InsertRekrutacja.Models;
using Newtonsoft.Json;

namespace InsertRekrutacja.Services
{
    public class NBPApiService
    {
        private readonly string ApiUrl = "http://api.nbp.pl/api/exchangerates/tables/a";
        private APIClient<NBPCurrencyTable> _apiClient;

        public NBPApiService()
        {
            this._apiClient = new APIClient<NBPCurrencyTable>(ApiUrl);
        }


        public IEnumerable<CurrencyRate> FetchCurrentRates()
        {
            NBPCurrencyTable table = _apiClient.FetchList().First();
            IEnumerable<CurrencyRate> rates = table.Rates
                .Select(nbpRate => new CurrencyRate(nbpRate.Code, nbpRate.Mid, DateOnly.Parse(table.EffectiveDate)));
            return rates;

        }


    }
}
