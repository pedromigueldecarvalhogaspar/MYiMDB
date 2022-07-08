using IMDB.Data.Models;
using IMDB.Models;
using Microsoft.EntityFrameworkCore;

namespace IMDB.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilmeActor>()
                .HasOne(f => f.Filme)
                .WithMany(fa => fa.FilmesActores)
                .HasForeignKey(fa => fa.FilmeId);

            modelBuilder.Entity<FilmeActor>()
                .HasOne(f => f.Actor)
                .WithMany(fa => fa.FilmesActores)
                .HasForeignKey(fa => fa.ActorId);
        }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Actor> Actores { get; set; }
        public DbSet <Realizador> Realizadores { get; set; }
        public DbSet<FilmeActor> FilmesActores { get; set; }


    }
}
