﻿// <auto-generated />
using System;
using AptekaInternetowa.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AptekaInternetowa.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AptekaInternetowa.Models.AddressClientM.AddressClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppUserId");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("PostCode");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.Property<string>("StreetNumber");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId")
                        .IsUnique();

                    b.ToTable("AddressClient");
                });

            modelBuilder.Entity("AptekaInternetowa.Models.ProduktM.Produkt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cena");

                    b.Property<string>("Dawkowanie");

                    b.Property<string>("DodatkoweInformacje");

                    b.Property<string>("Dzialanie");

                    b.Property<int>("LiczbaDostępnychSztuk");

                    b.Property<string>("Nazwa");

                    b.Property<string>("Producent");

                    b.Property<string>("Przeciwwskazania");

                    b.Property<string>("Sklad");

                    b.Property<string>("Wskazania");

                    b.Property<string>("ZdjecieUrl");

                    b.HasKey("Id");

                    b.ToTable("Produkty");
                });

            modelBuilder.Entity("AptekaInternetowa.Models.UserM.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("AppUser");
                });

            modelBuilder.Entity("AptekaInternetowa.Models.ZamowienieElementM.ZamowienieElement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ilosc");

                    b.Property<int?>("ProduktId");

                    b.Property<int?>("ZamowienieId");

                    b.HasKey("Id");

                    b.HasIndex("ProduktId");

                    b.HasIndex("ZamowienieId");

                    b.ToTable("ZamowienieElement");
                });

            modelBuilder.Entity("AptekaInternetowa.Models.ZamowienieM.Zamowienie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AppUserId");

                    b.Property<int>("Status");

                    b.Property<DateTime?>("SubmissionDate");

                    b.Property<double>("Wartosc");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Zamowienie");
                });

            modelBuilder.Entity("AptekaInternetowa.Models.AddressClientM.AddressClient", b =>
                {
                    b.HasOne("AptekaInternetowa.Models.UserM.AppUser", "AppUser")
                        .WithOne("Address")
                        .HasForeignKey("AptekaInternetowa.Models.AddressClientM.AddressClient", "AppUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AptekaInternetowa.Models.ZamowienieElementM.ZamowienieElement", b =>
                {
                    b.HasOne("AptekaInternetowa.Models.ProduktM.Produkt", "Produkt")
                        .WithMany()
                        .HasForeignKey("ProduktId");

                    b.HasOne("AptekaInternetowa.Models.ZamowienieM.Zamowienie", "Zamowienie")
                        .WithMany("ElementyZamowienia")
                        .HasForeignKey("ZamowienieId");
                });

            modelBuilder.Entity("AptekaInternetowa.Models.ZamowienieM.Zamowienie", b =>
                {
                    b.HasOne("AptekaInternetowa.Models.UserM.AppUser", "AppUser")
                        .WithMany("Zamowienia")
                        .HasForeignKey("AppUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
