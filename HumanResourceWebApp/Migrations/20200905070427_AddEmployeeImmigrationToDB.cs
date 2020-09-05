using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HumanResourceWebApp.Migrations
{
    public partial class AddEmployeeImmigrationToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EImmigrations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    DocumentType = table.Column<string>(nullable: true),
                    DocumentNumber = table.Column<string>(nullable: true),
                    DateIssued = table.Column<DateTime>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    EligibleStatus = table.Column<DateTime>(nullable: false),
                    IssuedBy = table.Column<int>(nullable: false),
                    EligibleReviewDate = table.Column<DateTime>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EImmigrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EImmigrations_Countries_Id",
                        column: x => x.Id,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EImmigrations");
        }
    }
}
