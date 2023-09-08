using KontrolaPoc.Models;

namespace KontrolaPoc.Repositories.Interfaces
{
    public interface IEquipamentoRepository
    {
        IEnumerable<Equipamento> Equipamentos { get; }
    }
}
