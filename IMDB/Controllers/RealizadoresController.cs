using IMDB.Data.Services;
using IMDB.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealizadoresController : ControllerBase
    {
        private RealizadoresService _realizadoresService;

        public RealizadoresController(RealizadoresService realizadoresService)
        {
            _realizadoresService = realizadoresService;
        }

        [HttpPost("add-Realizador")]
        public IActionResult AdicionarRealizador([FromBody] RealizadorVM realizador)
        {
            _realizadoresService.AdicionarRealizador(realizador);
            return Ok();
        }

    }
}
