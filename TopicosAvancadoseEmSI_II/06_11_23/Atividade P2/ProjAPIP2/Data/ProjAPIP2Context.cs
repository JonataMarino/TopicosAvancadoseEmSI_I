using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjAPIP2.Models;

namespace ProjAPIP2.Data
{
    public class ProjAPIP2Context : DbContext
    {
        public ProjAPIP2Context (DbContextOptions<ProjAPIP2Context> options)
            : base(options)
        {
        }

        public DbSet<ProjAPIP2.Models.Cliente> Cliente { get; set; } = default!;

        public DbSet<ProjAPIP2.Models.Fornecedores>? Fornecedores { get; set; }

        public DbSet<ProjAPIP2.Models.Funcionario>? Funcionario { get; set; }

        public DbSet<ProjAPIP2.Models.Produto>? Produto { get; set; }
    }
}
