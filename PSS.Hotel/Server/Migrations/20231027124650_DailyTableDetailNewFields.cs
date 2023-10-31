using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSS.Hotel.Server.Migrations
{
    /// <inheritdoc />
    public partial class DailyTableDetailNewFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Delivered",
                table: "DailyTableDetail",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pending",
                table: "DailyTableDetail",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ready",
                table: "DailyTableDetail",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Delivered",
                table: "DailyTableDetail");

            migrationBuilder.DropColumn(
                name: "Pending",
                table: "DailyTableDetail");

            migrationBuilder.DropColumn(
                name: "Ready",
                table: "DailyTableDetail");
        }
    }
}
