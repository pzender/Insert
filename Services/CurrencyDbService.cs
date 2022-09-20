using InsertRekrutacja.Models;

namespace InsertRekrutacja.Services
{
    public class CurrencyDbService
    {
        private CurrencyDbContext _dbContext = new CurrencyDbContext();

        public IEnumerable<CurrencyRate> GetCurrencyRates()
        {
            return _dbContext.CurrencyRates.ToList();
        }

        public void StoreRates(IEnumerable<CurrencyRate> newRates)
        {
            IEnumerable<CurrencyRate> existingRates = _dbContext.CurrencyRates.ToList();
            foreach (CurrencyRate newRate in newRates)
            {
                if(!existingRates.Contains(newRate))
                {
                    _dbContext.CurrencyRates.Add(newRate);
                }
            }
        }
    }
}
