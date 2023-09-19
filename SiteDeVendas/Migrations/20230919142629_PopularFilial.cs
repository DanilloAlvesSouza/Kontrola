using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KontrolaPoc.Migrations
{
    /// <inheritdoc />
    public partial class PopularFilial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Filiais(Descricao,ClienteId) VALUES('Campus Centro',1)");
            migrationBuilder.Sql("INSERT INTO Filiais(Descricao,ClienteId) VALUES('Campus Barcelona',2)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Filial");
        }
    }
}
