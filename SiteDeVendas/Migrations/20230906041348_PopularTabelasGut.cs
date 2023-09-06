using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KontrolaPoc.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabelasGut : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Urgencias(Descricao)" +
                "VALUES('Pode esperar')");
            migrationBuilder.Sql("INSERT INTO Urgencias(Descricao)" +
                "VALUES('Pouco urgente')");
            migrationBuilder.Sql("INSERT INTO Urgencias(Descricao)" +
                "VALUES('Urgente, merece atenção no curto prazo')");
            migrationBuilder.Sql("INSERT INTO Urgencias(Descricao)" +
                "VALUES('Muito urgente')");
            migrationBuilder.Sql("INSERT INTO Urgencias(Descricao)" +
                "VALUES('Necessidade de ação imediata')");
            migrationBuilder.Sql("INSERT INTO Tendencias(Descricao)" +
                "VALUES('Não irá mudar')");
            migrationBuilder.Sql("INSERT INTO Tendencias(Descricao)" +
                "VALUES('Irá piorar a longo prazo')");
            migrationBuilder.Sql("INSERT INTO Tendencias(Descricao)" +
                "VALUES('Irá piorar a médio prazo')");
            migrationBuilder.Sql("INSERT INTO Tendencias(Descricao)" +
                "VALUES('Irá piorar a curto prazo')");
            migrationBuilder.Sql("INSERT INTO Tendencias(Descricao)" +
                "VALUES('Irá piorar rapidamente')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Urgencias");
            migrationBuilder.Sql("DELETE FROM Tendencias");
        }
    }
}
