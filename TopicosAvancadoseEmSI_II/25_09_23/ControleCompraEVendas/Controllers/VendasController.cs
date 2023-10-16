using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControleCompraEVendas.Data;
using ControleCompraEVendas.Models;

namespace ControleCompraEVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : ControllerBase
    {
        private readonly ControleCompraEVendasContext _context;

        public VendasController(ControleCompraEVendasContext context)
        {
            _context = context;
        }

        // GET: api/Vendas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vendas>>> GetVendas()
        {
          if (_context.Vendas == null)
          {
              return NotFound();
          }
            return await _context.Vendas.Include(v => v.cliente).Include(v => v.produto).ToListAsync();
        }

        // GET: api/Vendas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vendas>> GetVendas(int id)
        {
          if (_context.Vendas == null)
          {
              return NotFound();
          }
            var vendas = await _context.Vendas.Include(v => v.cliente).Include(v => v.produto).Where(v => v.Id == id).FirstOrDefaultAsync();

            if (vendas == null)
            {
                return NotFound();
            }

            return vendas;
        }

        // PUT: api/Vendas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVendas(int id, Vendas vendas)
        {
            if (id != vendas.Id)
            {
                return BadRequest();
            }

            _context.Entry(vendas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Vendas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vendas>> PostVendas(int IdCliente, int IdProduto, int vendido)
        {
          if (_context.Vendas == null || _context.Produtos == null)
          {
              return Problem("Entity set 'ControleCompraEVendasContext.Vendas'  is null.");
          }
            if (vendido <= 0)
            {
                return BadRequest("O valor não pode ser negativo ou igual a zero");
            }
           
            Produtos? produtos = await _context.Produtos.FirstOrDefaultAsync(p => p.Id == IdProduto);
          
            if (vendido == null)
                return NotFound("Nenhum produto em estoque!");

            Clientes? cliente = await _context.Clientes.FindAsync(IdCliente);
            if (cliente == null)
            {
                return NotFound("Cliente não encontrado!");
            }

            Produtos? produto = await _context.Produtos.FindAsync(IdProduto);
            if (produto == null)
            {
                return NotFound("Nenhum Produto registrado");
            }

            Vendas venda = new Vendas()
            {
                cliente = cliente,
                produto = produto,
                vendidos = vendido
            };

            if (vendido > produtos.estoque)
            {
                return BadRequest();
            }

            produtos.BaixarEstoque(vendido);

            _context.Produtos.Update(produtos);
            _context.Vendas.Add(venda);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVendas", new { id = venda.Id }, venda);
        }

        // DELETE: api/Vendas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVendas(int id)
        {
            if (_context.Vendas == null)
            {
                return NotFound();
            }
            var vendas = await _context.Vendas.FindAsync(id);
            if (vendas == null)
            {
                return NotFound();
            }

            _context.Vendas.Remove(vendas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VendasExists(int id)
        {
            return (_context.Vendas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
