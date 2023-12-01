using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P2_2_MVC_.Models;

namespace P2_2_MVC_.Data
{
    public class P2_2_MVC_Context : DbContext
    {
        public P2_2_MVC_Context (DbContextOptions<P2_2_MVC_Context> options)
            : base(options)
        {
        }

        public DbSet<P2_2_MVC_.Models.Categoria> Categoria { get; set; } = default!;
        public DbSet<P2_2_MVC_.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<P2_2_MVC_.Models.ItemPedido> ItemPedido { get; set; } = default!;
        public DbSet<P2_2_MVC_.Models.Pedido> Pedido { get; set; } = default!;
        public DbSet<P2_2_MVC_.Models.Produto> Produto { get; set; } = default!;
    }
}
