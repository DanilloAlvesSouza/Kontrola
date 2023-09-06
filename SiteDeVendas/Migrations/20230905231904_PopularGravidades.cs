using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KontrolaPoc.Migrations
{
    /// <inheritdoc />
    public partial class PopularGravidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Gravidades(Descricao)" +
                "VALUES('Sem gravidade')");
            migrationBuilder.Sql("INSERT INTO Gravidades(Descricao)" +
                "VALUES('Pouco grave')");
            migrationBuilder.Sql("INSERT INTO Gravidades(Descricao)" +
                "VALUES('Grave')");
            migrationBuilder.Sql("INSERT INTO Gravidades(Descricao)" +
                "VALUES('Muito Grave')");
            migrationBuilder.Sql("INSERT INTO Gravidades(Descricao)" +
                "VALUES('Extremamente grave')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Gravidades");
        }
    }
}
