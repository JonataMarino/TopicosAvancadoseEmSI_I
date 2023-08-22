using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using ListaAtividadesWeb.Controller;
using ListaAtividadesWeb.Model;

namespace ListaAtividadesWeb

{
	public partial class AtividadeWeb : System.Web.UI.Page
	{
		static List<Atividade> lstAtividade = new List<Atividade>();
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		private void CarregarGrid()
		{
			IdGVAtividades.DataSource = new AtividadeWebController().TodasAsAtividades();
		}
		private void ClearForm()
		{
			this.idAtividade.Text = "0";
			this.txtDdescricao.Text = "";
			this.dtpDataCriado.SelectedDate = DateTime.MinValue;
			this.dtpAtividade.SelectedDate = DateTime.MaxValue;
		}
		public bool ValidadeDados (Atividade atividade)
		{
			if (string.IsNullOrEmpty(idAtividade.Text))
				return false;
			return true;
		}

		public void InserirAtividade(Atividade atividade)
		{
			if ( new AtividadeWebController().InserirAtividade(atividade))
				{
				CarregarGrid();
				}
		}
		private void AtualizarAtividade(Atividade atividade, int id)
		{
			if (new AtividadeWebController().AtualizarAtividade(atividade, id))
			{
				id = int.Parse(idAtividade.Text);
				CarregarGrid();
				ClearForm();
			}
		}
		private void DeletarAtividade(int id)
		{
			if (new AtividadeWebController().DeletarAtividade(id))
			{
				CarregarGrid();
				ClearForm();
			}
		}

		private void SelecionarAtividade(int id)
		{
			if (new AtividadeWebController().SelecionarAtividade(id))
				CarregarGrid(); //talvez seja necesario criar um CarregarFormulario para receber os dados de formulário preenchido
		}

		protected void btnNovo_Click(object sender, EventArgs e)
		{
			ClearForm();
		}

		protected void btnSalvar_Click(object sender, EventArgs e)
		{
			Atividade atividade = new Atividade()
			{
				Id = int.Parse(idAtividade.Text),
				Descricao = txtDdescricao.Text,
				DataCriado = dtpDataCriado.SelectedDate,
				DataAtividade = dtpAtividade.SelectedDate,
			};
			if (ValidadeDados(atividade))
				InserirAtividade(atividade);
			else
			{
				int id = int.Parse(idAtividade.Text);
				AtualizarAtividade(atividade, id);
			}

		}
		protected void btnExcluir_Click(object sender, EventArgs e)
		{
			int id = int.Parse(idAtividade.Text);
			if (id == 0)
			{

			}
			else this.DeletarAtividade(id);
		}
		protected void IdGVAtividades_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			int id = int.Parse(idAtividade.Text);
			if (id == 0)
			{

			}
			else this.SelecionarAtividade(id);

			}

		}


	}
