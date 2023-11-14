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
    public class EletronicosController : ControllerBase
    {
        private readonly ProjetoP2Context _context;

        public EletronicosController(ProjetoP2Context context)
        {
            _context = context;
        }

        // GET: api/Eletronicos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eletronicos>>> GetEletronicos()
        {
          if (_context.Eletronicos == null)
          {
              return NotFound();
          }
            return await _context.Eletronicos.ToListAsync();
        }

        // GET: api/Eletronicos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eletronicos>> GetEletronicos(int id)
        {
          if (_context.Eletronicos == null)
          {
              return NotFound();
          }
            var eletronicos = await _context.Eletronicos.FindAsync(id);

            if (eletronicos == null)
            {
                return NotFound();
            }

            return eletronicos;
        }

        // PUT: api/Eletronicos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEletronicos(int id, Eletronicos eletronicos)
        {
            if (id != eletronicos.Id)
            {
                return BadRequest();
            }

            _context.Entry(eletronicos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EletronicosExists(id))
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

        // POST: api/Eletronicos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Eletronicos>> PostEletronicos(Eletronicos eletronicos)
        {
          if (_context.Eletronicos == null)
          {
              return Problem("Entity set 'ProjetoP2Context.Eletronicos'  is null.");
          }
            _context.Eletronicos.Add(eletronicos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEletronicos", new { id = eletronicos.Id }, eletronicos);
        }

        // DELETE: api/Eletronicos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEletronicos(int id)
        {
            if (_context.Eletronicos == null)
            {
                return NotFound();
            }
            var eletronicos = await _context.Eletronicos.FindAsync(id);
            if (eletronicos == null)
            {
                return NotFound();
            }

            _context.Eletronicos.Remove(eletronicos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EletronicosExists(int id)
        {
            return (_context.Eletronicos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
