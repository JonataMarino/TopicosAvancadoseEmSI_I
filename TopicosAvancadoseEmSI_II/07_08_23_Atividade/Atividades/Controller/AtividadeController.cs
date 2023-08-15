using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividades.Model;
using Atividades.Service;

namespace Atividades.Controller
{
	class AtividadeController
	{
		public bool InserirAtividade(Atividade atividade)
		{
			return new AtividadeService().InserirAtividade(atividade);
		}

		public bool AtualizarAtividade(Atividade atividade, int id)
		{
			return new AtividadeService().AtualizarAtividade(atividade, id);
		}

		public bool DeletarAtividade(int id)
		{
			return new AtividadeService().DeletarAtividade(id);
		}

		public List <Atividade> TodasAsAtividades()
		{
			return new AtividadeService().TodasAsAtividades();
		}
	}
}
