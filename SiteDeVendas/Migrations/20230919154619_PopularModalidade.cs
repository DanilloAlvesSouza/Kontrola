using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KontrolaPoc.Migrations
{
    /// <inheritdoc />
    public partial class PopularModalidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Modalidades(Descricao) Values('Preventiva')");
            migrationBuilder.Sql("INSERT INTO Modalidades(Descricao) Values('Corretiva')");
            migrationBuilder.Sql("INSERT INTO Modalidades(Descricao) Values('Preditiva')");
            migrationBuilder.Sql("INSERT INTO Modalidades(Descricao) Values('Verificação')");
            migrationBuilder.Sql("INSERT INTO Modalidades(Descricao) Values('Vistoria')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Modalidades");
        }
    }
}
