using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HumanResourceWebApp.Migrations
{
    public partial class AddPayGradeToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PayGrades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false),
                    MinimumSalary = table.Column<string>(nullable: true),
                    MaximumSalary = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayGrades_Currencies_Id",
                        column: x => x.Id,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PayGrades");
        }
    }
}
