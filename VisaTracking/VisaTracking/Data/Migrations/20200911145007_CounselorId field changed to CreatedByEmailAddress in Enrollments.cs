using Microsoft.EntityFrameworkCore.Migrations;

namespace VisaTracking.Data.Migrations
{
    public partial class CounselorIdfieldchangedtoCreatedByEmailAddressinEnrollments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CounselorId",
                table: "Enrollments");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByEmailAddress",
                table: "Enrollments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByEmailAddress",
                table: "Enrollments");

            migrationBuilder.AddColumn<string>(
                name: "CounselorId",
                table: "Enrollments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
