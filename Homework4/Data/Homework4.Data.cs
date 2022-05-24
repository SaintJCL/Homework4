using Microsoft.AspNetCore.Identity;
using Homework4.Data;
using Homework4.Models;

namespace Homework4.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                if (!context.Infantries.Any())
                {
                    context.Infantries.AddRange(new List<Infantry>(){

                        new Infantry()
                        {
                            Name = "Isacc",
                            Email = "qwerty@outlook.com"

                        },

                        new Infantry() { Name = "Jones", Email = "yuiop@gmail.com" },

                        new Infantry() { Name = "Earl", Email = "asdf@yahoo.com" }
                    });

                    context.SaveChanges();
                }
            }
        }
    
    
    }
}
