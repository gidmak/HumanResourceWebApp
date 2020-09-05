using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HumanResourceWebApp.Migrations
{
    public partial class AddCompanyInformationToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    OrganizationName = table.Column<string>(nullable: true),
                    TaxId = table.Column<string>(nullable: true),
                    NumberOfEmployees = table.Column<int>(nullable: false),
                    RegistrationNumber = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    StateOrProvince = table.Column<string>(nullable: true),
                    ZipOrPostalCode = table.Column<string>(nullable: true),
                    CountryId = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyInformation_Countries_Id",
                        column: x => x.Id,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyInformation");
        }
    }
}
