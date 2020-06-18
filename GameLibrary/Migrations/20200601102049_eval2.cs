using Microsoft.EntityFrameworkCore.Migrations;

namespace GameLibrary.Migrations
{
    public partial class eval2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Evals",
                columns: table => new
                {
                    EvalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EvalSubject = table.Column<string>(nullable: true),
                    EvalDescription = table.Column<string>(nullable: false),
                    ApplicationUserID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evals", x => x.EvalId);
                    table.ForeignKey(
                        name: "FK_Evals_AspNetUsers_ApplicationUserID",
                        column: x => x.ApplicationUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evals_ApplicationUserID",
                table: "Evals",
                column: "ApplicationUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evals");
        }
    }
}
