using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjWebApi28082023.Models;

namespace ProjWebApi28082023.Data
{
    public class ProjWebApi28082023Context : DbContext
    {
        public ProjWebApi28082023Context (DbContextOptions<ProjWebApi28082023Context> options)
            : base(options)
        {
        }

        public DbSet<ProjWebApi28082023.Models.Person> Person { get; set; } = default!;
    }
}
