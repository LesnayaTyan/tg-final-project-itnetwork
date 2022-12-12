using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProjectInsurance_TG.Migrations
{
    public partial class _1NewInsuranceModelAndNewCustomerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jmeno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prijmeni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ulice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mesto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PSC = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Insurance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pojisteni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Castka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PredmetPojisteni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlatnostOd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlatnostDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Insurance_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_CustomerId",
                table: "Insurance",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Insurance");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
