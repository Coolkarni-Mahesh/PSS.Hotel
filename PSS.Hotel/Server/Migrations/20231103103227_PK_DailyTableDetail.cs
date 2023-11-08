using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSS.Hotel.Server.Migrations
{
    /// <inheritdoc />
    public partial class PK_DailyTableDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DailyTableDetailID",
                table: "DailyTableDetail",
                type: "integer",
                nullable: true)
                .Annotation("Jet:Identity", "1, 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DailyTableDetailID",
                table: "DailyTableDetail");
        }
    }
}
