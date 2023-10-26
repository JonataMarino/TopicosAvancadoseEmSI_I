using ControleCompraEVendas.Controllers;
using ControleCompraEVendas.Data;
using ControleCompraEVendas.Models;
using Microsoft.EntityFrameworkCore;


namespace ControleCompraEVendas.test
{
	public class UnitTest1
	{
		private DbContextOptions<ControleCompraEVendasContext> options;

		private void InitializeDataBase()
		{
			//Criar DataBase Temporário
			//Instalar entityFramwork.InMemory pelo nuget
			options = new DbContextOptionsBuilder<ControleCompraEVendasContext>()
				.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options;

			//inserir dados no DB usando context
			using (var context = new ControleCompraEVendasContext(options))
			{
				context.Clientes.Add(new Clientes {Id = 1, Name = "Jonatã", Cpf = "22244455543", telefone = "65778765554", endereco = "rua com asfalto S/N" });
				context.SaveChanges();
			}
		}

		[Fact]
		public void TodosOsClientes()
		{
			InitializeDataBase();

			//use a clean instance of context to run the test
			using (var context = new ControleCompraEVendasContext(options))
			{
				ClientesController clientesController = new ClientesController(context);
				IEnumerable<Clientes> clientes = clientesController.GetClientes().Result.Value;
				Assert.Equal(1, clientes.Count());
			}
		}
	}
}

	
