using BrasilAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BrasilAPI.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class EnderecoController : ControllerBase
    {

        public readonly InterfaceEndereco _enderecoService;

        public EnderecoController(InterfaceEndereco enderecoService)
        {

            _enderecoService = enderecoService;

        }

        [HttpGet("buscar/{sCEP}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> BuscarEndereco([FromRoute] string sCEP)
        {

            var response = await _enderecoService.BuscarEndrecoPorCEP(sCEP);

            if( response.CodHttp == System.Net.HttpStatusCode.OK )
            {
                
                return Ok(response.DadosRetorno);

            }
            else
            {

                return StatusCode((int)response.CodHttp, response.ErroRetorno);

            }

        }

    }

}
