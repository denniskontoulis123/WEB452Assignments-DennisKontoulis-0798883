using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCAssignment.Data;

namespace MVCAssignment.Models{
    public static class SeedData {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());
            
            if (context.Smartphones.Any())
            {
                return; // seeds the database
            }

            context.Smartphones.AddRange(
                new Smartphone { Brand = "Apple", Model = "iPhone 15 Pro Max", Price = 1499.99, OS = "IOS", Storage = 256},
                new Smartphone { Brand = "Google", Model = "Pixel 8 Pro", Price = 1349.99, OS = "GoogleOS", Storage = 256},
                new Smartphone { Brand = "Samsung", Model = "S23 Ultra", Price = 1999.99, OS = "Android", Storage = 256},
                new Smartphone { Brand = "LG", Model = "LG Velvet", Price = 299.99, OS = "Android", Storage = 128}
            );
        }
    }
}