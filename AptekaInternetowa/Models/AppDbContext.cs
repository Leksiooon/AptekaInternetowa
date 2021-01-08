using Microsoft.EntityFrameworkCore;
using AptekaInternetowa.Models.ProduktM;

namespace AptekaInternetowa.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Produkt> Produkty { get; set; }
    }
}