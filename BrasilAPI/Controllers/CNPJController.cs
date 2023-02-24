using BrasilAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BrasilAPI.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class CNPJController : ControllerBase
    {

        public readonly InterfaceCNPJ _CNPJService;

        public CNPJController(InterfaceCNPJ CNPJService)
        {

            _CNPJService = CNPJService;

        }

        [HttpGet("buscar/{sCNPJ}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> BuscarCNPJ([FromRoute] string sCNPJ)
        {

            var response = await _CNPJService.BuscarCNPJ(sCNPJ);

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

