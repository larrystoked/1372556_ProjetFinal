using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1372556_ProjetFinal.Migrations
{
    public partial class Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dresseur",
                columns: table => new
                {
                    idDresseur = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    prenom = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    badgeCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Dresseur__A18A258796FF75EA", x => x.idDresseur);
                });

            migrationBuilder.CreateTable(
                name: "DresseurPokemon",
                columns: table => new
                {
                    IdDresseur = table.Column<int>(type: "int", nullable: false),
                    IdPokemon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DresseurPokemon", x => new { x.IdDresseur, x.IdPokemon });
                });

            migrationBuilder.CreateTable(
                name: "Generation",
                columns: table => new
                {
                    idGeneration = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numero = table.Column<int>(type: "int", nullable: false),
                    nom = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    nombreJeux = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Generati__B9B517B5C22F9B78", x => x.idGeneration);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    idType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomType = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Type__4BB98BC6ED3EF932", x => x.idType);
                });

            migrationBuilder.CreateTable(
                name: "Jeux",
                columns: table => new
                {
                    idJeux = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomJeu = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    dateSortie = table.Column<DateTime>(type: "date", nullable: true),
                    age = table.Column<int>(type: "int", nullable: true),
                    idGeneration = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Jeux__1087CF56308CDE1D", x => x.idJeux);
                    table.ForeignKey(
                        name: "fk_Generation_jeux",
                        column: x => x.idGeneration,
                        principalTable: "Generation",
                        principalColumn: "idGeneration");
                });

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    idPokemon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    niveau = table.Column<int>(type: "int", nullable: true),
                    idGeneration = table.Column<int>(type: "int", nullable: true),
                    niveauParDefaut = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Pokemon__653EBD85BAB59545", x => x.idPokemon);
                    table.ForeignKey(
                        name: "fk_Generation",
                        column: x => x.idGeneration,
                        principalTable: "Generation",
                        principalColumn: "idGeneration");
                });

            migrationBuilder.CreateTable(
                name: "Pokemon_Dresseur",
                columns: table => new
                {
                    idPokemon = table.Column<int>(type: "int", nullable: false),
                    idDresseur = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Pokemon___0F261FDD8599F6D7", x => new { x.idPokemon, x.idDresseur });
                    table.ForeignKey(
                        name: "fk_Dresseur",
                        column: x => x.idDresseur,
                        principalTable: "Dresseur",
                        principalColumn: "idDresseur");
                    table.ForeignKey(
                        name: "fk_Pokemon",
                        column: x => x.idPokemon,
                        principalTable: "Pokemon",
                        principalColumn: "idPokemon");
                });

            migrationBuilder.CreateTable(
                name: "PokemonTypes",
                columns: table => new
                {
                    idPokemon = table.Column<int>(type: "int", nullable: false),
                    idTypes = table.Column<int>(type: "int", nullable: false),
                    IdType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PokemonT__1185253979228652", x => new { x.idPokemon, x.idTypes });
                    table.ForeignKey(
                        name: "fk_Pokemon_type",
                        column: x => x.idPokemon,
                        principalTable: "Pokemon",
                        principalColumn: "idPokemon");
                    table.ForeignKey(
                        name: "fk_Type",
                        column: x => x.idTypes,
                        principalTable: "Type",
                        principalColumn: "idType");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jeux_idGeneration",
                table: "Jeux",
                column: "idGeneration");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_idGeneration",
                table: "Pokemon",
                column: "idGeneration");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Dresseur_idDresseur",
                table: "Pokemon_Dresseur",
                column: "idDresseur");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTypes_idTypes",
                table: "PokemonTypes",
                column: "idTypes");

            migrationBuilder.CreateIndex(
                name: "UQ__Type__C90762B7BEDFB1CC",
                table: "Type",
                column: "nomType",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DresseurPokemon");

            migrationBuilder.DropTable(
                name: "Jeux");

            migrationBuilder.DropTable(
                name: "Pokemon_Dresseur");

            migrationBuilder.DropTable(
                name: "PokemonTypes");

            migrationBuilder.DropTable(
                name: "Dresseur");

            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropTable(
                name: "Generation");
        }
    }
}
