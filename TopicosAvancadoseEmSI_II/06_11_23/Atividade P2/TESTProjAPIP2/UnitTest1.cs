using Microsoft.EntityFrameworkCore;
using ProjAPIP2.Data;
using ProjAPIP2.Models;

namespace TESTProjAPIP2
{
    public class UnitTest1
    {
       //� necess�rio um teste unit�rio para cada classe do projeto
        private DbContextOptions<ProjAPIP2Context> options;

        private void InitializaDatabase()
        {
            options = new DbContextOptionsBuilder<ProjAPIP2Context>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using (var context = new ProjAPIP2Context(options))
            {
                //clientes
                context.Cliente.Add(new Cliente { Id = 1, NomeCliente = "Jo�o Batista", EnderecoCliente = "Rua dos cravos 10",
                TelefoneCliente = "16887890875", EmailCliente = "arroba@.arroba.com", DocumentoValido = "237653456"});
                context.Cliente.Add(new Cliente{Id = 2, NomeCliente = "Pedro Paulo", EnderecoCliente = "Rua dos cravos '16",
                    TelefoneCliente = "16563345687", EmailCliente = "pedropaulo@arroba.com", DocumentoValido = "54367897654"});
                 context.Cliente.Add(new Cliente{Id = 2, NomeCliente = "Pedro Paulo", EnderecoCliente = "Rua dos cravos '16",
                    TelefoneCliente = "16563345687", EmailCliente = "pedropaulo@arroba.com", DocumentoValido = "54367897654"});

            }
        }
  

        [Fact]
        public void AddCliente()
        {

        }
    }
}