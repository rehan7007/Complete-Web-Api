using Microsoft.EntityFrameworkCore;
using my_book_api.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_book_api.Data
{
    public class AppDbcontext:DbContext 
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
