using IMDB.Models;
using System.Collections.Generic;

namespace IMDB.Data.Models
{
    public class Realizador
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<Filme> Filmes { get; set; }
    }
}
