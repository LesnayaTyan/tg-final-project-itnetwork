using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProjectInsurance_TG.Migrations
{
    public partial class CommentForForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insurance_Customer_CustomerId",
                table: "Insurance");

            migrationBuilder.DropIndex(
                name: "IX_Insurance_CustomerId",
                table: "Insurance");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Insurance");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Insurance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_CustomerId",
                table: "Insurance",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Insurance_Customer_CustomerId",
                table: "Insurance",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
