using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KontrolaPoc.Migrations
{
    /// <inheritdoc />
    public partial class ajusteEquipamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Equipamentos_Filiais_FilialId",
            //    table: "Equipamentos");

            migrationBuilder.DropColumn(
                name: "ImagemUrl",
                table: "Equipamentos");

            //migrationBuilder.RenameColumn(
            //    name: "FilialId",
            //    table: "Equipamentos",
            //    newName: "ClienteId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Equipamentos_FilialId",
            //    table: "Equipamentos",
            //    newName: "IX_Equipamentos_ClienteId");

            migrationBuilder.AlterColumn<string>(
                name: "Potencia",
                table: "Equipamentos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NumeroSerie",
                table: "Equipamentos",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Equipamentos",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Equipamentos",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Equipamentos_Cliente_ClienteId",
            //    table: "Equipamentos",
            //    column: "ClienteId",
            //    principalTable: "Cliente",
            //    principalColumn: "ClienteId",
            //    onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.AlterColumn<string>(
                name: "Potencia",
                table: "Equipamentos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroSerie",
                table: "Equipamentos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Equipamentos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Equipamentos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<string>(
                name: "ImagemUrl",
                table: "Equipamentos",
                type: "nvarchar(max)",
                nullable: true);

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
