using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookStoreDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookStoreDBContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                       //BookId = 1,
                        Title = "Les Miserables",
                        AuthorFirstName = "Victor",
                        AuthorLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Fiction = true,
                        Genre = "Classic",
                        Price = 9.95
                    },

                    new Book
                    {
                        //BookId = 2,
                        Title = "Team of Rivals",
                        AuthorFirstName = "Doris Kearns",
                        AuthorLastName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Fiction = false,
                        Genre = "Biography",
                        Price = 14.58
                    },

                     new Book
                     {
                        // BookId = 3,
                         Title = "The Snowball",
                         AuthorFirstName = "Alice",
                         AuthorLastName = "Schroeder",
                         Publisher = "Bantam",
                         ISBN = "978-0553384611",
                         Fiction = false,
                         Genre = "Biography",
                         Price = 21.54
                     },

                     new Book
                     {
                         //BookId = 4,
                         Title = "American Ulysses",
                         AuthorFirstName = "Ronald C.",
                         AuthorLastName = "White",
                         Publisher = "Random House",
                         ISBN = "978-0812981254",
                         Fiction = false,
                         Genre = "Biography",
                         Price = 11.61
                     },

                     new Book
                     {
                        // BookId = 5,
                         Title = "Unbroken",
                         AuthorFirstName = "Laura",
                         AuthorLastName = "Hillenbrand",
                         Publisher = "Random House",
                         ISBN = "978-0812974492",
                         Fiction = false,
                         Genre = "Historical",
                         Price = 13.33
                     },

                     new Book
                     {
                         //BookId = 6,
                         Title = "The Great Train Robbery",
                         AuthorFirstName = "Michael",
                         AuthorLastName = "Crichton",
                         Publisher = "Vintage",
                         ISBN = "978-0804171281",
                         Fiction = true,
                         Genre = "Historical Fiction",
                         Price = 15.95
                     },

                     new Book
                     {
                         //BookId = 7,
                         Title = "Deep Work",
                         AuthorFirstName = "Cal",
                         AuthorLastName = "Newport",
                         Publisher = "Grand Central Publishing",
                         ISBN = "978-1455586691",
                         Fiction = false,
                         Genre = "Self-Help",
                         Price = 14.99
                     },

                     new Book
                     {
                         //BookId = 8,
                         Title = "It's Your Ship",
                         AuthorFirstName = "Michael",
                         AuthorLastName = "Abrashoff",
                         Publisher = "Grand Central Publishing",
                         ISBN = "978-1455523023",
                         Fiction = false,
                         Genre = "Self-Help",
                         Price = 21.66
                     },

                     new Book
                     {
                         //BookId = 9,
                         Title = "The Virgin Way",
                         AuthorFirstName = "Richard",
                         AuthorLastName = "Branson",
                         Publisher = "Portfolio",
                         ISBN = "978-1591847984",
                         Fiction = false,
                         Genre = "Business",
                         Price = 29.16
                     },

                     new Book
                     {
                        // BookId = 10,
                         Title = "Sycamore Row",
                         AuthorFirstName = "John",
                         AuthorLastName = "Grisham",
                         Publisher = "Bantam",
                         ISBN = "978-0553393613",
                         Fiction = true,
                         Genre = "Thrillers",
                         Price = 15.03
                     }
                );

                context.SaveChanges();
            }
        }
    }
}
