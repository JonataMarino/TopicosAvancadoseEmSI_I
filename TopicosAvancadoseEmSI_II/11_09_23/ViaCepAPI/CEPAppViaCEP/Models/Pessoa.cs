﻿using CEPAppViaCEP.Integracao;
using CEPAppViaCEP.Integracao.Response;

namespace CEPAppViaCEP.Models
{
	public class Pessoa
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Telefone { get; set; }
		public ViaCepResponse Cep { get; set; } 
	}
}
