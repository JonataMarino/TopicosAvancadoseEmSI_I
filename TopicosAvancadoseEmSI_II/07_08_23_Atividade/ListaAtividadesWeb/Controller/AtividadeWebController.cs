using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ListaAtividadesWeb.Model;
using ListaAtividadesWeb.Service;

namespace ListaAtividadesWeb.Controller
{
	 class AtividadeWebController
	{
		public bool InserirAtividade(Atividade atividade)
		{
			return new AtividadeWebService().InserirAtividade(atividade);
		}

		public bool AtualizarAtividade(Atividade atividade, int id)
		{
			return new AtividadeWebService().AtualizarAtividade(atividade, id);
		}

		public bool DeletarAtividade(int id)
		{
			return new AtividadeWebService().DeletarAtividade(id);
		}

		public List<Atividade> TodasAsAtividades()
		{
			return new AtividadeWebService().TodasAsAtividades();
		}
	}
}