using Microsoft.EntityFrameworkCore;
using AptekaInternetowa.Models.ProduktM;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using AptekaInternetowa.Models.ZamowienieM;

namespace AptekaInternetowa.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Produkt> Produkty { get; set; }
        public DbSet<ZamowienieElement> ZamowienieElement { get; set; }
    }
}