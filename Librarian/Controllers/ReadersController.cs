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
    }
}
