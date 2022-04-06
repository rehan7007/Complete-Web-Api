using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using my_book_api.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_book_api.Data
{
    public class AppDbIntializer
    {
        public static void seed(IApplicationBuilder applicationBuilder)
        {
            using(var ServiceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = ServiceScope.ServiceProvider.GetService<AppDbcontext>();
                if(!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "1st Book Title",
                        Description = "1st Book Description",
                        Isread = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biogrpahy",
                        Author = "First Author",
                        Coverurl = "httpss......",
                        DateAdded = DateTime.Now

                    }, new Book()
                    {
                        Title = "2nd Book Title",
                        Description = "2nd Book Description",
                        Isread = true,
                        DateRead = DateTime.Now.AddDays(-5),
                        Rate = 6,
                        Genre = "AutoBioGrpahy",
                        Author = "Second Author",
                        Coverurl = "https......",
                        DateAdded = DateTime.Now
                    }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
