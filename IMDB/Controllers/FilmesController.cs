using IMDB.Data;
using IMDB.Data.ViewModels;
using IMDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private FilmesService _filmesService;

        public FilmesController(FilmesService filmesService)
        {
            _filmesService = filmesService;
        }

        [HttpPost("Add-filme-com-actor")]
        public IActionResult AdicionarFilme ([FromBody] FilmeVM filme)
        {
            _filmesService.AdicionarFilmeComActor(filme);
            return Ok();
        }

        [HttpGet("Get-all-filmes")]
        public IActionResult VerTodosFilme()
        {
            var todosOsFilmes =_filmesService.VerTodosFilmes();
            return Ok(todosOsFilmes);
            
        }

        [HttpGet("Get-By-id/{filmeId}")]
        public IActionResult VerFilmeById( int filmeId)
        {
            var filme = _filmesService.VerFilmeById(filmeId);
            return Ok(filme);

        }
        
        [HttpPut("Edit-by-Id/{filmeId}")]

        public IActionResult EditarFilmeById(int filmeId, [FromBody] FilmeVM editedFilme)
        {
            var filme = _filmesService.EditarFilmeById(filmeId, editedFilme);
            return Ok(filme);

        }


        [HttpDelete("Delete-By-id/{filmeId}")]
        public IActionResult ApagarFilmeById(int filmeId)
        {
            _filmesService.ApagarFilmeById(filmeId);
            return Ok();

        }
    }
}
