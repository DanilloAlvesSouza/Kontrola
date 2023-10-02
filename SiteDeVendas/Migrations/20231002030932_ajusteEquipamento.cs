using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KontrolaPoc.Migrations
{
    /// <inheritdoc />
    public partial class ajusteEquipamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipamentos_Filiais_FilialId",
                table: "Equipamentos");

            migrationBuilder.RenameColumn(
                name: "FilialId",
                table: "Equipamentos",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Equipamentos_FilialId",
                table: "Equipamentos",
                newName: "IX_Equipamentos_ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamentos_Cliente_ClienteId",
                table: "Equipamentos",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipamentos_Cliente_ClienteId",
                table: "Equipamentos");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Equipamentos",
                newName: "FilialId");

            migrationBuilder.RenameIndex(
                name: "IX_Equipamentos_ClienteId",
                table: "Equipamentos",
                newName: "IX_Equipamentos_FilialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamentos_Filiais_FilialId",
                table: "Equipamentos",
                column: "FilialId",
                principalTable: "Filiais",
                principalColumn: "FilialId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
