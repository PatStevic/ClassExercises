using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab._22.Models;

namespace Lab._22.Controllers
{
    public class MovieControler : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MovieList MovieList)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(MovieList);
        }
    }
}
