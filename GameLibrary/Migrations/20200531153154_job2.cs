using Microsoft.EntityFrameworkCore.Migrations;

namespace GameLibrary.Migrations
{
    public partial class job2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSection_AspNetUsers_ApplicationUserId1",
                table: "JobSection");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSection",
                table: "JobSection");

            migrationBuilder.DropIndex(
                name: "IX_JobSection_ApplicationUserId1",
                table: "JobSection");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "JobSection");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "JobSection");

            migrationBuilder.RenameTable(
                name: "JobSection",
                newName: "JobSections");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSections",
                table: "JobSections",
                column: "JobSectionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSections",
                table: "JobSections");

            migrationBuilder.RenameTable(
                name: "JobSections",
                newName: "JobSection");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "JobSection",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "JobSection",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSection",
                table: "JobSection",
                column: "JobSectionID");

            migrationBuilder.CreateIndex(
                name: "IX_JobSection_ApplicationUserId1",
                table: "JobSection",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSection_AspNetUsers_ApplicationUserId1",
                table: "JobSection",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
