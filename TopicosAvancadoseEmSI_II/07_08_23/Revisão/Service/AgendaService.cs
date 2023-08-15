using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Revisao07082023.Model;

namespace Revisao07082023.Service
{
	class AgendaService
	{
		//implementar a conexão
		string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=D:\Logatti 8o Termo\TopicosAvancadoseEmSI_II\07_08_23\Revisão\dbRevisão\dbAgendaTurma.mdf";
		SqlConnection conn;

		public AgendaService() 
		{
			//abertura da conexão
			conn = new SqlConnection(strCon);
			conn.Open();
		}

		public bool Inserir (Agenda agenda)
		{

			//Implementar
			string strInsert = "insert into agenda (Nome, telefone) values (@Nome, @Telefone)";
			SqlCommand commandInsert = new SqlCommand(strInsert, conn);

			commandInsert.Parameters.Add("Nome", agenda.Nome);
			commandInsert.Parameters.Add("Telefone", agenda.Telefone);

			commandInsert.ExecuteNonQuery();
			conn.Close();
			return true;
		}

		public bool Atualizar(Agenda agenda)
		{
			string strInsert = "update Agenda set Nome = @Nome, Telefone = @Telefone where id = @Id";
			SqlCommand commandInsert = new SqlCommand( strInsert, conn);

			commandInsert.Parameters.Add("@Id", agenda.Id);
			commandInsert.Parameters.Add("@Nome", agenda.Nome);
			commandInsert.Parameters.Add("@Telefone", agenda.Telefone);

			commandInsert.ExecuteNonQuery();
			conn.Close();
			return true;
		}

		public bool Deletar (int id)
		{
			string strInsert = "delete from Agenda where id = @Id";
			SqlCommand commandInsert = new SqlCommand(strInsert, conn);

			commandInsert.Parameters.Add(new SqlParameter("@Id", id));

			commandInsert.ExecuteNonQuery();
			conn.Close();
			return true;

		}

		public List<Agenda> TodosOsRegistros()
		{
            List<Agenda> agendas = new List<Agenda>();

			StringBuilder sb = new StringBuilder();

			sb.Append("Select Id, ");
			sb.Append("Nome, ");
			sb.Append("Telefone ");
			sb.Append("From Agenda");

			SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
			SqlDataReader dr = commandSelect.ExecuteReader();

			while (dr.Read())
			{
                Agenda agenda = new Agenda();
				agenda.Id = Convert.ToInt32(dr["id"]);
				agenda.Nome = dr["Nome"].ToString();
				agenda.Telefone = dr["Telefone"].ToString();

				agendas.Add(agenda);
			}
			return agendas;
		}

		public Agenda ConsultarPorId(int id)
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("Select Id, ");
			sb.Append("Nome, ");
			sb.Append("Telefone ");
			sb.Append("From Agenda ");
			sb.Append("WHERE id = @Id");

			SqlCommand commandSelect = new SqlCommand (sb.ToString(), conn);
			commandSelect.Parameters.Add(new SqlParameter("@Id", id));

			SqlDataReader dr = commandSelect.ExecuteReader();

			Agenda agenda = new Agenda();

			if (dr.Read())
			{
				agenda.Id = Convert.ToInt32(dr["Id"]);
				agenda.Nome = dr["Nome"].ToString();
				agenda.Telefone = dr["Telefone"].ToString();
			}
			return agenda;
		}
	}
}
