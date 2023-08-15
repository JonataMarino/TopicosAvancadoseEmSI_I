using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades.Model
{
	public class Atividade
	{
		public int Id { get; set; }
		public string Descricao { get; set; }
		public DateTime DataCriado { get; set; }
		public DateTime DataAtividade { get; set; }

	}
}
