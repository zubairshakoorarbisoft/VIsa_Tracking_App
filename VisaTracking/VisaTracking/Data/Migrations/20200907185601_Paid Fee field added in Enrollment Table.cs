using Microsoft.EntityFrameworkCore.Migrations;

namespace VisaTracking.Data.Migrations
{
    public partial class PaidFeefieldaddedinEnrollmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FeePaid",
                table: "Enrollments",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeePaid",
                table: "Enrollments");
        }
    }
}
