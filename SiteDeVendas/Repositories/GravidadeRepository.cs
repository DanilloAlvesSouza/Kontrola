using KontrolaPoc.Context;
using KontrolaPoc.Models;
using KontrolaPoc.Repositories.Interfaces;

namespace KontrolaPoc.Repositories
{
    public class GravidadeRepository : IGravidadeRepository
    {
        private readonly AppDbContext _context;

        public GravidadeRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Gravidade> Gravidades => _context.Gravidades;
    }
}
