using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using P2_MVC_.Data;
using P2_MVC_.Models;

namespace P2_MVC_.Controllers
{
    public class ComprasClientesController : Controller
    {
        private readonly P2_MVC_Context _context;

        public ComprasClientesController(P2_MVC_Context context)
        {
            _context = context;
        }

        // GET: ComprasClientes
        public async Task<IActionResult> Index()
        {
              return _context.ComprasCliente != null ? 
                          View(await _context.ComprasCliente.ToListAsync()) :
                          Problem("Entity set 'P2_MVC_Context.ComprasCliente'  is null.");
        }

        // GET: ComprasClientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ComprasCliente == null)
            {
                return NotFound();
            }

            var comprasCliente = await _context.ComprasCliente
                .FirstOrDefaultAsync(m => m.CompraId == id);
            if (comprasCliente == null)
            {
                return NotFound();
            }

            return View(comprasCliente);
        }

        // GET: ComprasClientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComprasClientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompraId")] ComprasCliente comprasCliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comprasCliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comprasCliente);
        }

        // GET: ComprasClientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ComprasCliente == null)
            {
                return NotFound();
            }

            var comprasCliente = await _context.ComprasCliente.FindAsync(id);
            if (comprasCliente == null)
            {
                return NotFound();
            }
            return View(comprasCliente);
        }

        // POST: ComprasClientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompraId")] ComprasCliente comprasCliente)
        {
            if (id != comprasCliente.CompraId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comprasCliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComprasClienteExists(comprasCliente.CompraId))
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
            return View(comprasCliente);
        }

        // GET: ComprasClientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ComprasCliente == null)
            {
                return NotFound();
            }

            var comprasCliente = await _context.ComprasCliente
                .FirstOrDefaultAsync(m => m.CompraId == id);
            if (comprasCliente == null)
            {
                return NotFound();
            }

            return View(comprasCliente);
        }

        // POST: ComprasClientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ComprasCliente == null)
            {
                return Problem("Entity set 'P2_MVC_Context.ComprasCliente'  is null.");
            }
            var comprasCliente = await _context.ComprasCliente.FindAsync(id);
            if (comprasCliente != null)
            {
                _context.ComprasCliente.Remove(comprasCliente);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComprasClienteExists(int id)
        {
          return (_context.ComprasCliente?.Any(e => e.CompraId == id)).GetValueOrDefault();
        }
    }
}
