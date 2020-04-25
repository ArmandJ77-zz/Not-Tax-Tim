using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace NotTaxTim.Database.Migrations
{
    public partial class AddCalculationRuleTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalculationRuleTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostalCodeId = table.Column<long>(nullable: false),
                    TaxCalculationTypeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationRuleTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalculationRuleTypes_PostalCodes_PostalCodeId",
                        column: x => x.PostalCodeId,
                        principalTable: "PostalCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalculationRuleTypes_TaxCalculationTypes_TaxCalculationType~",
                        column: x => x.TaxCalculationTypeId,
                        principalTable: "TaxCalculationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CalculationRuleTypes_PostalCodeId",
                table: "CalculationRuleTypes",
                column: "PostalCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_CalculationRuleTypes_TaxCalculationTypeId",
                table: "CalculationRuleTypes",
                column: "TaxCalculationTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalculationRuleTypes");
        }
    }
}
