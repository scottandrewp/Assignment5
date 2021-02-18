using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class EFBookStoreRepository : IBookStoreRepository
    {
        private BookStoreDBContext _context;

        public EFBookStoreRepository(BookStoreDBContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
