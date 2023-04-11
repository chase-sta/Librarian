using System;
using Librarian.Models;
using Microsoft.AspNetCore.Mvc;

namespace Librarian.Controllers
{
	public class BooksController : Controller
	{
        private readonly ApplicationDbContext _db;

        public BooksController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var books = _db.Books.ToList();

            if (books == null)
            {
                return View("Not Found");
            }

            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Id, Title, Author, Genre")] Book book)
        {
            if (ModelState.IsValid)
            {
                _db.Add(book);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
    }
}

