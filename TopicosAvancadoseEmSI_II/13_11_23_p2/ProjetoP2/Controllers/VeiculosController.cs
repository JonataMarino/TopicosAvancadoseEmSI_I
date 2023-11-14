using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoP2.Data;
using ProjetoP2.Models;

namespace ProjetoP2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private readonly ProjetoP2Context _context;

        public VeiculosController(ProjetoP2Context context)
        {
            _context = context;
        }

        // GET: api/Veiculos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Veiculos>>> GetVeiculos()
        {
          if (_context.Veiculos == null)
          {
              return NotFound();
          }
            return await _context.Veiculos.ToListAsync();
        }

        // GET: api/Veiculos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Veiculos>> GetVeiculos(int id)
        {
          if (_context.Veiculos == null)
          {
              return NotFound();
          }
            var veiculos = await _context.Veiculos.FindAsync(id);

            if (veiculos == null)
            {
                return NotFound();
            }

            return veiculos;
        }

        // PUT: api/Veiculos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVeiculos(int id, Veiculos veiculos)
        {
            if (id != veiculos.Id)
            {
                return BadRequest();
            }

            _context.Entry(veiculos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VeiculosExists(id))
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

        // POST: api/Veiculos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Veiculos>> PostVeiculos(Veiculos veiculos)
        {
          if (_context.Veiculos == null)
          {
              return Problem("Entity set 'ProjetoP2Context.Veiculos'  is null.");
          }
            _context.Veiculos.Add(veiculos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVeiculos", new { id = veiculos.Id }, veiculos);
        }

        // DELETE: api/Veiculos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVeiculos(int id)
        {
            if (_context.Veiculos == null)
            {
                return NotFound();
            }
            var veiculos = await _context.Veiculos.FindAsync(id);
            if (veiculos == null)
            {
                return NotFound();
            }

            _context.Veiculos.Remove(veiculos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VeiculosExists(int id)
        {
            return (_context.Veiculos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
