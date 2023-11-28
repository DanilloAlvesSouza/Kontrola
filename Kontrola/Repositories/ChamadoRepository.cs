using KontrolaPoc.Context;
using KontrolaPoc.Models;
using KontrolaPoc.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KontrolaPoc.Repositories
{
    public class ChamadoRepository : IChamadoRepository
    {
        private readonly AppDbContext _context;

        public ChamadoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Chamado> Chamados => _context.Chamados;


        //public IEnumerable<Chamado> Chamados => _context.Chamados.Include(c =>c.Status)
        //.Include(c => c.DataInicio.ToString()).Include(c => c.DataFechamento.ToString());

        //public Chamado GetChamadoById(int chamadoId) => _context.Chamados.FirstOrDefault(I => I.ChamadoId == chamadoId);
    }
}
