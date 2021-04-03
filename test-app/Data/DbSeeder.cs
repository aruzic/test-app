using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test_app.Data.Models;

namespace test_app.Data
{
    public class DbSeeder
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "1st Book Title",
                        Description = "1st Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Genre = "Biography",
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now
                    },
                    new Book() 
                    {
                        Title = "2st Book Title",
                        Description = "2st Book Description",
                        IsRead = false,
                        Genre = "Biography",
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now
                    });

                    context.SaveChanges();
                }

                if (!context.Users.Any())
                {
                    context.Users.AddRange(new User()
                    {
                        username = "aruzic",
                        password = "12345678",
                        name = "Aleks",
                        surname = "Ruzic",
                        email = "aruzic@email.com",
                        DateRegistration = DateTime.Now,
                        IsAdmin = true
                    });

                    context.SaveChanges();
                }
            }
            
            }
        }
}
