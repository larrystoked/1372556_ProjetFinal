using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1372556_ProjetFinal.Migrations
{
    public partial class View : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "CREATE VIEW JeuxComplex AS " +
                "SELECT J.IdJeux, J.NomJeu, J.DateSortie, J.Age, J.IdGeneration, G.Nom " +
                "FROM Jeux J " +
                "JOIN Generation G ON J.IdGeneration = G.IdGeneration");
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
