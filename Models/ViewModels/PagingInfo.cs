using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Nicholas Applegate, 1-3

namespace OnlineBookstore.Models.ViewModels
{
    public class PagingInfo
    {
        //Create class for page attributes, dynamically calculate how many pages we'll need
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int) (Math.Ceiling((decimal) TotalNumItems / ItemsPerPage));
    }
}
