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

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("Not Found");
            }

            var book = _db.Books.FirstOrDefault(b => b.Id == id);

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id, Title, Author, Genre")] Book book)
        {
            if (id != book.Id)
            {
                return View("Not Found");
            }

            _db.Update(book);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));

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

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return View("Not Found");
            }

            var dish = _db.Books.FirstOrDefault(d => d.Id == id);

            return View(dish);
        }

        [HttpPost]
        public IActionResult Delete(int id, [Bind("Id, Title, Author, Genre")] Book book)
        {
            if (id != book.Id)
            {
                return View("Not Found");
            }

            _db.Remove(book);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));

        }
    }
}

