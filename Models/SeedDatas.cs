using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
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
                    Title = "The Shawshank Redemption",
                    ReleaseDate = DateTime.Parse("1994-9-10"),
                    Genre = "Drama",
                    Price = 25M,
                    Rating = "R"

                },
                new Movie
                {
                    Title = "The Godfather ",
                    ReleaseDate = DateTime.Parse("1972-3-24"),
                    Genre = "Crime",
                    Price = 6M,
                    Rating = "R"

                },
                new Movie
                {
                    Title = "The Dark Knight",
                    ReleaseDate = DateTime.Parse("2008-7-18"),
                    Genre = "Action",
                    Price = 185M,
                    Rating = "R"
                    
                },
                new Movie
                {
                    Title = "Schindler's List",
                    ReleaseDate = DateTime.Parse("1993-12-15"),
                    Genre = "Biography",
                    Price = 22M,
                    Rating = "R"

                },
                 new Movie
                 {
                     Title = "Pulp Fiction",
                     ReleaseDate = DateTime.Parse("1994-10-14"),
                     Genre = "Crime",
                     Price = 8M,
                     Rating = "R"

                 }
            );
            context.SaveChanges();
        }
    }
}