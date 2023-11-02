using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1372556_ProjetFinal.Migrations
{
    public partial class TP22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Prix",
                table: "Jeux",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prix",
                table: "Jeux");
        }
    }
}
