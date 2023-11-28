using KontrolaPoc.Models;

namespace KontrolaPoc.Repositories.Interfaces
{
    public interface IItemChamadoRepository
    {
        IEnumerable<ItemChamado> ItemChamados {  get; }
    }
}
