using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    public class WorksController : Controller
    {
        PortfolioContext db;
        public WorksController(PortfolioContext context)
        {
            db = context;
            AllWorks();
        }

        private IActionResult AllWorks()
        {
            return View(db.Works.ToList());
        }
        public IActionResult Portfolio()
        {
            return View(db.Works.ToList());
        }
        public IActionResult ALL()
        {
            return View();
        }
        /*
        public IActionResult Codding()
        {
            return View();
        }
        public IActionResult Design()
        {
            return View();
        }
        */
        public string MyFullName(string name, string surname)
        {
            return $"Your full name: {name} {surname}";
        }

    }
}
