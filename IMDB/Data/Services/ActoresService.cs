using IMDB.Data.Models;
using IMDB.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace IMDB.Data.Services
{
    public class ActoresService
    {
        private AppDbContext _context;
        public ActoresService(AppDbContext context)
        {
            _context = context;
        }

        public void AdicionarActor(ActorVM actor)
        {
            var _actor = new Actor()
            {

                Nome = actor.Nome,
            };

            _context.Actores.Add(_actor);
            _context.SaveChanges();
        }

        public List<Actor> VerTodosActores()
        {
            var todosOsActores = _context.Actores.ToList();
            return todosOsActores;

        }
    }
}

