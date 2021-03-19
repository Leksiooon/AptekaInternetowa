using Microsoft.EntityFrameworkCore.Migrations;

namespace AptekaInternetowa.Migrations
{
    public partial class ZmianaNazwyPropWAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "AddressClient",
                newName: "StreetNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetNumber",
                table: "AddressClient",
                newName: "Address");
        }
    }
}
