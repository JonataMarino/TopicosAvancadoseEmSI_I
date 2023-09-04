using System.Security.Cryptography.X509Certificates;


namespace WebApplication1.Models
{
	public class Equacao
	{
		public int Id { get; set; }
		public double A { get; set; }
		public double B { get; set; }
		public double C { get; set; }

		private double _delta;
		private double _x1;
		private double _x2;

		public double Delta
		{
			get
			{ 
				return _delta;
			}
			set
			{
				_delta = (B * B) - (4 * A * C);
			}
		}

		public double X1 {
			get
			{
				return _x1;
			}
			set {
				_x1 = Raiz1();
			}
		}
		double Raiz1()
		{
			if (Delta >= 0)
			{
				return (-B + Math.Sqrt(Delta)) / (2 * A);
			}
			else
			{
				// Trate o caso de raízes complexas ou delta negativo aqui, se necessário.
				// Pode retornar NaN (Not-a-Number) ou outra coisa apropriada.
				return (-B - Math.Sqrt(Delta)) / (2 * A);
			}
		}

		public double X2
		{
			get
			{
				return _x2;
			}
			set
			{
				_x2 = Raiz2();
			}
		}
		double Raiz2()
		{
			if (Delta >= 0)
			{
				return (-B - Math.Sqrt(Delta)) / (2 * A);
			}
			else
			{
				// Trate o caso de raízes complexas ou delta negativo aqui, se necessário.
				// Pode retornar NaN (Not-a-Number) ou outra coisa apropriada.
				return (-B - Math.Sqrt(Delta)) / (2 * A);
			}
		}
	}
}