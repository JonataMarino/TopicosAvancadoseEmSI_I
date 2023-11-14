using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoP2.Models;

namespace ProjetoP2.Data
{
    public class ProjetoP2Context : DbContext
    {
        public ProjetoP2Context (DbContextOptions<ProjetoP2Context> options)
            : base(options)
        {
        }

        public DbSet<ProjetoP2.Models.Eletronicos> Eletronicos { get; set; } = default!;

        public DbSet<ProjetoP2.Models.Veiculos>? Veiculos { get; set; }
    }
}
