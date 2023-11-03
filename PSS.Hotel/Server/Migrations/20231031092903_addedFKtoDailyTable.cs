using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSS.Hotel.Server.Migrations
{
    /// <inheritdoc />
    public partial class addedFKtoDailyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_DailyTable_EmployeeMaster_CaptainCode",
                table: "DailyTable",
                column: "CaptainCode",
                principalTable: "EmployeeMaster",
                principalColumn: "Empno");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyTable_EmployeeMaster_CaptainCode",
                table: "DailyTable");
        }
    }
}
