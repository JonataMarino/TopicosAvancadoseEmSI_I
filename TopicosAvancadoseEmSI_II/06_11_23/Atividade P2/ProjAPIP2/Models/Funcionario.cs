using System.ComponentModel;

namespace ProjAPIP2.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        
        [DisplayName("Colaborador")]
        public string NomeFuncionario { get; set; }
        
        [DisplayName("Endereço")]
        public string EnderecoFuncionario { get; set; }
        
        [DisplayName("Telefone")]
        public string TelefoneFuncionario { get; set; }
        
        [DisplayName("E-mail")]
        public string EmailFuncionário { get; set; }
        
        [DisplayName("Identificação")]
        public string Identificacao { get; set; }
    }
}
