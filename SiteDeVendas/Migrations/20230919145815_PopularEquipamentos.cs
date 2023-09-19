using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KontrolaPoc.Migrations
{
    /// <inheritdoc />
    public partial class PopularEquipamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Equipamentos(Marca,Modelo,NumeroSerie,Potencia,FilialId)" +
                "VALUES('APC','SURT15000XLI','XS152321544','15000VA',01)");
            migrationBuilder.Sql("INSERT INTO Equipamentos(Marca,Modelo,NumeroSerie,Potencia,FilialId)" +
                "VALUES('ENGETRON','DWMM20','26254856','20000VA',02)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Equipamentos");
        }
    }
}
