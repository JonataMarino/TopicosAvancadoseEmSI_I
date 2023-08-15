using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjWebFormClass1
{
	public partial class Default : System.Web.UI.Page
	{
		static List<Idade> lstIdade = new List<Idade>();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void BtnCalcular_Click(object sender, EventArgs e)
		{

			int idade = int.Parse(txtValor.Text);

			if (idade >= 18)
				lblMsg.Text = "Maior de Idade";
			else
				lblMsg.Text = "Menor de Idade";

			lstIdade.Add(new Idade() {IdadePessoa = idade, Mensagem = lblMsg.Text});
			LoadGrid();
	
		}

		private void LoadGrid()
		{
			GDVPicapau.DataSource = lstIdade;
			GDVPicapau.DataBind();
		}
	}
}