using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KontrolaPoc.Migrations
{
    /// <inheritdoc />
    public partial class PopularItemChamados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO ItemChamados(ChamadoId,EquipamentoId) VALUES(7,1)");
            migrationBuilder.Sql("INSERT INTO ItemChamados(ChamadoId,EquipamentoId) VALUES(8,2)");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM ItemChamados");
        }
    }
}
