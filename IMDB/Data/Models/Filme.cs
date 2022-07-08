using IMDB.Data.Models;
using MeuNovoImdb.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMDB.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal? MinhaCotacao { get; set; }
        public string Merch { get; set; }
        public string BandaSonora { get; set; }
        public string Imagem { get; set; }

        public bool Visto { get; set; }

        public DateTime? VistoQuando { get; set; }

        public int RealizadorId { get; set; }

        public Realizador Realizador { get; set; }

        public List<FilmeActor> FilmesActores { get; set; }
    }
}
