using System.Net.WebSockets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoP2.Controllers;
using ProjetoP2.Data;
using ProjetoP2.Models;

namespace TestUnitProjetoP2
{
    public class EletronicosTest
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
        public async Task GetAllEletronicos() 
        {
            InitializeDatabase();

            using (var context = new ProjetoP2Context(options))
            {
                EletronicosController eletronicosController = new EletronicosController(context);
                IEnumerable<Eletronicos> eletronicos = eletronicosController.GetEletronicos().Result.Value;
                Assert.Equal(3, eletronicos.Count());
            }
        }

        [Fact]
        public async Task GetEletronicoById()
        {
            InitializeDatabase();
            using (var context = new ProjetoP2Context(options))
            {
                int id = 3;
                EletronicosController eletronicosController = new EletronicosController(context);
                Eletronicos eletronicos = eletronicosController.GetEletronicos(id).Result.Value;
                Assert.Equal(3, eletronicos.Id);
            }
        }

        [Fact]
        public async Task CreateEletronico()
        {
            InitializeDatabase();
            Eletronicos eletronicos = new Eletronicos()
            {
                Id = 4,
                Nome = "Controle Xbox",
                Marca = "Microsoft",
                Modelo = "XBX11/22-2023 AIO",
                Ano = "2022/23",
                Descricao = "Controle xBox compatível com todas as plataformas"
            };

            using  (var context = new ProjetoP2Context(options))
            {
                EletronicosController eletronicosController = new EletronicosController(context);
                await eletronicosController.PostEletronicos(eletronicos);
                Eletronicos eletronicosReturn = eletronicosController.GetEletronicos(4).Result.Value;
                Assert.Equal("Controle Xbox", eletronicosReturn.Nome);
            }
        }

        [Fact]
        public async Task UpdateEletronico()
        {
            InitializeDatabase();

            Eletronicos eletronicos = new Eletronicos()
            {
                Id = 1,
                Nome = "PlayStation V",
                Marca = "Sony",
                Modelo = "Soft",
                Ano = "2023",
                Descricao = "Video Game SonyConnect"

            };

            using (var context = new ProjetoP2Context(options))
            {
                EletronicosController eletronicosController = new EletronicosController(context);
                await eletronicosController.PutEletronicos(1, eletronicos);
                Eletronicos eletronicosReturn = eletronicosController.GetEletronicos(1).Result.Value;
                Assert.Equal("PlayStation V", eletronicosReturn.Nome);
            }
        }

        [Fact]
        public async Task DeleteEletronico()
        {
            InitializeDatabase();

            using (var context = new ProjetoP2Context(options))
            {
                EletronicosController eletronicosController = new EletronicosController(context);
                IActionResult result = await eletronicosController.DeleteEletronicos(1);
                Assert.IsType<NoContentResult>(result);

            }
        }
    }
}