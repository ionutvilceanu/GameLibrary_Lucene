using Microsoft.EntityFrameworkCore.Migrations;

namespace GameLibrary.Migrations
{
    public partial class recommend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recommends",
                columns: table => new
                {
                    RecommendId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ItiPlace = table.Column<string>(nullable: true),
                    Dislike = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recommends", x => x.RecommendId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recommends");
        }
    }
}
