using KontrolaPoc.Context;
using KontrolaPoc.Models;
using KontrolaPoc.Repositories.Interfaces;

namespace KontrolaPoc.Repositories
{
    public class FilialRepository : IFilialRepository
    {
        private readonly AppDbContext _context;

        public FilialRepository(AppDbContext context)
        {
             _context = context;
        }

        public IEnumerable<Filial> Filiais => _context.Filiais;

    }
}

