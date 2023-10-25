using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestUnitXSL.Models;

namespace TestUnitXSL.Data
{
    public class TestUnitXSLContext : DbContext
    {
        public TestUnitXSLContext (DbContextOptions<TestUnitXSLContext> options)
            : base(options)
        {
        }

        public DbSet<TestUnitXSL.Models.Remédio> Remédio { get; set; } = default!;
    }
}
