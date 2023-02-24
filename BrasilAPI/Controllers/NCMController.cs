using BrasilAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BrasilAPI.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class NCMController : ControllerBase
    {

        public readonly InterfaceNCM _NCMService;

        public NCMController(InterfaceNCM NCMService)
        {

            _NCMService = NCMService;

        }

        [HttpGet("buscar/todosNCMs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> BuscarTodosNCMs()
        {

            var response = await _NCMService.BuscarTodosNCMs();

            if (response.CodHttp == System.Net.HttpStatusCode.OK)
            {

                return Ok(response.DadosRetorno);

            }
            else
            {

                return StatusCode((int)response.CodHttp, response.ErroRetorno);

            }

        }

        [HttpGet("buscar/{sCodigoNCM}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> BuscarNCM([FromRoute][RegularExpression("^[0-9]*$")] string sCodigoNCM)
        {

            var response = await _NCMService.BuscarNCM(sCodigoNCM);

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