using Microsoft.EntityFrameworkCore;
using ProjetoP2.Controllers;
using ProjetoP2.Data;
using ProjetoP2.Models;

namespace TestUnitProjetoP2
{
    public class APITest
    {
        private DbContextOptions<ProjetoP2Context> options;

        private void InitializeDatabase()
        {
            options = new DbContextOptionsBuilder<ProjetoP2Context>().
                UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).
                Options;

            using (var context = new ProjetoP2Context(options))
            {
                context.Eletronicos.Add(new Eletronicos { Id = 1, Nome = "Monitor portátil", Marca = "samsung", Modelo = "TLW-11/22-24.5'MHRZ", Ano = "2022/23", Descricao = "Monitor gamer 24' FHD IPS"  });
                context.Eletronicos.Add(new Eletronicos { Id = 2, Nome = "Monitor portátil", Marca = "samsung", Modelo = "TLW-11/22-24.5'MHRZ", Ano = "2022/23", Descricao = "Monitor gamer 24' FHD IPS"  });
                context.Eletronicos.Add(new Eletronicos { Id = 3, Nome = "Monitor portátil", Marca = "samsung", Modelo = "TLW-11/22-24.5'MHRZ", Ano = "2022/23", Descricao = "Monitor gamer 24' FHD IPS"  });
                context.SaveChanges();
            }
        }

        [Fact]
        public void GetAll() 
        {
            InitializeDatabase();

            using (var context = new ProjetoP2Context(options))
            {
                EletronicosController eletronicosController = new EletronicosController(context);
                IEnumerable<Eletronicos> eletronicos = eletronicosController.GetEletronicos().Result.Value;
                Assert.Equal(3, eletronicos.Count());
            }
        }
    }
}