using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjControleEstoqueAPI.Models;

namespace ProjControleEstoqueAPI.Data
{
    public class ProjControleEstoqueAPIContext : DbContext
    {
        public ProjControleEstoqueAPIContext (DbContextOptions<ProjControleEstoqueAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ProjControleEstoqueAPI.Models.Estoque> Estoque { get; set; } = default!;
    }
}
