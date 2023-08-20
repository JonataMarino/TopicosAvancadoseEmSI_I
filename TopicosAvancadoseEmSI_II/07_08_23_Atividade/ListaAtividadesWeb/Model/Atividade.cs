using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListaAtividadesWeb.Model
{
	public class Atividade
	{
		public int Id { get; set; }
		public string Descricao { get; set; }
		public DateTime DataCriado { get; set; }
		public DateTime DataAtividade { get; set; }
	}
}