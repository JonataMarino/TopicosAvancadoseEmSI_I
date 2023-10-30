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
				context.Clientes.Add(new Clientes { Id = 1, Name = "Jonatã", Cpf = "22244455543", telefone = "65778765554", endereco = "rua com asfalto S/N" });
				context.Clientes.Add(new Clientes { Id = 2, Name = "Pedro", Cpf = "33344455565", telefone = "65778765554", endereco = "rua sem asfalto S/N" });
				context.Clientes.Add(new Clientes { Id = 3, Name = "Paulo", Cpf = "55544466678", telefone = "65778765554", endereco = "rua com pouco asfalto S/N" });
				context.SaveChanges();
			}
		}

		[Fact]
		public void TGetAllClientes()
		{
			InitializeDataBase();

			//use a clean instance of context to run the test
			using (var context = new ControleCompraEVendasContext(options))
			{
				ClientesController clientesController = new ClientesController(context);
				IEnumerable<Clientes> clientes = clientesController.GetClientes().Result.Value;
				Assert.Equal(3, clientes.Count());
			}
		}

		[Fact]
		public async void TPostClientes ()
		{
			InitializeDataBase();
			Clientes cliente = new Clientes()
			{
				Id = 4,
				Name = "Novo Cliente",
				Cpf = "12345678909",
				telefone = "1234567890",
				endereco = "rua nova 123"
			};

			using (var context = new ControleCompraEVendasContext(options))
			{
				ClientesController clientesController = new ClientesController(context);

				await clientesController.PostClientes(cliente);
				Clientes clienteReturn = clientesController.GetClientes(2).Result.Value;
				Assert.Equal("Novo Cliente", clienteReturn.Name);
				/*	var NovoCliente = new Clientes { Id = 0, Name = "Novo Cliente", Cpf = "12345678909",
					telefone = "1234567890", endereco = "rua nova 123" }; 


					var result = clientesController.PostClientes(NovoCliente).Result.Value;

					Assert.NotNull(result);
					Assert.Equal(NovoCliente.Name, result.Name);*/

			}


		}
	}
}

	
