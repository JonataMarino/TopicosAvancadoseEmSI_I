﻿using System;
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
    public class clientesController : ControllerBase
    {
        private readonly ApiMercadoriasContext _context;

        public clientesController(ApiMercadoriasContext context)
        {
            _context = context;
        }

        // GET: api/clientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<cliente>>> Getcliente()
        {
          if (_context.cliente == null)
          {
              return NotFound();
          }
            return await _context.cliente.ToListAsync();
        }

        // GET: api/clientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<cliente>> Getcliente(int id)
        {
          if (_context.cliente == null)
          {
              return NotFound();
          }
            var cliente = await _context.cliente.FindAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        // PUT: api/clientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putcliente(int id, cliente cliente)
        {
            if (id != cliente.Id)
            {
                return BadRequest();
            }

            _context.Entry(cliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!clienteExists(id))
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

        // POST: api/clientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<cliente>> Postcliente(cliente cliente)
        {
          if (_context.cliente == null)
          {
              return Problem("Entity set 'ApiMercadoriasContext.cliente'  is null.");
          }
            _context.cliente.Add(cliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getcliente", new { id = cliente.Id }, cliente);
        }

        // DELETE: api/clientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletecliente(int id)
        {
            if (_context.cliente == null)
            {
                return NotFound();
            }
            var cliente = await _context.cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _context.cliente.Remove(cliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool clienteExists(int id)
        {
            return (_context.cliente?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
