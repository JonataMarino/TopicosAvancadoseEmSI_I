using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiMercadorias.Models;

namespace ApiMercadorias.Data
{
    public class ApiMercadoriasContext : DbContext
    {
        public ApiMercadoriasContext (DbContextOptions<ApiMercadoriasContext> options)
            : base(options)
        {
        }

        public DbSet<ApiMercadorias.Models.mercadoria> mercadoria { get; set; } = default!;

        public DbSet<ApiMercadorias.Models.cliente>? cliente { get; set; }
    }
}
