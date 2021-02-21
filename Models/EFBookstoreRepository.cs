using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Nicholas Applegate, 1-3

namespace OnlineBookstore.Models
{
    //Create Bookstore repository
    public class EFBookstoreRepository : iBookstoreRepository
    {
        private BookstoreDbContext _context;

        //Constructor
        public EFBookstoreRepository (BookstoreDbContext context)
        {
            _context = context;
        }
        //Add books to context attribute
        public IQueryable<Book> Books => _context.Books;
    }
}
