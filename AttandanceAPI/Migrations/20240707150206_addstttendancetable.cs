using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AttandanceAPI.Migrations
{
    /// <inheritdoc />
    public partial class addstttendancetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShedIncharge_StaffNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttendanceUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminTag = table.Column<bool>(type: "bit", nullable: false),
                    ZonalRLY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shed_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckIn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckOut = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendance");
        }
    }
}
