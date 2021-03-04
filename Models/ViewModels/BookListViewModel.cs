using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Nicholas Applegate, 1-3

namespace OnlineBookstore.Models.ViewModels
{
    //Set up class for book and paging info together
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
