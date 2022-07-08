using System.Collections.Generic;

namespace IMDB.Data.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<FilmeActor> FilmesActores { get; set; }


    }
}
