using Microsoft.EntityFrameworkCore.Migrations;

namespace NotTaxTim.Database.Migrations
{
    public partial class SeedCalculationRuleTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CalculationRuleTypes",
                columns: new[] {"PostalCodeId","TaxCalculationTypeId"},
                values: new object[] {1,1}
            );

            migrationBuilder.InsertData(
                table: "CalculationRuleTypes",
                columns: new[] {"PostalCodeId","TaxCalculationTypeId"},
                values: new object[] {2,2}
            );

            migrationBuilder.InsertData(
                table: "CalculationRuleTypes",
                columns: new[] {"PostalCodeId","TaxCalculationTypeId"},
                values: new object[] {3,3}
            );

            migrationBuilder.InsertData(
                table: "CalculationRuleTypes",
                columns: new[] {"PostalCodeId","TaxCalculationTypeId"},
                values: new object[] {4,1}
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
