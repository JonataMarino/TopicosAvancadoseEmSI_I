using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp30102023.Models;

namespace WebApp30102023.Data
{
    public class WebApp30102023Context : DbContext
    {
        public WebApp30102023Context (DbContextOptions<WebApp30102023Context> options)
            : base(options)
        {
        }

        public DbSet<WebApp30102023.Models.Aluno> Aluno { get; set; } = default!;
    }
}
