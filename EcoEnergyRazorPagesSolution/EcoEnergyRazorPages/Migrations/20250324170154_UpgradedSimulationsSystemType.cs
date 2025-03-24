using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoEnergyRazorPages.Migrations
{
    /// <inheritdoc />
    public partial class UpgradedSimulationsSystemType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SysType",
                table: "Simulations",
                newName: "SystemType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SystemType",
                table: "Simulations",
                newName: "SysType");
        }
    }
}
