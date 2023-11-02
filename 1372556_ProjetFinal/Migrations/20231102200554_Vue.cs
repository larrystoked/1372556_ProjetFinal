using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1372556_ProjetFinal.Migrations
{
    public partial class Vue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JeuxComplexs",
                columns: table => new
                {
                    IdJeux = table.Column<int>(type: "int", nullable: false),
                    NomJeu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateSortie = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    IdGeneration = table.Column<int>(type: "int", nullable: true),
                    NomGeneration = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JeuxComplexs");
        }
    }
}
