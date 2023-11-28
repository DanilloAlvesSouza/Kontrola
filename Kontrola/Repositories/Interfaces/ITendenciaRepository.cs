using KontrolaPoc.Models;

namespace KontrolaPoc.Repositories.Interfaces
{
    public interface ITendenciaRepository
    {
        IEnumerable<Tendencia> Tendencias { get; }
    }
}
