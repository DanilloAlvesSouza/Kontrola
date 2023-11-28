using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KontrolaPoc.Migrations
{
    /// <inheritdoc />
    public partial class PopularStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Status(Descricao) VALUES('Pendente')");
            migrationBuilder.Sql("INSERT INTO Status(Descricao) VALUES('Agendado')");
            migrationBuilder.Sql("INSERT INTO Status(Descricao) VALUES('Em Andamento')");
            migrationBuilder.Sql("INSERT INTO Status(Descricao) VALUES('Concluido')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Status");
        }
    }
}
