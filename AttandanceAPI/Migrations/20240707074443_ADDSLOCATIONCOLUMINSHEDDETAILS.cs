using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AttandanceAPI.Migrations
{
    /// <inheritdoc />
    public partial class ADDSLOCATIONCOLUMINSHEDDETAILS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Shed_Latitude",
                table: "Shed_Details",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Shed_Longitude",
                table: "Shed_Details",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shed_Latitude",
                table: "Shed_Details");

            migrationBuilder.DropColumn(
                name: "Shed_Longitude",
                table: "Shed_Details");
        }
    }
}
