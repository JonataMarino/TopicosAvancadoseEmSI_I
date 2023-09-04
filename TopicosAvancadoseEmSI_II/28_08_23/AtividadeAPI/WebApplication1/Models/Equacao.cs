using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
namespace WebApplication1.Models
{
	public class Equacao
	{
		public int Id { get; set; }
		public double A { get; set; }
		public double B { get; set; }
		public double C { get; set; }
		[JsonIgnore] // Isso impede que a propriedade Delta seja serializada
		public double Delta
		{
			get
			{
				return (B * B) - (4 * A * C);
			}

		}

		public double X1 { get => Raiz1(X1); }
		public double Raiz1(double x1)
		{
			if (Delta >= 0)
			{
				x1 = (-B + Math.Sqrt(Delta)) / (2 * A);
				return x1;
			}
			else
			{
				// Trate o caso de raízes complexas ou delta negativo aqui, se necessário.
				// Pode retornar NaN (Not-a-Number) ou outra coisa apropriada.
				return x1;
			}
		}

		public double X2 { get => Raiz2(X2);}
		public double Raiz2(double x2)
		{
			if (Delta >= 0)
			{
				x2 = (-B - Math.Sqrt(Delta)) / (2 * A);
				return x2;
			}
			else
			{
				// Trate o caso de raízes complexas ou delta negativo aqui, se necessário.
				// Pode retornar NaN (Not-a-Number) ou outra coisa apropriada.
				return x2;
			}
		}
	}
}