using CEPAppViaCEP.Integracao.Interfaces;
using CEPAppViaCEP.Integracao.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CEPAppViaCEP.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CEPController : ControllerBase
	{
		private readonly IViaCepIntegracao _viaCepIntegracao;
		public CEPController(IViaCepIntegracao viaCepIntegracao) 
		{
			_viaCepIntegracao = viaCepIntegracao;
		}

		[HttpGet("{cep}")]
		public async Task<ActionResult<ViaCepResponse>> ListarDadosEndereco(string cep)
		{ 
		  var responseData = await	_viaCepIntegracao.ObterDadosViaCep(cep);

			if (responseData == null)
			{
				return BadRequest("CEP não encontrado");
			}
			return Ok(responseData);
		}
	}
}
