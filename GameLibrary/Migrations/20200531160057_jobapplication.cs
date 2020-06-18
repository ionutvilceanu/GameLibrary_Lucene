using Microsoft.EntityFrameworkCore.Migrations;

namespace GameLibrary.Migrations
{
    public partial class jobapplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobApplication",
                columns: table => new
                {
                    JobApplicationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(nullable: true),
                    Ocupatie = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    JobSectionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplication", x => x.JobApplicationId);
                    table.ForeignKey(
                        name: "FK_JobApplication_JobSections_JobSectionId",
                        column: x => x.JobSectionId,
                        principalTable: "JobSections",
                        principalColumn: "JobSectionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobApplication_JobSectionId",
                table: "JobApplication",
                column: "JobSectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobApplication");
        }
    }
}
