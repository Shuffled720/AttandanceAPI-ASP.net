using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AttandanceAPI.Migrations
{
    /// <inheritdoc />
    public partial class abcd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shed_Incharge_Details",
                columns: table => new
                {
                    ShedIncharge_StaffNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressOffice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressHome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttendanceUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttendanceUserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminTag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shed_Incharge_Details", x => x.ShedIncharge_StaffNo);
                });

            migrationBuilder.CreateTable(
                name: "Shed_Details",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ZonalRLY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shed_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correspondence_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Railway_ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShedIncharge_StaffNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shed_Incharge_DetailsShedIncharge_StaffNo = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shed_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shed_Details_Shed_Incharge_Details_Shed_Incharge_DetailsShedIncharge_StaffNo",
                        column: x => x.Shed_Incharge_DetailsShedIncharge_StaffNo,
                        principalTable: "Shed_Incharge_Details",
                        principalColumn: "ShedIncharge_StaffNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shed_Details_Shed_Incharge_DetailsShedIncharge_StaffNo",
                table: "Shed_Details",
                column: "Shed_Incharge_DetailsShedIncharge_StaffNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shed_Details");

            migrationBuilder.DropTable(
                name: "Shed_Incharge_Details");
        }
    }
}
