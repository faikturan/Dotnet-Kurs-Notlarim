using Microsoft.EntityFrameworkCore;

namespace TabloAnalizi
{
    public class TestContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Test;User ID=sa;Password=Onur-1234");
        }

        public DbSet<Table> Tables { get; set; }
        public DbSet<Colon> Colons { get; set; }

        public DbSet<Ortak> Ortaks { get; set; }
        
    }
}