using System.ComponentModel;

namespace ProjAPIP2.Models
{
    //[LabelName ("Cliente")]
    public class Cliente
    {
        public int Id { get; set; }
        [DisplayName("Nome do Cliente")]
        public string NomeCliente { get; set; }
        [DisplayName("Endereço")]

        public string EnderecoCliente { get; set; }
        [DisplayName("Telefone")]

        public string TelefoneCliente { get; set; }
        [DisplayName("E-mail para contato")]

        public string EmailCliente { get; set; }
        [DisplayName("CPF")]

        public string DocumentoValido { get; set; }
    }
}
