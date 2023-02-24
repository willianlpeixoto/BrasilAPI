using BrasilAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BrasilAPI.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class FeriadosNacionaisController : ControllerBase
    {

        public readonly InterfaceFeriadosNacionais _FeriadosNacionaisService;

        public FeriadosNacionaisController(InterfaceFeriadosNacionais FeriadosNacionaisService)
        {

            _FeriadosNacionaisService = FeriadosNacionaisService;

        }

        [HttpGet("buscar/{nAno}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> BuscarFeriadosNacionais([FromRoute] int nAno)
        {

            var response = await _FeriadosNacionaisService.BuscarFeriadosNacionais(nAno);

            if (response.CodHttp == System.Net.HttpStatusCode.OK)
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
