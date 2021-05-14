using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core_Cascade_Delete.Migrations
{
    public partial class person_config_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_People_OwnerId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_OwnerId",
                table: "Blogs");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_OwnerId",
                table: "Blogs",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_People_OwnerId",
                table: "Blogs",
                column: "OwnerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_People_OwnerId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_OwnerId",
                table: "Blogs");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_OwnerId",
                table: "Blogs",
                column: "OwnerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_People_OwnerId",
                table: "Blogs",
                column: "OwnerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
