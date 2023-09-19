using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KontrolaPoc.Migrations
{
    /// <inheritdoc />
    public partial class PopularCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Cliente(Nome,Cnpj) VALUES('USCS','12.345.678/0001-10')");
            migrationBuilder.Sql("INSERT INTO Cliente(Nome,Cnpj) VALUES('Faculdade','18.246.654/0001-50')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filiais_Cliente_ClienteId",
                table: "Filiais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Lanches");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lanches",
                table: "Lanches",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Filiais_Lanches_ClienteId",
                table: "Filiais",
                column: "ClienteId",
                principalTable: "Lanches",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
