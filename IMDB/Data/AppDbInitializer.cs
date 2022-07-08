/*using IMDB.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace IMDB.Data
{
    public class AppDbInitializer
    {
        public static void Seed (IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Filmes.Any())
                {
                    context.Filmes.AddRange(new Filme()
                    {
                        Nome = "Fight Club",
                        MinhaCotacao = 5,
                        BandaSonora ="Caixinhas",
                        Visto = true,
                        Imagem ="",
                        VistoQuando = DateTime.Now
                    },
                    new Filme()
                    {
                        Nome = "Se7en",
                        BandaSonora = "Caixinhas",
                        Visto = false,
                        Imagem = "",
                        VistoQuando = DateTime.Now
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}*/
