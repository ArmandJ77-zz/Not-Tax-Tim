using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace NotTaxTim.Database.Migrations
{
    public partial class AddCalculationResultTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalculationResults",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostalCodeId = table.Column<long>(nullable: false),
                    TaxCalculationType = table.Column<long>(nullable: false),
                    AnnualIncome = table.Column<decimal>(nullable: false),
                    TotalTax = table.Column<decimal>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CalculationTypeId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalculationResults_TaxCalculationTypes_CalculationTypeId",
                        column: x => x.CalculationTypeId,
                        principalTable: "TaxCalculationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CalculationResults_PostalCodes_PostalCodeId",
                        column: x => x.PostalCodeId,
                        principalTable: "PostalCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CalculationResults_CalculationTypeId",
                table: "CalculationResults",
                column: "CalculationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CalculationResults_PostalCodeId",
                table: "CalculationResults",
                column: "PostalCodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalculationResults");
        }
    }
}
