using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSS.Hotel.Server.Migrations
{
    /// <inheritdoc />
    public partial class DailyTableDetailCooking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cooking",
                table: "DailyTableDetail",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cooking",
                table: "DailyTableDetail");
        }
    }
}
