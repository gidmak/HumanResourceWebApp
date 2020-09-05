using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HumanResourceWebApp.Migrations
{
    public partial class AddEmployeeContactDetailToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EContactDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    HomeAddress = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    WorkTelephone = table.Column<string>(nullable: true),
                    WorkEmail = table.Column<string>(nullable: true),
                    OtherEmail = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_EContactDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EContactDetails_Countries_Id",
                        column: x => x.Id,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EContactDetails");
        }
    }
}
