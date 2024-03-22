using Microsoft.AspNetCore.Mvc;
using Mission_11.Models;
using Mission_11.Models.ViewModels;
using System.Diagnostics;

namespace Mission_11.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository _repo;

        public HomeController(IBookstoreRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var blah = new BooksListViewModel
            {
                Books = _repo.Books
                .OrderBy(x => x.BookId)
                .Skip(pageSize * (pageNum - 1))
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };
            return View(blah);
        }
    }
}
