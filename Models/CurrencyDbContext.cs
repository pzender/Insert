using Microsoft.EntityFrameworkCore;

namespace InsertRekrutacja.Models
{
    public class CurrencyDbContext : DbContext
    {
        public DbSet<CurrencyRate> CurrencyRates { get; set; }
        private readonly string DbConnString = @"DataSource=Database/CurrencyDb.sqlite;";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(DbConnString);
        }
    }
}
