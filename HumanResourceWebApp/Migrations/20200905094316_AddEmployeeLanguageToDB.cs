using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HumanResourceWebApp.Migrations
{
    public partial class AddEmployeeLanguageToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ELanguages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Fluency = table.Column<string>(nullable: true),
                    Competency = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ELanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ELanguages_Languages_Id",
                        column: x => x.Id,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ELanguages");
        }
    }
}
