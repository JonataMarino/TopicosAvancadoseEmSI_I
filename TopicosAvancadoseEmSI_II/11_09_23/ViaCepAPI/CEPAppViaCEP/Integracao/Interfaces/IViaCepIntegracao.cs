using CEPAppViaCEP.Integracao.Response;

namespace CEPAppViaCEP.Integracao.Interfaces
{
	public interface IViaCepIntegracao
	{
		Task<ViaCepResponse> ObterDadosViaCep(string cep);
	}
}
