using KontrolaPoc.Models;

namespace KontrolaPoc.Repositories.Interfaces
{
    public interface IGravidadeRepository
    {
        IEnumerable<Gravidade> Gravidades { get; }
    }
}
