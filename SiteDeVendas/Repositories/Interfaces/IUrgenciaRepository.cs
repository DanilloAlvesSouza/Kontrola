using KontrolaPoc.Models;

namespace KontrolaPoc.Repositories.Interfaces
{
    public interface IUrgenciaRepository
    {
        IEnumerable<Urgencia> Urgencias { get; }
    }
}
