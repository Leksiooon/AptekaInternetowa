using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AptekaInternetowa.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produkty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nazwa = table.Column<string>(nullable: true),
                    Producent = table.Column<string>(nullable: true),
                    Cena = table.Column<double>(nullable: false),
                    ZdjecieUrl = table.Column<string>(nullable: true),
                    LiczbaDostępnychSztuk = table.Column<int>(nullable: false),
                    Sklad = table.Column<string>(nullable: true),
                    Dzialanie = table.Column<string>(nullable: true),
                    Przeciwwskazania = table.Column<string>(nullable: true),
                    Wskazania = table.Column<string>(nullable: true),
                    Dawkowanie = table.Column<string>(nullable: true),
                    DodatkoweInformacje = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkty", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produkty");
        }
    }
}
