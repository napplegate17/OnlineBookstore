using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Nicholas Applegate, 1-3

namespace OnlineBookstore.Models
{
    public interface iBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
