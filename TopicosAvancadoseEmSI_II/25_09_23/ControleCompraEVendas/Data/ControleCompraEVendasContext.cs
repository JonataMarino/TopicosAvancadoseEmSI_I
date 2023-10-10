using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ControleCompraEVendas.Models;

namespace ControleCompraEVendas.Data
{
    public class ControleCompraEVendasContext : DbContext
    {
        public ControleCompraEVendasContext (DbContextOptions<ControleCompraEVendasContext> options)
            : base(options)
        {
        }

        public DbSet<ControleCompraEVendas.Models.Clientes> Clientes { get; set; } = default!;

        public DbSet<ControleCompraEVendas.Models.Produtos>? Produtos { get; set; }

        public DbSet<ControleCompraEVendas.Models.Funcionarios>? Funcionarios { get; set; }

        public DbSet<ControleCompraEVendas.Models.Fornecedores>? Fornecedores { get; set; }

        public DbSet<ControleCompraEVendas.Models.Vendas>? Vendas { get; set; }
    }
}
