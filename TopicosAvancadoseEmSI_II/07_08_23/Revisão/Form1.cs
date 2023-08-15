using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Revisao07082023.Controller;
using Revisao07082023.Model;

namespace Revisao07082023
{
	public partial class FormAgenda : Form
	{
		public FormAgenda()
		{
			InitializeComponent();
			txtbNome.Focus();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
            Agenda agenda = new Agenda()
			{
				Id = int.Parse(this.lblId.Text),
				Nome = txtbNome.Text,
				Telefone = txtbTelefone.Text,
			};

			if (ValidarDados(agenda))
			{
				if (agenda.Id == 0) 
				{
					Inserir(agenda);
				}
				else
				{
					Atualizar(agenda);
				}
			}
			else
			{
				MessageBox.Show("Os Campos Nome e Telefone são Obrigatórios");
			}
		}
		private bool ValidarDados(Agenda agenda)
		{
			if (string.IsNullOrEmpty(agenda.Nome) || string.IsNullOrEmpty(agenda.Telefone))
				return false;

			return true;
		}
		private void Inserir(Agenda agenda)
		{
			if (new AgendaController().Inserir(agenda))
			{
				MessageBox.Show("Registro inserido!");
				CarregarGrid();
				ClearForm();
			}
			else
				MessageBox.Show("Erro ao inserir registro!");
		}
		private void Atualizar(Agenda agenda)
		{
			if (new AgendaController().Atualizar(agenda))
			{
				MessageBox.Show("Registro atualizado!");
				CarregarGrid();
				ClearForm();
			}
			else
				MessageBox.Show("Erro ao atualizar registro!");
		}

		private void Deletar(int id)
		{
			if (new AgendaController().Deletar(id))
			{
				MessageBox.Show("Registro Deletado!");
				CarregarGrid();
				ClearForm();
			}
			else
				MessageBox.Show("Erro ao deletar registro!");
		}
		private void ClearForm()
		{
			this.txtbNome.Clear();
			this.lblId.Text = "0";
			this.txtbTelefone.Clear();
			txtbNome.Focus();
		}
		private void CarregarGrid()
		{
			dgvAgenda.DataSource = new AgendaController().TodosOsRegistros();
		}
		private void FormAgenda_Load(object sender, EventArgs e)
		{
			CarregarGrid();
		}
		private void dgvAgenda_CellClick (object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = (dgvAgenda.CurrentCell.RowIndex);
			lblId.Text = dgvAgenda.Rows[rowIndex].Cells[0].Value.ToString();
			txtbNome.Text = dgvAgenda.Rows[rowIndex].Cells[1].Value.ToString();
			txtbTelefone.Text = dgvAgenda.Rows[rowIndex].Cells[2].Value.ToString();
		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			ClearForm();
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			int id = int.Parse(lblId.Text);

			if (id == 0)
				MessageBox.Show("Por favor, seleciona primeiro um registro!");
			else
				this.Deletar(id);
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			int id = int.Parse(lblId.Text);

			if (id == 0)
				MessageBox.Show("Por favor, selecione primeiro um registro");
		}

	}
}

