using IMDB.Data.Models;
using IMDB.Data.ViewModels;
using IMDB.Models;
using System.Collections.Generic;
using System.Linq;

namespace IMDB.Data
{
    public class FilmesService
    {

        private AppDbContext _context;
        public FilmesService(AppDbContext context)
        {              
            _context = context;
        }

        public void AdicionarFilmeComActor(FilmeVM filme)
        {
            var _filme = new Filme()
            {
                
                Nome = filme.Nome,
                MinhaCotacao = filme.Visto ? filme.MinhaCotacao.Value : null,
                Merch = filme.Merch,
                BandaSonora = filme.BandaSonora,
                Imagem = filme.Imagem,
                Visto = filme.Visto,
                VistoQuando = filme.Visto ? filme.VistoQuando.Value : null,
                RealizadorId = filme.RealizadorId,
            };

            _context.Filmes.Add(_filme);
            _context.SaveChanges();

            foreach (var id in filme.ActoresIds)
            {
                var _filme_actor = new FilmeActor()
                {
                    FilmeId = _filme.Id,
                    ActorId = id,
                };
                _context.FilmesActores.Add(_filme_actor);
                _context.SaveChanges();
            }
        }

        public List<Filme> VerTodosFilmes()
        {
            var todosOsFilmes = _context.Filmes.ToList();
            return todosOsFilmes;
        }

        public FilmeComActoresVM VerFilmeById( int filmeId)
        {
            var filmeComActores = _context.Filmes.Where(n => n.Id == filmeId).Select(filme => new FilmeComActoresVM()
            {

                Nome = filme.Nome,
                MinhaCotacao = filme.Visto ? filme.MinhaCotacao.Value : null,
                Merch = filme.Merch,
                BandaSonora = filme.BandaSonora,
                Imagem = filme.Imagem,
                Visto = filme.Visto,
                VistoQuando = filme.Visto ? filme.VistoQuando.Value : null,
                RealizadorNome = filme.Realizador.Nome,
                ActoresNomes = filme.FilmesActores.Select(n => n.Actor.Nome).ToList(),
            }).FirstOrDefault();

            return filmeComActores;
        }

        public void ApagarFilmeById(int filmeId)
        {
            
                var filme = _context.Filmes.FirstOrDefault(f => f.Id == filmeId);
            if (filme != null)
            {
                _context.Filmes.Remove(filme);
                _context.SaveChanges();
                
            }
            return;
        }

        public Filme EditarFilmeById( int filmeID, FilmeVM filme)
        {
            var _filme = _context.Filmes.FirstOrDefault(f => f.Id == filmeID);
            if(_filme != null)
            {
                _filme.Nome = filme.Nome;
                _filme.MinhaCotacao = filme.Visto ? filme.MinhaCotacao.Value : null;
                _filme.Merch = filme.Merch;
                _filme.BandaSonora = filme.BandaSonora;
                _filme.Imagem = filme.Imagem;
                _filme.Visto = filme.Visto;
                _filme.VistoQuando = filme.Visto ? filme.VistoQuando.Value : null;

                _context.SaveChanges();
                
            }
            return _filme;

        }
    }
}
