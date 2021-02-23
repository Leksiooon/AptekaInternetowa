using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AptekaInternetowa.Migrations
{
    public partial class Dodaniedatyzamowienia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "SubmissionDate",
                table: "Zamowienie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubmissionDate",
                table: "Zamowienie");
        }
    }
}
