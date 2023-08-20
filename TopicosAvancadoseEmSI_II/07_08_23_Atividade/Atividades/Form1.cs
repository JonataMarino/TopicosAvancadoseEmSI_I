using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atividades.Model;
using Atividades.Service;
using Atividades.Controller;

namespace Atividades
{
	public partial class Atividades : Form
	{
		public Atividades()
		{
			InitializeComponent();
		}
		private void Atividades_Load(object sender, EventArgs e)
		{
			CarregarGrid();
		}
		
		//carregar DatagridView ao iniciar a aplicação
		private void CarregarGrid()
		{
			dgvAtividades.DataSource = new AtividadeController().TodasAsAtividades();
		}
		
		//função atribuida ao botão de novo cadastro
		private void ClearForm()
		{
			this.lblId.Text = "0";
			this.txtbAtividade.Clear();
			this.dtpCadastro.Value = DateTime.Now;
			this.dtpAtividade.MinDate = DateTime.Now;
		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			ClearForm();
		}

		//Funções atribuidas ao botão salvar
		public bool ValidarDados(Atividade atividade)
		{
			if (string.IsNullOrEmpty(txtbAtividade.Text))
				return false;
			return true;
		}

		private void InserirAtividade(Atividade atividade)
		{
			if (new AtividadeController().InserirAtividade(atividade))
			{
				MessageBox.Show("Atividade Inserida");
				CarregarGrid();
				ClearForm();
			}
		}

		private void AtualizarAtividade(Atividade atividade, int id)
		{
			id = int.Parse(lblId.Text);
			if (new AtividadeController().AtualizarAtividade(atividade, id))
			{
				MessageBox.Show("Atividade Atualizada");
				CarregarGrid();
				ClearForm();
			}
			else
				MessageBox.Show("Erro ao atualizar a Atividade");
		}
		
		// Ação de click botão Salvar
		private void btnSalvar_Click(object sender, EventArgs e)
		{
			Atividade atividade = new Atividade()
			{
				Id = int.Parse(lblId.Text),
				Descricao = txtbAtividade.Text,
				DataCriado = dtpAtividade.Value,
				DataAtividade = dtpAtividade.Value,
			};

			if (ValidarDados(atividade)) // através da função ValidarDados, seleciona uma Atividade existente
			{
				if (atividade.Id == 0)
					InserirAtividade(atividade); //Salva uma atividade
				else
				{
					int id = int.Parse(lblId.Text);
					AtualizarAtividade(atividade, id);  //Salvar uma edição de atividade
				}
			}
		}

		//ação de selecionar registro pelo cellClick
		private void dgvAtividades_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = (dgvAtividades.CurrentCell.RowIndex);
			lblId.Text = dgvAtividades.Rows[rowIndex].Cells[0].Value.ToString();
			txtbAtividade.Text = dgvAtividades.Rows[rowIndex].Cells[1].Value.ToString();
			dtpCadastro.MaxDate = (DateTime)dgvAtividades.Rows[rowIndex].Cells[2].Value;
			dtpAtividade.MinDate = (DateTime)dgvAtividades.Rows[rowIndex].Cells[3].Value;
		}

		// função botão excluir

		private void DeletarAtividade(int id)
		{
			if (new AtividadeController().DeletarAtividade(id))
			{
				MessageBox.Show("Registro de atividade apagado");
				CarregarGrid();
				ClearForm();
			}
		}

		//Ação botão Excluir
		private void btnExcluir_Click(object sender, EventArgs e)
		{
			int id = int.Parse(lblId.Text);

			if (id == 0)
			{
				MessageBox.Show("Por favor, selecione um registro");
			}
			else
				this.DeletarAtividade(id);

		}

	}
}