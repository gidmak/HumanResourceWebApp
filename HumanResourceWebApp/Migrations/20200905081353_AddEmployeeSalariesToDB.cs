using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HumanResourceWebApp.Migrations
{
    public partial class AddEmployeeSalariesToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ESalaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    PayGradeId = table.Column<int>(nullable: false),
                    PayFrequency = table.Column<string>(nullable: true),
                    CurrencyId = table.Column<int>(nullable: false),
                    Amount = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESalaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ESalaries_Currencies_Id",
                        column: x => x.Id,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ESalaries");
        }
    }
}
