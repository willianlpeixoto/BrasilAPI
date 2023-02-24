using BrasilAPI.Interfaces;
using BrasilAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BrasilAPI.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class BancoController : ControllerBase
    {

        public readonly InterfaceBanco _bancoService;

        public BancoController(InterfaceBanco bancoService)
        {

            _bancoService = bancoService;

        }

        [HttpGet("buscar/todosbancos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> BuscarTodosBancos( )
        {

            var response = await _bancoService.BuscarTodosBancos();

            if (response.CodHttp == System.Net.HttpStatusCode.OK)
            {

                return Ok(response.DadosRetorno);

            }
            else
            {

                return StatusCode((int)response.CodHttp, response.ErroRetorno);

            }

        }

        [HttpGet("buscar/{sCodigoBanco}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> BuscarBanco([FromRoute] [RegularExpression("^[0-9]*$")]string sCodigoBanco)
        {

            var response = await _bancoService.BuscarBanco(sCodigoBanco);

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