﻿using System;
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
    public class FornecedoresController : ControllerBase
    {
        private readonly ControleCompraEVendasContext _context;

        public FornecedoresController(ControleCompraEVendasContext context)
        {
            _context = context;
        }

        // GET: api/Fornecedores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fornecedores>>> GetFornecedores()
        {
          if (_context.Fornecedores == null)
          {
              return NotFound();
          }
            return await _context.Fornecedores.ToListAsync();
        }

        // GET: api/Fornecedores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fornecedores>> GetFornecedores(int id)
        {
          if (_context.Fornecedores == null)
          {
              return NotFound();
          }
            var fornecedores = await _context.Fornecedores.FindAsync(id);

            if (fornecedores == null)
            {
                return NotFound();
            }

            return fornecedores;
        }

        // PUT: api/Fornecedores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFornecedores(int id, Fornecedores fornecedores)
        {
            if (id != fornecedores.Id)
            {
                return BadRequest();
            }

            _context.Entry(fornecedores).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FornecedoresExists(id))
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

        // POST: api/Fornecedores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Fornecedores>> PostFornecedores(Fornecedores fornecedores)
        {
          if (_context.Fornecedores == null)
          {
              return Problem("Entity set 'ControleCompraEVendasContext.Fornecedores'  is null.");
          }
            _context.Fornecedores.Add(fornecedores);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFornecedores", new { id = fornecedores.Id }, fornecedores);
        }

        // DELETE: api/Fornecedores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFornecedores(int id)
        {
            if (_context.Fornecedores == null)
            {
                return NotFound();
            }
            var fornecedores = await _context.Fornecedores.FindAsync(id);
            if (fornecedores == null)
            {
                return NotFound();
            }

            _context.Fornecedores.Remove(fornecedores);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FornecedoresExists(int id)
        {
            return (_context.Fornecedores?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
