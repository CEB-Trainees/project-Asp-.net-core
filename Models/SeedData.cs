using Crudapp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crudapp.Models
{
    public static class SeedData
    {
        public static void Intialize(IServiceProvider serviceProvider)
        {
            using (var context = new CrudappContext(
                serviceProvider.GetRequiredService<DbContextOptions<CrudappContext>>()))
            {
                if(context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleasedDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },

                     new Movie
                     {
                         Title = "Ghostbusters ",
                         ReleasedDate = DateTime.Parse("1984-3-13"),
                         Genre = "Comedy",
                         Price = 8.99M,
                         Rating = "M"
                     },

                     new Movie
                     {
                         Title = "Ghostbusters 2",
                         ReleasedDate = DateTime.Parse("1986-2-23"),
                         Genre = "Comedy",
                         Price = 9.99M,
                         Rating = "N"
                     },

                     new Movie
                     {
                         Title = "Rio Bravo",
                         ReleasedDate = DateTime.Parse("1959-4-15"),
                         Genre = "Western",
                         Price = 3.99M,
                         Rating = "P"
                     }
                    );
                context.SaveChanges();
            }
        }

    }
}
