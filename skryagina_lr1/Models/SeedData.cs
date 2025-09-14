using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using skryagina_lr1.Data;
using System;
using System.Linq;

namespace skryagina_lr1.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new skryagina_lr1Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<skryagina_lr1Context>>()))
        {
            // Look for any movies.
            if (context.ExampleModel.Any())
            {
                return;   // DB has been seeded
            }
            context.ExampleModel.AddRange(
                new ExampleModel
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M
                },
                new ExampleModel
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M
                },
                new ExampleModel
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M
                },
                new ExampleModel
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}