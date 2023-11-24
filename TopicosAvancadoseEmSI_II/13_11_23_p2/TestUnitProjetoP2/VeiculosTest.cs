using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoP2.Controllers;
using ProjetoP2.Data;
using ProjetoP2.Models;

namespace TestUnitProjetoP2
{
    public class VeiculosTest
    {
        private DbContextOptions<ProjetoP2Context> options;

        private void InitializeDatabase()
        {
            options = new DbContextOptionsBuilder<ProjetoP2Context>().
            UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options;

            using (var context = new ProjetoP2Context(options))
            {
                context.Veiculos.Add(new Veiculos { Id = 1, Fabricante = "FIAT", Modelo = "Toro", Cor = "Preto", Ano = "2022/23" });
                context.Veiculos.Add(new Veiculos { Id = 2, Fabricante = "GM MORTORS", Modelo = "Onix Turbo", Cor = "Prata", Ano = "2022/23" });
                context.Veiculos.Add(new Veiculos { Id = 3, Fabricante = "Honda", Modelo = "HRV", Cor = "Cinza", Ano = "2022/23" });
                context.SaveChanges();
            }
        }
        [Fact]
        public void GetAllVeiculos()
        {
            InitializeDatabase();

            using (var context = new ProjetoP2Context(options))
            {
                VeiculosController veiculosController = new VeiculosController(context);
                IEnumerable<Veiculos> veiculos = veiculosController.GetVeiculos().Result.Value;
                Assert.Equal(3, veiculos.Count());
            }
        }
        [Fact]
        public async Task GetVeiculoById()
        {
            InitializeDatabase();
            using (var context = new ProjetoP2Context(options))
            {
                int id = 3;
                VeiculosController veiculosController = new VeiculosController(context);
                Veiculos veiculos = veiculosController.GetVeiculos(id).Result.Value;
                Assert.Equal(3, veiculos.Id);
            }
        }


        [Fact]
        public async Task CreateVeiculo()
        {
            InitializeDatabase();
            Veiculos veiculo = new Veiculos()
            {
                Id = 4,
                Fabricante = "HONDA",
                Modelo = "City",
                Cor = "vermelho",
                Ano = "2022/23"
            };

            using (var context = new ProjetoP2Context(options))
            {
                VeiculosController veiculosController = new VeiculosController(context);
                await veiculosController.PostVeiculos(veiculo);
                Veiculos veiculosReturn = veiculosController.GetVeiculos(4).Result.Value;
                Assert.Equal("City", veiculosReturn.Modelo);
            }
        }
        [Fact]
        public async Task UpdateVeiculo()
        {
            InitializeDatabase();

            Veiculos veiculos = new Veiculos()
            {
                Id = 3,
                Fabricante = "VOLKSWAGEM",
                Modelo = "T-CROSS",
                Cor = "Branco",
                Ano = "2022/23"

            };

            using (var context = new ProjetoP2Context(options))
            {
                VeiculosController veiculosController = new VeiculosController(context);
                await veiculosController.PutVeiculos(3, veiculos);
                Veiculos veiculosReturn = veiculosController.GetVeiculos(3).Result.Value;
                Assert.Equal("T-CROSS", veiculosReturn.Modelo);
            }
        }

        [Fact]
        public async Task DeleteVeiculo()
        {
            InitializeDatabase();

            using (var context = new ProjetoP2Context(options))
            {
                VeiculosController veiculosController = new VeiculosController(context);
                IActionResult result = await veiculosController.DeleteVeiculos(1);
                Assert.IsType<NoContentResult>(result);

            }
        }
    }
}
