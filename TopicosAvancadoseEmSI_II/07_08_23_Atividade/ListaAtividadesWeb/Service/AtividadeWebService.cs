using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using ListaAtividadesWeb.Model;

namespace ListaAtividadesWeb.Service
{
	public class AtividadeWebService
	{
		string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=D:\Logatti 8o Termo\Topicos Avançados em SI_II\TopicosAvancadoseEmSI_II\07_08_23_Atividade\db_Atividade\db_Atividades.mdf";
		SqlConnection conn;

		public AtividadeWebService()
		{
			conn = new SqlConnection(strCon);
			conn.Open();
		}

		public bool InserirAtividade(Atividade atividade)
		{
			string strInsert = "insert into Atividades (Descricao, DataCriado, DataAtividade) values (@Descricao, @DataCriado, @DataAtividade);";
			SqlCommand commandInsert = new SqlCommand(strInsert, conn);

			commandInsert.Parameters.Add(new SqlParameter("@Descricao", atividade.Descricao));
			commandInsert.Parameters.Add(new SqlParameter("@DataCriado", atividade.DataCriado));
			commandInsert.Parameters.Add(new SqlParameter("@DataAtividade", atividade.DataAtividade));

			commandInsert.ExecuteNonQuery();
			conn.Close();
			return true;
		}

		public bool AtualizarAtividade(Atividade atividade, int id)
		{
			string strUpdate = "update Atividades set Descricao = @Descricao, DataCriado = @Datacriado, DataAtividade = @DataAtividade " +
				"where Id = @Id";
			SqlCommand commandUpdate = new SqlCommand(strUpdate, conn);

			commandUpdate.Parameters.Add(new SqlParameter("@Id", id));
			commandUpdate.Parameters.Add(new SqlParameter("@Descricao", atividade.Descricao));
			commandUpdate.Parameters.Add(new SqlParameter("@DataCriado", atividade.DataCriado));
			commandUpdate.Parameters.Add(new SqlParameter("@DataAtividade", atividade.DataAtividade));

			commandUpdate.ExecuteNonQuery();
			conn.Close();
			return true;
		}

		public bool DeletarAtividade(int id)
		{
			string strDelete = "delete from Atividades where id = @id";
			SqlCommand commandDelete = new SqlCommand(strDelete, conn);

			commandDelete.Parameters.Add(new SqlParameter("@id", id));

			commandDelete.ExecuteNonQuery();
			conn.Close();
			return true;
		}

		public List<Atividade> TodasAsAtividades()
		{
			List<Atividade> atividades = new List<Atividade>();

			StringBuilder sb = new StringBuilder();

			sb.Append("SELECT Id, ");
			sb.Append("Descricao , ");
			sb.Append("DataCriado , ");
			sb.Append("DataAtividade ");
			sb.Append("FROM Atividades");

			SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
			SqlDataReader dr = commandSelect.ExecuteReader();

			while (dr.Read())
			{
				Atividade atividade = new Atividade();

				atividade.Id = Convert.ToInt32(dr["Id"]);
				atividade.Descricao = dr["Descricao"].ToString();
				atividade.DataCriado = Convert.ToDateTime(dr["DataCriado"]);
				atividade.DataAtividade = Convert.ToDateTime(dr["DataAtividade"]);

				atividades.Add(atividade);

			}
			return atividades;

		}
	}
}
