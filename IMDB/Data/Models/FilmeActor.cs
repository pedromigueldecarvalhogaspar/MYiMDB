using IMDB.Models;

namespace IMDB.Data.Models
{
    public class FilmeActor
    {
        public int Id { get; set; }

        public int FilmeId { get; set; }
        public Filme Filme { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }


    }
}
