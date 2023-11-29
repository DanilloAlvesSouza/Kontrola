using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KontrolaPoc.Context;
using KontrolaPoc.Models;

namespace KontrolaPoc.Controllers
{
    public class FiliaisController : Controller
    {
        private readonly AppDbContext _context;

        public FiliaisController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Filiais
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Filiais.Include(f => f.Cliente);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Filiais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Filiais == null)
            {
                return NotFound();
            }

            var filial = await _context.Filiais
                .Include(f => f.Cliente)
                .FirstOrDefaultAsync(m => m.FilialId == id);
            if (filial == null)
            {
                return NotFound();
            }

            return View(filial);
        }

        // GET: Filiais/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "Cnpj");
            return View();
        }

        // POST: Filiais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FilialId,Descricao,ClienteId")] Filial filial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(filial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "Cnpj", filial.ClienteId);
            return View(filial);
        }

        // GET: Filiais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Filiais == null)
            {
                return NotFound();
            }

            var filial = await _context.Filiais.FindAsync(id);
            if (filial == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "Cnpj", filial.ClienteId);
            return View(filial);
        }

        // POST: Filiais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FilialId,Descricao,ClienteId")] Filial filial)
        {
            if (id != filial.FilialId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(filial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilialExists(filial.FilialId))
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
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "Cnpj", filial.ClienteId);
            return View(filial);
        }

        // GET: Filiais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Filiais == null)
            {
                return NotFound();
            }

            var filial = await _context.Filiais
                .Include(f => f.Cliente)
                .FirstOrDefaultAsync(m => m.FilialId == id);
            if (filial == null)
            {
                return NotFound();
            }

            return View(filial);
        }

        // POST: Filiais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Filiais == null)
            {
                return Problem("Entity set 'AppDbContext.Filiais'  is null.");
            }
            var filial = await _context.Filiais.FindAsync(id);
            if (filial != null)
            {
                _context.Filiais.Remove(filial);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilialExists(int id)
        {
          return _context.Filiais.Any(e => e.FilialId == id);
        }
    }
}
