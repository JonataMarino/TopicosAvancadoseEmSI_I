using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P2_MVC_.Models;

namespace P2_MVC_.Data
{
    public class P2_MVC_Context : DbContext
    {
        public P2_MVC_Context (DbContextOptions<P2_MVC_Context> options)
            : base(options)
        {
        }

        public DbSet<P2_MVC_.Models.VendaProduto> VendaProduto { get; set; } = default!;

        public DbSet<P2_MVC_.Models.EstoqueProduto>? EstoqueProduto { get; set; }

        public DbSet<P2_MVC_.Models.Produto>? Produto { get; set; }

        public DbSet<P2_MVC_.Models.Cliente>? Cliente { get; set; }

        public DbSet<P2_MVC_.Models.ComprasCliente>? ComprasCliente { get; set; }

        public DbSet<P2_MVC_.Models.EspecProdutos>? EspecProdutos { get; set; }
    }
}
