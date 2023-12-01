using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcGames.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcGamesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcGamesContext>>()))
            {
                // Look for any Games.
                if (context.Games.Any())
                {
                    return;   // DB has been seeded
                }

                context.Games.AddRange(
                    new Games
                    {
                        Title = "Dragon's Dogma",
                        ReleaseDate = DateTime.Parse("2012-5-22"),
                        Publisher = "Capcom",
                        Developer = "Capcom",
                        Genre = "Fantasy",
                        Score = 10,
                        Price = 79.99M
                    },

                    new Games
                    {
                        Title = "Final Fantasy 16",
                        ReleaseDate = DateTime.Parse("2023-6-22"),
                        Publisher = "Square Enix",
                        Developer = "Square Enix",
                        Genre = "Fantasy",
                        Score = 7,
                        Price = 79.99M
                    },
                    new Games
                    {
                        Title = "Street Fighter 6",
                        ReleaseDate = DateTime.Parse("2023-6-03"),
                        Publisher = "Capcom",
                        Developer = "Capcom",
                        Genre = "Fighting",
                        Score = 10,
                        Price = 79.99M
                    },
                    new Games
                    {
                        Title = "Tekken 7",
                        ReleaseDate = DateTime.Parse("2015-2-18"),
                        Publisher = "Bandai Namco Entertainment",
                        Developer = "Arika",
                        Genre = "Fighting",
                        Score = 6,
                        Price = 49.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}