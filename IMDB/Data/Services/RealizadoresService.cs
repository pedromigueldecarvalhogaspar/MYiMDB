using IMDB.Data.Models;
using IMDB.Data.ViewModels;

namespace IMDB.Data.Services
{
    public class RealizadoresService
    {
        private AppDbContext _context;
        public RealizadoresService(AppDbContext context)
        {
            _context = context;
        }

        public void AdicionarRealizador(RealizadorVM realizador)
        {
            var _realizador = new Realizador()
            {

                Nome = realizador.Nome,
            };

            _context.Realizadores.Add(_realizador);
            _context.SaveChanges();
        }
    }
}
