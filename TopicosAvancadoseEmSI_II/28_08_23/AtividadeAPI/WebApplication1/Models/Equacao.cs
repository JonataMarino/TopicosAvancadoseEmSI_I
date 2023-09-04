namespace WebApplication1.Models
{
	public class Equacao
	{
		public int Id { get; set; }
		public double a { get; set; }
		public double b { get; set; }
		public double c { get; set; }
		public double delta
		{
			get { return (b * b) - (4 * a * c); }
		}
		public double Raiz1()
		{
			get { return (-b + Math.Sqrt(delta)) / (2 * a); }
		}
		public double Raiz2()
		{
			return (-b - Math.Sqrt(delta)) / (2 * a);
		}
	}
}