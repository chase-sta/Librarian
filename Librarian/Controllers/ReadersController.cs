using Librarian.Models;
using Microsoft.AspNetCore.Mvc;

namespace Librarian.Controllers
{
    public class ReadersController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ReadersController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var items = _db.Readers.ToList();
            if (items == null)
            {
                return NotFound();
            }
            return View(items);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Id,Name,Age,Email,BooksBorrowed")] Reader reader)
        {
            _db.Add(reader);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var reader = _db.Readers.FirstOrDefault(r => r.Id == id);
                return View(reader);
            }
        }

        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id,Name,Age,Email")] Reader reader)
        {
            if (id != reader.Id)
            {
                return NotFound();
            }

            _db.Update(reader);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return View("Not Found");
            }

            var reader = _db.Readers.FirstOrDefault(r => r.Id == id);

            return View(reader);
        }

        [HttpPost]
        public IActionResult Delete(int id, [Bind("Id, Name, Age, Email")] Reader reader)
        {
            if (id != reader.Id)
            {
                return View("Not Found");
            }

            _db.Remove(reader);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));

        }
    }
}
