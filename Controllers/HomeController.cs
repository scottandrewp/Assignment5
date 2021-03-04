using Assignment4.Models;
using Assignment4.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBookStoreRepository _repository;

        public int PageSize = 5;
        public HomeController(ILogger<HomeController> logger, IBookStoreRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index(string genre, int page = 1)
        {

            return View(new BookListViewModel
            {
                Books = _repository.Books   //Format repository info and take the info according to the number of items per page desired
                    .OrderBy(p => p.BookId)
                    .Where(p => genre == null  || p.Genre == genre ) // this allows me to filter by genre. I chose genre because I think it makes more sense for books. 
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize)

                ,

                PagingInfo = new PagingInfo // set the Paging info
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = genre == null ? _repository.Books.Count() : 
                        _repository.Books.Where(x => x.Genre == genre).Count()
                },
                CurrentGenre = genre
            }) ;
                
               
                
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
