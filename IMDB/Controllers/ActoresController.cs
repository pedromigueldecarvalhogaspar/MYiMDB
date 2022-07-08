using IMDB.Data.Services;
using IMDB.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActoresController : ControllerBase
    {
        private ActoresService _actoresService;

        public ActoresController(ActoresService actoresService)
        {
            _actoresService = actoresService;
        }

        [HttpPost("add-Actor")]
        public IActionResult AdicionarActor([FromBody] ActorVM actor)
        {
            _actoresService.AdicionarActor(actor);
            return Ok();
        }

        [HttpGet("Get-all-actores")]
        public IActionResult VerTodosActores()
        {
            var todosOsActores = _actoresService.VerTodosActores();
            return Ok(todosOsActores);

        }

    }
}
