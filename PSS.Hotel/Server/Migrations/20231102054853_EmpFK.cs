using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSS.Hotel.Server.Migrations
{
    /// <inheritdoc />
    public partial class EmpFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeMaster_DesignationMaster_designationcode",
                table: "EmployeeMaster",
                column: "designationcode",
                principalTable: "DesignationMaster",
                principalColumn: "DesignationCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeMaster_DesignationMaster_designationcode",
                table: "EmployeeMaster");
        }
    }
}
