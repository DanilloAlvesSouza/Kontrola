using KontrolaPoc.Models;
using KontrolaPoc.Context;
using KontrolaPoc.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KontrolaPoc.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cliente> Clientes => _context.Clientes;
    }
}
