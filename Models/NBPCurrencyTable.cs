namespace InsertRekrutacja.Models
{
    public class NBPCurrencyTable
    {
        public string Table { get; set; }
        public string No { get; set; }
        public string EffectiveDate { get; set; }
        public IEnumerable<NBPCurrencyRate> Rates { get; set; }

    }
}
