using Microsoft.EntityFrameworkCore.Migrations;

namespace VisaTracking.Data.Migrations
{
    public partial class RemarksFieldadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "Enrollments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "Enrollments");
        }
    }
}
