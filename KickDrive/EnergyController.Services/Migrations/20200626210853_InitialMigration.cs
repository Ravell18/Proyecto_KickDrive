using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnergyController.Services.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverName = table.Column<string>(nullable: true),
                    INE = table.Column<string>(nullable: true),
                    License = table.Column<string>(nullable: true),
                    NSS = table.Column<int>(nullable: false),
                    FrontPhoto = table.Column<string>(nullable: true),
                    ProfilePhoto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverId);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAT = table.Column<DateTime>(nullable: false),
                    UpdateAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    NProp = table.Column<int>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    NSerie = table.Column<int>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    TipServ = table.Column<string>(nullable: true),
                    NMotor = table.Column<int>(nullable: false),
                    TComb = table.Column<string>(nullable: true),
                    DocLeg = table.Column<string>(nullable: true),
                    TipLlantas = table.Column<string>(nullable: true),
                    CapPerson = table.Column<int>(nullable: false),
                    CapTon = table.Column<int>(nullable: false),
                    Placas = table.Column<int>(nullable: false),
                    OfExp = table.Column<string>(nullable: true),
                    NRegist = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Route",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAT = table.Column<DateTime>(nullable: false),
                    UpdateAT = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    NameSup = table.Column<string>(nullable: true),
                    NumSup = table.Column<int>(nullable: false),
                    Incidents = table.Column<string>(nullable: true),
                    timeE = table.Column<string>(nullable: false),
                    timeS = table.Column<string>(nullable: false),
                    NYES = table.Column<string>(nullable: true),
                    Adults = table.Column<string>(nullable: true),
                    DriverId = table.Column<int>(nullable: false),
                    VehicleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Route_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Route_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Route_DriverId",
                table: "Route",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Route_VehicleId",
                table: "Route",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Route");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}
