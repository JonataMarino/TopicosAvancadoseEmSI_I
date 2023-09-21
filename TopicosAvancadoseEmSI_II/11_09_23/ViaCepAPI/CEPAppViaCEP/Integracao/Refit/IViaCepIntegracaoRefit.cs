using CEPAppViaCEP.Integracao.Response;
using Refit;

namespace CEPAppViaCEP.Integracao.Refit
{
	public interface IViaCepIntegracaoRefit
	{
		[Get("/ws/{cep}/json")]
		Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);
	}
}
