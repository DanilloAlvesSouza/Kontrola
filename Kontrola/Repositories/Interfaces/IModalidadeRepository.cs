using KontrolaPoc.Models;

namespace KontrolaPoc.Repositories.Interfaces
{
    public interface IModalidadeRepository
    {
        IEnumerable<Modalidade> Modalidades { get; }
    }
}
