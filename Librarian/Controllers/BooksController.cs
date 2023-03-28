using System;
using Microsoft.AspNetCore.Mvc;

namespace Librarian.Controllers
{
	public class BooksController : Controller
	{
        public IActionResult Index()
        {
            return View();
        }
    }
}

