using System;
using System.Collections.Generic;

namespace IMDB.Data.ViewModels
{
    public class FilmeVM
    {
        public string Nome { get; set; }
        public decimal? MinhaCotacao { get; set; }
        public string Merch { get; set; }
        public string BandaSonora { get; set; }
        public string Imagem { get; set; }

        public bool Visto { get; set; }
        public DateTime? VistoQuando { get; set; }

        public int RealizadorId { get; set; }

        public List<int> ActoresIds { get; set; }

    }

    public class FilmeComActoresVM
    {
        public string Nome { get; set; }
        public decimal? MinhaCotacao { get; set; }
        public string Merch { get; set; }
        public string BandaSonora { get; set; }
        public string Imagem { get; set; }

        public bool Visto { get; set; }
        public DateTime? VistoQuando { get; set; }

        public string RealizadorNome { get; set; }

        public List<string> ActoresNomes { get; set; }

    }
}
