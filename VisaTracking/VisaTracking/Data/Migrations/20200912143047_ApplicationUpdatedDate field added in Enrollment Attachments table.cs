using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VisaTracking.Data.Migrations
{
    public partial class ApplicationUpdatedDatefieldaddedinEnrollmentAttachmentstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ApplicationUpdatedDate",
                table: "Enrollments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationUpdatedDate",
                table: "Enrollments");
        }
    }
}
