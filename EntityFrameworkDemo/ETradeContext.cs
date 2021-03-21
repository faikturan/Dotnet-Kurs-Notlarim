using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDemo
{
    public class ETradeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ETrade;User ID=sa;Password=Onur-1234");
        }

        public DbSet<Product> Products { get; set; }
    }
}