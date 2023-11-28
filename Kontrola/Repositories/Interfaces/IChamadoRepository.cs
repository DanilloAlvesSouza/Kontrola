using KontrolaPoc.Models;

namespace KontrolaPoc.Repositories.Interfaces
{
    public interface IChamadoRepository
    {
        IEnumerable<Chamado> Chamados { get; }

        //Chamado GetChamadoById(int chamadoId);
        //IEnumerable<Chamado> ChamadoStatus { get; }
        //IEnumerable<Chamado> ChamadosDataInicio { get; }
        //IEnumerable<Chamado> ChamadosDescricao { get; }
        //IEnumerable<Chamado> ChamadosModalidade { get; }
        //IEnumerable<Chamado> ChamadosGravidade { get; }
        //IEnumerable<Chamado> ChamadoUrgencia { get; }
    }
}
