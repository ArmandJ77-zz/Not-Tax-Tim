using Microsoft.EntityFrameworkCore.Migrations;

namespace NotTaxTim.Database.Migrations
{
    public partial class AddNetPayColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "NetPay",
                table: "CalculationResults",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NetPay",
                table: "CalculationResults");
        }
    }
}
