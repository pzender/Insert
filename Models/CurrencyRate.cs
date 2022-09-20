using System.ComponentModel.DataAnnotations;

namespace InsertRekrutacja.Models
{
    public class CurrencyRate
    {
        [Key]
        public Guid Id { get; set; }
        public string Code { get; set; }
        public double AvgRate { get; set; }
        public DateOnly Date { get; set; }

        public CurrencyRate(string code, double avgRate, DateOnly date)
        {
            Code = code;
            AvgRate = avgRate;
            Date = date;
            Id = Guid.NewGuid();
        }
    }
}
