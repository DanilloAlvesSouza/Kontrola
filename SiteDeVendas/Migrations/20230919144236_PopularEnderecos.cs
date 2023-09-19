using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KontrolaPoc.Migrations
{
    /// <inheritdoc />
    public partial class PopularEnderecos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Enderecos(Logradouro,Cep,Bairro,Cidade,UF,FilialId)" +
                                "VALUES('Rua Conceicao 321',09530060,'Santo Antonio','São Caetano do Sul','SP',2)");
            migrationBuilder.Sql("INSERT INTO Enderecos(Logradouro,Cep,Bairro,Cidade,UF,FilialId)" +
                                "VALUES('Santo Antonio 50',09521160,'Centro','São Caetano do Sul','SP',1)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Enderecos");
        }
    }
}
