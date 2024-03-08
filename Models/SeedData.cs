using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-2-12"),
                        Genre = "Family",
                        Price = 7.99M,
                        Rating = "N",
                        Image = "/images/meet.jpg"
                    },
                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("2003-01-31"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "N",
                        Image="/images/therm.jpeg"
                    },
                    new Movie
                    {
                        Title = "The Other Side Of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre ="Inspirational",
                        Price = 9.99M,
                        Rating = "N",
                        Image="/images/theothersideofheaven.jpg"
                    },
                      new Movie
                      {
                          Title = "Johny Lingo",
                          ReleaseDate = DateTime.Parse("1969-12-14"),
                          Genre = "Inspirational",
                          Price = 10.99M,
                          Rating = "N",
                          Image = "/images/johny.jpg"
                      }

                );
                context.SaveChanges();
            }
        }
    }
}
