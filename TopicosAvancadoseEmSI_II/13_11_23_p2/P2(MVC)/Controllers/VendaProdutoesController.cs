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
    public class VendaProdutoesController : Controller
    {
        private readonly P2_MVC_Context _context;

        public VendaProdutoesController(P2_MVC_Context context)
        {
            _context = context;
        }

        // GET: VendaProdutoes
        public async Task<IActionResult> Index()
        {
              return _context.VendaProduto != null ? 
                          View(await _context.VendaProduto.ToListAsync()) :
                          Problem("Entity set 'P2_MVC_Context.VendaProduto'  is null.");
        }

        // GET: VendaProdutoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.VendaProduto == null)
            {
                return NotFound();
            }

            var vendaProduto = await _context.VendaProduto
                .FirstOrDefaultAsync(m => m.IdVenda == id);
            if (vendaProduto == null)
            {
                return NotFound();
            }

            return View(vendaProduto);
        }

        // GET: VendaProdutoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendaProdutoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVenda,ValorVenda")] VendaProduto vendaProduto)
        {
            if (ModelState.IsValid)
            {
                if (vendaProduto.ValorVenda >= 0)
                {
                    ModelState.AddModelError("ValorVenda", "O Valor da Venda deve ser maior que zero.");
                }
                _context.Add(vendaProduto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendaProduto);
        }

        // GET: VendaProdutoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.VendaProduto == null)
            {
                return NotFound();
            }

            var vendaProduto = await _context.VendaProduto.FindAsync(id);
            if (vendaProduto == null)
            {
                return NotFound();
            }
            return View(vendaProduto);
        }

        // POST: VendaProdutoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVenda,ValorVenda")] VendaProduto vendaProduto)
        {
            if (id != vendaProduto.IdVenda)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendaProduto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendaProdutoExists(vendaProduto.IdVenda))
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
            return View(vendaProduto);
        }

        // GET: VendaProdutoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.VendaProduto == null)
            {
                return NotFound();
            }

            var vendaProduto = await _context.VendaProduto
                .FirstOrDefaultAsync(m => m.IdVenda == id);
            if (vendaProduto == null)
            {
                return NotFound();
            }

            return View(vendaProduto);
        }

        // POST: VendaProdutoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.VendaProduto == null)
            {
                return Problem("Entity set 'P2_MVC_Context.VendaProduto'  is null.");
            }
            var vendaProduto = await _context.VendaProduto.FindAsync(id);
            if (vendaProduto != null)
            {
                _context.VendaProduto.Remove(vendaProduto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendaProdutoExists(int id)
        {
          return (_context.VendaProduto?.Any(e => e.IdVenda == id)).GetValueOrDefault();
        }
    }
}
