using KontrolaPoc.Context;
using KontrolaPoc.Models;
using KontrolaPoc.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SiteDeVendas.Models;
using System.Diagnostics;

namespace KontrolaPoc.Repositories
{
    public class EquipamentoRepository : IEquipamentoRepository
    {
        private readonly AppDbContext _context;
        
        public EquipamentoRepository (AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Equipamento> Equipamentos => _context.Equipamentos;

        public Equipamento GetEquipamentoById(int EquipamentoId)
        {
            return _context.Equipamentos.FirstOrDefault(e => e.EquipamentoId == EquipamentoId);   
        }
    }
}
