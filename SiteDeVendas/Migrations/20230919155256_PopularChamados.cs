using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KontrolaPoc.Migrations
{
    /// <inheritdoc />
    public partial class PopularChamados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Chamados(DataInicio,DataFechamento,Descricao,StatusId,ModalidadeId,GravidadeId,UrgenciaId,TendenciaId,Diagnostico)" +
                                "VALUES('2023-09-29 10:40:00','2023-09-29 11:40:00','Equipamento com falha intermitente',2,9,2,2,2,'Preencher Diagnostico')");
            migrationBuilder.Sql("INSERT INTO Chamados(DataInicio,DataFechamento,Descricao,StatusId,ModalidadeId,GravidadeId,UrgenciaId,TendenciaId,Diagnostico)" +
                                "VALUES('2023-10-29 19:40:00','2023-10-29 20:40:00','Equipamento Inoperente',2,8,3,3,3,'Preencher Diagnostico')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Chamados");
        }
    }
}
