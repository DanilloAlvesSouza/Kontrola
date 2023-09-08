using KontrolaPoc.Models;

namespace KontrolaPoc.Repositories.Interfaces
{
    public interface IStatusRepository
    {
        IEnumerable<Status> Status { get; }
    }
}
