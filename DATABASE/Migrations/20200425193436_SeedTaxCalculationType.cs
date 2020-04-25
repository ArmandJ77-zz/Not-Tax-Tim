using Microsoft.EntityFrameworkCore.Migrations;

namespace NotTaxTim.Database.Migrations
{
    public partial class SeedTaxCalculationType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TaxCalculationTypes",
                columns: new[] {"CalculationType"},
                values: new object[] {"Progressive"}
            );

            migrationBuilder.InsertData(
                table: "TaxCalculationTypes",
                columns: new[] {"CalculationType"},
                values: new object[] {"Flat Value"}
            );

            migrationBuilder.InsertData(
                table: "TaxCalculationTypes",
                columns: new[] {"CalculationType"},
                values: new object[] {"Flat Rate"}
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
