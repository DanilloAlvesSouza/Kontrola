using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KontrolaPoc.Migrations
{
    /// <inheritdoc />
    public partial class SegundoAjusteTabelacliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Cliente",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,0)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Cep",
                table: "Cliente",
                type: "decimal(8,0)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);
        }
    }
}
