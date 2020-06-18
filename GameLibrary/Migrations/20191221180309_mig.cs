using Microsoft.EntityFrameworkCore.Migrations;

namespace GameLibrary.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_AspNetUsers_ApplicationUserID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ApplicationUserID",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ApplicationUserID",
                table: "OrderDetails");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserID",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserID",
                table: "Orders",
                column: "ApplicationUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_ApplicationUserID",
                table: "Orders",
                column: "ApplicationUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_ApplicationUserID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ApplicationUserID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ApplicationUserID",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserID",
                table: "OrderDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ApplicationUserID",
                table: "OrderDetails",
                column: "ApplicationUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_AspNetUsers_ApplicationUserID",
                table: "OrderDetails",
                column: "ApplicationUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
