using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore_Application.Models
{
    public class SeedData
    {
        public static void EnsuraPopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().
                ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A boat for one",
                        Price = 275,
                        Category = "Water Sports"
                    },
                     new Product
                     {
                         Name = "Kayak 2",
                         Description = "A boat for one",
                         Price = 275,
                         Category = "Water Sports"
                     },
                     new Product
                     {
                         Name = "Kayak 3",
                         Description = "A boat for one",
                         Price = 275,
                         Category = "Water Sports"
                     },
                     new Product
                     {
                         Name = "Kayak 4",
                         Description = "A boat for one",
                         Price = 275,
                         Category = "Water Sports"
                     },
                     new Product
                     {
                         Name = "Kayak 5",
                         Description = "A boat for one",
                         Price = 275,
                         Category = "Water Sports"
                     },
                     new Product
                     {
                         Name = "Kayak 6",
                         Description = "A boat for one",
                         Price = 275,
                         Category = "Water Sports"
                     },
                     new Product
                     {
                         Name = "Kayak 7",
                         Description = "A boat for one",
                         Price = 275,
                         Category = "Water Sports"
                     },
                     new Product
                     {
                         Name = "Kayak 8",
                         Description = "A boat for one",
                         Price = 275,
                         Category = "Water Sports"
                     },
                     new Product
                     {
                         Name = "Kayak 9",
                         Description = "A boat for one",
                         Price = 275,
                         Category = "Water Sports"
                     },
                     new Product
                     {
                         Name = "Kayak 10",
                         Description = "A boat for one",
                         Price = 275,
                         Category = "Water Sports"
                     }
                    );
                context.SaveChanges();
            }
        }
    }
}
