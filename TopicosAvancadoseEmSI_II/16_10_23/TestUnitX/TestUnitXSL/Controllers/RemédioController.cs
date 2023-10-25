using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestUnitXSL.Data;
using TestUnitXSL.Models;

namespace TestUnitXSL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RemédioController : ControllerBase
    {
        private readonly TestUnitXSLContext _context;

        public RemédioController(TestUnitXSLContext context)
        {
            _context = context;
        }

        // GET: api/Remédio
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Remédio>>> GetRemédio()
        {
          if (_context.Remédio == null)
          {
              return NotFound();
          }
            return await _context.Remédio.ToListAsync();
        }

        // GET: api/Remédio/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Remédio>> GetRemédio(int id)
        {
          if (_context.Remédio == null)
          {
              return NotFound();
          }
            var remédio = await _context.Remédio.FindAsync(id);

            if (remédio == null)
            {
                return NotFound();
            }

            return remédio;
        }

        // PUT: api/Remédio/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRemédio(int id, Remédio remédio)
        {
            if (id != remédio.Id)
            {
                return BadRequest();
            }

            _context.Entry(remédio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RemédioExists(id))
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

        // POST: api/Remédio
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Remédio>> PostRemédio(Remédio remédio)
        {
          if (_context.Remédio == null)
          {
              return Problem("Entity set 'TestUnitXSLContext.Remédio'  is null.");
          }
            _context.Remédio.Add(remédio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRemédio", new { id = remédio.Id }, remédio);
        }

        // DELETE: api/Remédio/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRemédio(int id)
        {
            if (_context.Remédio == null)
            {
                return NotFound();
            }
            var remédio = await _context.Remédio.FindAsync(id);
            if (remédio == null)
            {
                return NotFound();
            }

            _context.Remédio.Remove(remédio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RemédioExists(int id)
        {
            return (_context.Remédio?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
