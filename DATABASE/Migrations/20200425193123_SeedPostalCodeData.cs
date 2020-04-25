using Microsoft.EntityFrameworkCore.Migrations;

namespace NotTaxTim.Database.Migrations
{
    public partial class SeedPostalCodeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PostalCodes",
                columns: new[] {"Code"},
                values: new object[] {"7441"}
            );

            migrationBuilder.InsertData(
                table: "PostalCodes",
                columns: new[] {"Code"},
                values: new object[] {"A100"}
            );

            migrationBuilder.InsertData(
                table: "PostalCodes",
                columns: new[] {"Code"},
                values: new object[] {"7000"}
            );

            migrationBuilder.InsertData(
                table: "PostalCodes",
                columns: new[] {"Code"},
                values: new object[] {"1000"}
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
