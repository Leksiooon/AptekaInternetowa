using AptekaInternetowa.Models.AddressClientM;
using AptekaInternetowa.Models.ProduktM;
using AptekaInternetowa.Models.UserM;
using AptekaInternetowa.Models.ZamowienieElementM;
using AptekaInternetowa.Models.ZamowienieM;
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
        public DbSet<AddressClient> AddressClient { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AppUser>()
                .HasOne<AddressClient>(s => s.Address)
                .WithOne(a => a.AppUser)
                .HasForeignKey<AddressClient>(a => a.AppUserId);


        }
    }
}