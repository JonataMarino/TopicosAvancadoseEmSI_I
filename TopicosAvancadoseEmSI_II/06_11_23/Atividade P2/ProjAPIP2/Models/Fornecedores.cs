using System.ComponentModel;

namespace ProjAPIP2.Models
{
    public class Fornecedores
    {   
        public int Id { get; set; }
        
        [DisplayName("Representante")]
        public string NomeRepresentante { get; set; }

        [DisplayName("Nome da empresa")]
        public string Empresa { get; set;}

        [DisplayName("E-mail")]
        public string EmailFornecedor { get; set;}

        [DisplayName("Telefone")]
        public string telefone { get; set;}

        [DisplayName("CNPJ")]
        public string Cnpj { get; set;}

    }
}
