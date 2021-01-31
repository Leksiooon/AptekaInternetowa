using AptekaInternetowa.Models.ProduktM;
using AptekaInternetowa.Models.UserM;
using AptekaInternetowa.Models.ZamowienieElementM;
using AptekaInternetowa.Models.ZamowienieM;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AptekaInternetowa.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Produkt> Produkty { get; set; }
        public DbSet<ZamowienieElement> ZamowienieElement { get; set; }
        public DbSet<Zamowienie> Zamowienie { get; set; }
        public DbSet<AppUser> AppUser { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<AppUser>()
            //    .HasIndex(u => u.Email)
            //    .IsUnique();
        }
    }
}