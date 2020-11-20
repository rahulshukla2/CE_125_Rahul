using Microsoft.EntityFrameworkCore.Migrations;

namespace makeChange.Migrations
{
    public partial class OneToManyMapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Petitions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Petitions_ApplicationUserId",
                table: "Petitions",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Petitions_AspNetUsers_ApplicationUserId",
                table: "Petitions",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Petitions_AspNetUsers_ApplicationUserId",
                table: "Petitions");

            migrationBuilder.DropIndex(
                name: "IX_Petitions_ApplicationUserId",
                table: "Petitions");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Petitions");
        }
    }
}
