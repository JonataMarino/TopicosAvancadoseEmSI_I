namespace Revisao07082023
{
	partial class FormAgenda
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
			this.txtbNome = new System.Windows.Forms.TextBox();
			this.txtbTelefone = new System.Windows.Forms.TextBox();
			this.dgvAgenda = new System.Windows.Forms.DataGridView();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblTelefone = new System.Windows.Forms.Label();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
			this.SuspendLayout();
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(15, 9);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(13, 13);
			this.lblId.TabIndex = 0;
			this.lblId.Text = "0";
			// 
			// txtbNome
			// 
			this.txtbNome.Location = new System.Drawing.Point(18, 53);
			this.txtbNome.Name = "txtbNome";
			this.txtbNome.Size = new System.Drawing.Size(184, 20);
			this.txtbNome.TabIndex = 1;
			this.txtbNome.TabStop = false;
			// 
			// txtbTelefone
			// 
			this.txtbTelefone.Location = new System.Drawing.Point(18, 102);
			this.txtbTelefone.Name = "txtbTelefone";
			this.txtbTelefone.Size = new System.Drawing.Size(184, 20);
			this.txtbTelefone.TabIndex = 2;
			// 
			// dgvAgenda
			// 
			this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAgenda.Location = new System.Drawing.Point(12, 140);
			this.dgvAgenda.Name = "dgvAgenda";
			this.dgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvAgenda.Size = new System.Drawing.Size(366, 189);
			this.dgvAgenda.TabIndex = 3;
			this.dgvAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellClick);
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(15, 37);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(38, 13);
			this.lblNome.TabIndex = 4;
			this.lblNome.Text = "Nome:";
			// 
			// lblTelefone
			// 
			this.lblTelefone.AutoSize = true;
			this.lblTelefone.Location = new System.Drawing.Point(15, 86);
			this.lblTelefone.Name = "lblTelefone";
			this.lblTelefone.Size = new System.Drawing.Size(52, 13);
			this.lblTelefone.TabIndex = 5;
			this.lblTelefone.Text = "Telefone:";
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(294, 9);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 6;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(294, 38);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(75, 23);
			this.btnEditar.TabIndex = 7;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(294, 99);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 23);
			this.btnExcluir.TabIndex = 8;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnNovo
			// 
			this.btnNovo.Location = new System.Drawing.Point(294, 67);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(75, 23);
			this.btnNovo.TabIndex = 9;
			this.btnNovo.Text = "Novo";
			this.btnNovo.UseVisualStyleBackColor = true;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// FormAgenda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 353);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.lblTelefone);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.dgvAgenda);
			this.Controls.Add(this.txtbTelefone);
			this.Controls.Add(this.txtbNome);
			this.Controls.Add(this.lblId);
			this.Name = "FormAgenda";
			this.Text = "Agenda";
			this.Load += new System.EventHandler(this.FormAgenda_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.TextBox txtbNome;
		private System.Windows.Forms.TextBox txtbTelefone;
		private System.Windows.Forms.DataGridView dgvAgenda;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblTelefone;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnNovo;
	}
}

