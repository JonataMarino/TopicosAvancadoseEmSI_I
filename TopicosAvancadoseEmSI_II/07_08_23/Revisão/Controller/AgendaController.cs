using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revisao07082023.Model;
using Revisao07082023.Service;


namespace Revisao07082023.Controller
{
	class AgendaController
	{
		public bool Inserir(Model.Agenda agenda) 
		{
			return new AgendaService().Inserir(agenda);
		}

		public bool Atualizar(Agenda agenda)
		{
			return new AgendaService().Atualizar(agenda);
		}

		public bool Deletar (int  id)
		{
			return new AgendaService().Deletar(id);
		}

		public List<Model.Agenda> TodosOsRegistros()
		{
			return new AgendaService().TodosOsRegistros();
		}

		public Model.Agenda ConsultarPorId (int id)
		{
			return new AgendaService().ConsultarPorId(id);
		}
	}
}
