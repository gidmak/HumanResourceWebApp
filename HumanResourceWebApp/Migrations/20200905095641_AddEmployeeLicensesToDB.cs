using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HumanResourceWebApp.Migrations
{
    public partial class AddEmployeeLicensesToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ELicenses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    LicenseId = table.Column<int>(nullable: false),
                    LicenceNumber = table.Column<string>(nullable: true),
                    IssuedDate = table.Column<DateTime>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ELicenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ELicenses_Licenses_Id",
                        column: x => x.Id,
                        principalTable: "Licenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ELicenses");
        }
    }
}
