using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class BookStoreDBContext : DbContext
    {
        public BookStoreDBContext (DbContextOptions<BookStoreDBContext> options) : base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
