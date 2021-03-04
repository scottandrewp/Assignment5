using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Component
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookStoreRepository repository;

        public NavigationMenuViewComponent(IBookStoreRepository r)
        {
            repository = r;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGenre = RouteData?.Values["genre"];

            return View(repository.Books
                .Select(x => x.Genre)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
