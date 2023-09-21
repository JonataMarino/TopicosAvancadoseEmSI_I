using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CEPApp.Models;

namespace CEPApp.Data
{
    public class CEPAppContext : DbContext
    {
        public CEPAppContext (DbContextOptions<CEPAppContext> options)
            : base(options)
        {
        }

        public DbSet<CEPApp.Models.Pessoa> Pessoa { get; set; } = default!;
    }
}
