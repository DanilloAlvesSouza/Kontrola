using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KontrolaPoc.Context;
using KontrolaPoc.Models;
using KontrolaPoc.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using ReflectionIT.Mvc.Paging;

namespace KontrolaPoc.Controllers
{
    public class EquipamentosController : Controller
    {
        private readonly IEquipamentoRepository _equipamentoRepository;
        private readonly AppDbContext _context;

        public EquipamentosController(IEquipamentoRepository equipamentoRepository, 
            AppDbContext context)
        {
            _equipamentoRepository = equipamentoRepository;
            _context = context;
        }
        [Authorize]
        // GET: Equipamentos
        //public async Task<IActionResult> Index()
        //{

        //        var appDbContext = _context.Equipamentos.Include(e => e.Cliente);
        //        return View(await appDbContext.ToListAsync());            
        //}

        public async Task<IActionResult> Index(string filter, int pageindex = 1, string sort = "NumeroSerie")
        {

            var resultado = _context.Equipamentos.Include(e => e.Filial).AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter))
            {
                resultado = resultado.Where(p => p.NumeroSerie.Contains(filter));
            }

            var model = await PagingList.CreateAsync(resultado, 5, pageindex, sort, "NumeroSerie");
            model.RouteValue = new RouteValueDictionary { { "filter", filter } };

            return View(model);
        }


            // GET: Equipamentos/Details/5
            public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Equipamentos == null)
            {
                return NotFound();
            }

            var equipamento = await _context.Equipamentos
                .Include(e => e.Filial)
                .FirstOrDefaultAsync(m => m.EquipamentoId == id);
            if (equipamento == null)
            {
                return NotFound();
            }

            return View(equipamento);
        }

        // GET: Equipamentos/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "Nome");
            return View();
        }

        // POST: Equipamentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EquipamentoId,Marca,Modelo,NumeroSerie,Potencia,ClienteId")] Equipamento equipamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "Cnpj", equipamento.FilialId);
            return View(equipamento);
        }

        // GET: Equipamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Equipamentos == null)
            {
                return NotFound();
            }

            var equipamento = await _context.Equipamentos.FindAsync(id);
            if (equipamento == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "Nome", equipamento.FilialId);
            return View(equipamento);
        }

        // POST: Equipamentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EquipamentoId,Marca,Modelo,NumeroSerie,Potencia,ImagemUrl,ClienteId")] Equipamento equipamento)
        {
            if (id != equipamento.EquipamentoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipamentoExists(equipamento.EquipamentoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "Cnpj", equipamento.FilialId);
            return View(equipamento);
        }

        // GET: Equipamentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Equipamentos == null)
            {
                return NotFound();
            }

            var equipamento = await _context.Equipamentos
                .Include(e => e.Filial)
                .FirstOrDefaultAsync(m => m.EquipamentoId == id);
            if (equipamento == null)
            {
                return NotFound();
            }

            return View(equipamento);
        }

        // POST: Equipamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Equipamentos == null)
            {
                return Problem("Entity set 'AppDbContext.Equipamentos'  is null.");
            }
            var equipamento = await _context.Equipamentos.FindAsync(id);
            if (equipamento != null)
            {
                _context.Equipamentos.Remove(equipamento);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipamentoExists(int id)
        {
          return _context.Equipamentos.Any(e => e.EquipamentoId == id);
        }

        //public ViewResult Search(string searchString)
        //{
        //    IEnumerable<Equipamento> equipamentos;
        //    string searchEquipamento = string.Empty;

        //    if(string.IsNullOrEmpty(searchString))
        //    {
        //        equipamentos = _context.Equipamentos.OrderBy(e => e.EquipamentoId);
        //    }
        //}
    }
}
