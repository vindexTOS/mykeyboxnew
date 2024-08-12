using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyKeyBox.Modules.BackOffice.Core.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitBackOffcieModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "back_office");

            migrationBuilder.CreateTable(
                name: "Dealership",
                schema: "back_office",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationLat = table.Column<double>(type: "float", nullable: false),
                    LocationLong = table.Column<double>(type: "float", nullable: false),
                    GoogleLink = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    WorkingHoursPerDay = table.Column<byte>(type: "tinyint", nullable: false),
                    ResponsiblePersonFirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ResponsiblePersonLastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ResponsiblePersonJobTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ResponsiblePersonPhone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ResponsiblePersonEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RegistrationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BackupPersonFirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BackupPersonLastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BackupPersonJobTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BackupPersonPhone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    BackupPersonEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MCcode = table.Column<int>(type: "int", maxLength: 100, nullable: true),
                    ZipCode = table.Column<int>(type: "int", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealership", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dealership",
                schema: "back_office");
        }
    }
}
