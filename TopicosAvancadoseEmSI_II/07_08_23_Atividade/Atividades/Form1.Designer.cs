namespace Atividades
{
	partial class Atividades
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblId = new System.Windows.Forms.Label();
			this.txtbAtividade = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblDataCadastro = new System.Windows.Forms.Label();
			this.lblDataAtividade = new System.Windows.Forms.Label();
			this.dtpCadastro = new System.Windows.Forms.DateTimePicker();
			this.dtpAtividade = new System.Windows.Forms.DateTimePicker();
			this.dgvAtividades = new System.Windows.Forms.DataGridView();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvAtividades)).BeginInit();
			this.SuspendLayout();
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(32, 19);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(13, 13);
			this.lblId.TabIndex = 0;
			this.lblId.Text = "0";
			// 
			// txtbAtividade
			// 
			this.txtbAtividade.Location = new System.Drawing.Point(35, 69);
			this.txtbAtividade.Name = "txtbAtividade";
			this.txtbAtividade.Size = new System.Drawing.Size(215, 20);
			this.txtbAtividade.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Descrição";
			// 
			// lblDataCadastro
			// 
			this.lblDataCadastro.AutoSize = true;
			this.lblDataCadastro.Location = new System.Drawing.Point(32, 113);
			this.lblDataCadastro.Name = "lblDataCadastro";
			this.lblDataCadastro.Size = new System.Drawing.Size(93, 13);
			this.lblDataCadastro.TabIndex = 4;
			this.lblDataCadastro.Text = "Data do Cadastro:";
			// 
			// lblDataAtividade
			// 
			this.lblDataAtividade.AutoSize = true;
			this.lblDataAtividade.Location = new System.Drawing.Point(32, 179);
			this.lblDataAtividade.Name = "lblDataAtividade";
			this.lblDataAtividade.Size = new System.Drawing.Size(92, 13);
			this.lblDataAtividade.TabIndex = 6;
			this.lblDataAtividade.Text = "Data da Atividade";
			// 
			// dtpCadastro
			// 
			this.dtpCadastro.Location = new System.Drawing.Point(35, 138);
			this.dtpCadastro.Name = "dtpCadastro";
			this.dtpCadastro.Size = new System.Drawing.Size(215, 20);
			this.dtpCadastro.TabIndex = 7;
			// 
			// dtpAtividade
			// 
			this.dtpAtividade.Location = new System.Drawing.Point(35, 204);
			this.dtpAtividade.Name = "dtpAtividade";
			this.dtpAtividade.Size = new System.Drawing.Size(215, 20);
			this.dtpAtividade.TabIndex = 8;
			// 
			// dgvAtividades
			// 
			this.dgvAtividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAtividades.Location = new System.Drawing.Point(300, 12);
			this.dgvAtividades.Name = "dgvAtividades";
			this.dgvAtividades.Size = new System.Drawing.Size(488, 342);
			this.dgvAtividades.TabIndex = 9;
			this.dgvAtividades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtividades_CellClick);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(93, 242);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 10;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(175, 242);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 23);
			this.btnExcluir.TabIndex = 12;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnNovo
			// 
			this.btnNovo.Location = new System.Drawing.Point(12, 242);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(75, 23);
			this.btnNovo.TabIndex = 13;
			this.btnNovo.Text = "Novo";
			this.btnNovo.UseVisualStyleBackColor = true;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// Atividades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.dgvAtividades);
			this.Controls.Add(this.dtpAtividade);
			this.Controls.Add(this.dtpCadastro);
			this.Controls.Add(this.lblDataAtividade);
			this.Controls.Add(this.lblDataCadastro);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtbAtividade);
			this.Controls.Add(this.lblId);
			this.Name = "Atividades";
			this.Text = "Atividades";
			this.Load += new System.EventHandler(this.Atividades_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAtividades)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.TextBox txtbAtividade;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblDataCadastro;
		private System.Windows.Forms.Label lblDataAtividade;
		private System.Windows.Forms.DateTimePicker dtpCadastro;
		private System.Windows.Forms.DateTimePicker dtpAtividade;
		private System.Windows.Forms.DataGridView dgvAtividades;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnNovo;
	}
}

