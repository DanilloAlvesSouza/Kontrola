using KontrolaPoc.Models;

namespace KontrolaPoc.Repositories.Interfaces
{
    public interface IFilialRepository
    {
        IEnumerable<Filial> Filiais { get; }
    }
}
