using Microsoft.EntityFrameworkCore.Migrations;

namespace VisaTracking.Data.Migrations
{
    public partial class Initialtablesadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VisaStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisaStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    CNICNumber = table.Column<string>(nullable: true),
                    PassportNumber = table.Column<string>(nullable: true),
                    LastQualification = table.Column<string>(nullable: true),
                    ApplyForCountry = table.Column<string>(nullable: true),
                    GradesObtained = table.Column<int>(nullable: false),
                    PrefferedCourse = table.Column<string>(nullable: true),
                    CurrentAddress = table.Column<string>(nullable: true),
                    RelevantFiles = table.Column<string>(nullable: true),
                    VisaStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enrollments_VisaStatuses_VisaStatusId",
                        column: x => x.VisaStatusId,
                        principalTable: "VisaStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_VisaStatusId",
                table: "Enrollments",
                column: "VisaStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "VisaStatuses");
        }
    }
}
