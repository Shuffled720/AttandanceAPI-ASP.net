using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AttandanceAPI.Migrations
{
    /// <inheritdoc />
    public partial class addstimecolumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CheckInTime",
                table: "Attendance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CheckOutTime",
                table: "Attendance",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckInTime",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "CheckOutTime",
                table: "Attendance");
        }
    }
}
