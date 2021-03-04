using Microsoft.AspNetCore.Mvc;
using OnlineBookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Nicholas Applegate, 1-3

namespace OnlineBookstore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private iBookstoreRepository repository;

        public NavigationMenuViewComponent (iBookstoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            //Dynamically collect categories
            ViewBag.SelectedCat = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
