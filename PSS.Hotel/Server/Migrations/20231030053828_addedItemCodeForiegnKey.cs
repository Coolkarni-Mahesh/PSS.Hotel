using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSS.Hotel.Server.Migrations
{
    /// <inheritdoc />
    public partial class addedItemCodeForiegnKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_DailyTableDetail_ItemMaster_Itemcode",
                table: "DailyTableDetail",
                column: "Itemcode",
                principalTable: "ItemMaster",
                principalColumn: "Itemcode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyTableDetail_ItemMaster_Itemcode",
                table: "DailyTableDetail");
        }
    }
}
