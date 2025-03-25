using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoEnergyRazorPages.Migrations
{
    /// <inheritdoc />
    public partial class UpgradedSimulations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SysTypeId",
                table: "Simulations");

            migrationBuilder.AlterColumn<string>(
                name: "SysType",
                table: "Simulations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SysType",
                table: "Simulations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "SysTypeId",
                table: "Simulations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
