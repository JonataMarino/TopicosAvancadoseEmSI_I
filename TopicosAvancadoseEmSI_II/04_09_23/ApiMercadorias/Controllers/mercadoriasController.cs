using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiMercadorias.Data;
using ApiMercadorias.Models;

namespace ApiMercadorias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mercadoriasController : ControllerBase
    {
        private readonly ApiMercadoriasContext _context;

        public mercadoriasController(ApiMercadoriasContext context)
        {
            _context = context;
        }

        // GET: api/mercadorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<mercadoria>>> Getmercadoria()
        {
          if (_context.mercadoria == null)
          {
              return NotFound();
          }
            return await _context.mercadoria.ToListAsync();
        }

        // GET: api/mercadorias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<mercadoria>> Getmercadoria(int id)
        {
          if (_context.mercadoria == null)
          {
              return NotFound();
          }
            var mercadoria = await _context.mercadoria.FindAsync(id);

            if (mercadoria == null)
            {
                return NotFound();
            }

            return mercadoria;
        }

        // PUT: api/mercadorias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putmercadoria(int id, mercadoria mercadoria)
        {
            if (id != mercadoria.Id)
            {
                return BadRequest();
            }

            _context.Entry(mercadoria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!mercadoriaExists(id))
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

        // POST: api/mercadorias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<mercadoria>> Postmercadoria(mercadoria mercadoria)
        {
          if (_context.mercadoria == null)
          {
              return Problem("Entity set 'ApiMercadoriasContext.mercadoria'  is null.");
          }
            _context.mercadoria.Add(mercadoria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getmercadoria", new { id = mercadoria.Id }, mercadoria);
        }

        // DELETE: api/mercadorias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletemercadoria(int id)
        {
            if (_context.mercadoria == null)
            {
                return NotFound();
            }
            var mercadoria = await _context.mercadoria.FindAsync(id);
            if (mercadoria == null)
            {
                return NotFound();
            }

            _context.mercadoria.Remove(mercadoria);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool mercadoriaExists(int id)
        {
            return (_context.mercadoria?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
