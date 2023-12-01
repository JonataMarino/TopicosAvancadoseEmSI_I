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
    public class EstoqueProdutoesController : Controller
    {
        private readonly P2_MVC_Context _context;

        public EstoqueProdutoesController(P2_MVC_Context context)
        {
            _context = context;
        }

        // GET: EstoqueProdutoes
        public async Task<IActionResult> Index()
        {
              return _context.EstoqueProduto != null ? 
                          View(await _context.EstoqueProduto.ToListAsync()) :
                          Problem("Entity set 'P2_MVC_Context.EstoqueProduto'  is null.");
        }

        // GET: EstoqueProdutoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.EstoqueProduto == null)
            {
                return NotFound();
            }

            var estoqueProduto = await _context.EstoqueProduto
                .FirstOrDefaultAsync(m => m.IdProduto == id);
            if (estoqueProduto == null)
            {
                return NotFound();
            }

            return View(estoqueProduto);
        }

        // GET: EstoqueProdutoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstoqueProdutoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdProduto,Id_Estoque,QuantidadeEstoque")] EstoqueProduto estoqueProduto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estoqueProduto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estoqueProduto);
        }

        // GET: EstoqueProdutoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.EstoqueProduto == null)
            {
                return NotFound();
            }

            var estoqueProduto = await _context.EstoqueProduto.FindAsync(id);
            if (estoqueProduto == null)
            {
                return NotFound();
            }
            return View(estoqueProduto);
        }

        // POST: EstoqueProdutoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdProduto,Id_Estoque,QuantidadeEstoque")] EstoqueProduto estoqueProduto)
        {
            if (id != estoqueProduto.IdProduto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estoqueProduto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstoqueProdutoExists(estoqueProduto.IdProduto))
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
            return View(estoqueProduto);
        }

        // GET: EstoqueProdutoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.EstoqueProduto == null)
            {
                return NotFound();
            }

            var estoqueProduto = await _context.EstoqueProduto
                .FirstOrDefaultAsync(m => m.IdProduto == id);
            if (estoqueProduto == null)
            {
                return NotFound();
            }

            return View(estoqueProduto);
        }

        // POST: EstoqueProdutoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.EstoqueProduto == null)
            {
                return Problem("Entity set 'P2_MVC_Context.EstoqueProduto'  is null.");
            }
            var estoqueProduto = await _context.EstoqueProduto.FindAsync(id);
            if (estoqueProduto != null)
            {
                _context.EstoqueProduto.Remove(estoqueProduto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstoqueProdutoExists(int id)
        {
          return (_context.EstoqueProduto?.Any(e => e.IdProduto == id)).GetValueOrDefault();
        }
    }
}
