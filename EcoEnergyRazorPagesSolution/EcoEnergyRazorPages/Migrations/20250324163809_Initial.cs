using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoEnergyRazorPages.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnergyIndicators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CDEEBC_ProdNeta = table.Column<float>(type: "real", nullable: false),
                    CCAC_GasolinaAuto = table.Column<float>(type: "real", nullable: false),
                    CDEEBC_DemandaElectr = table.Column<float>(type: "real", nullable: false),
                    CDEEBC_ProdDisp = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnergyIndicators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Simulations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SysTypeId = table.Column<int>(type: "int", nullable: false),
                    SysType = table.Column<int>(type: "int", nullable: false),
                    SunHours = table.Column<double>(type: "float", nullable: false),
                    WindVelocity = table.Column<double>(type: "float", nullable: false),
                    WaterFlow = table.Column<double>(type: "float", nullable: false),
                    Ratio = table.Column<double>(type: "float", nullable: false),
                    EnergyGen = table.Column<double>(type: "float", nullable: false),
                    KWHCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KWHPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Simulations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaterConsumptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionCode = table.Column<int>(type: "int", nullable: false),
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    HouseholdConsumptionPerCapita = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterConsumptions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnergyIndicators");

            migrationBuilder.DropTable(
                name: "Simulations");

            migrationBuilder.DropTable(
                name: "WaterConsumptions");
        }
    }
}
