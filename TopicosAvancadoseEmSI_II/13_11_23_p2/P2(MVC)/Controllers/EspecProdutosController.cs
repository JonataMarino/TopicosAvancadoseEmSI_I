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
    public class EspecProdutosController : Controller
    {
        private readonly P2_MVC_Context _context;

        public EspecProdutosController(P2_MVC_Context context)
        {
            _context = context;
        }

        // GET: EspecProdutos
        public async Task<IActionResult> Index()
        {
              return _context.EspecProdutos != null ? 
                          View(await _context.EspecProdutos.ToListAsync()) :
                          Problem("Entity set 'P2_MVC_Context.EspecProdutos'  is null.");
        }

        // GET: EspecProdutos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.EspecProdutos == null)
            {
                return NotFound();
            }

            var especProdutos = await _context.EspecProdutos
                .FirstOrDefaultAsync(m => m.IdEspec == id);
            if (especProdutos == null)
            {
                return NotFound();
            }

            return View(especProdutos);
        }

        // GET: EspecProdutos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EspecProdutos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEspec,NomeProduto,Fabricante,PrecoProduto")] EspecProdutos especProdutos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(especProdutos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(especProdutos);
        }

        // GET: EspecProdutos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.EspecProdutos == null)
            {
                return NotFound();
            }

            var especProdutos = await _context.EspecProdutos.FindAsync(id);
            if (especProdutos == null)
            {
                return NotFound();
            }
            return View(especProdutos);
        }

        // POST: EspecProdutos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEspec,NomeProduto,Fabricante,PrecoProduto")] EspecProdutos especProdutos)
        {
            if (id != especProdutos.IdEspec)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(especProdutos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EspecProdutosExists(especProdutos.IdEspec))
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
            return View(especProdutos);
        }

        // GET: EspecProdutos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.EspecProdutos == null)
            {
                return NotFound();
            }

            var especProdutos = await _context.EspecProdutos
                .FirstOrDefaultAsync(m => m.IdEspec == id);
            if (especProdutos == null)
            {
                return NotFound();
            }

            return View(especProdutos);
        }

        // POST: EspecProdutos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.EspecProdutos == null)
            {
                return Problem("Entity set 'P2_MVC_Context.EspecProdutos'  is null.");
            }
            var especProdutos = await _context.EspecProdutos.FindAsync(id);
            if (especProdutos != null)
            {
                _context.EspecProdutos.Remove(especProdutos);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EspecProdutosExists(int id)
        {
          return (_context.EspecProdutos?.Any(e => e.IdEspec == id)).GetValueOrDefault();
        }
    }
}
