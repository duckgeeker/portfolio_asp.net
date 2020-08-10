using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    public class MainController : Controller
    {
        PortfolioContext db;
        public MainController(PortfolioContext context)
        {
            db = context;
        }
        
        public IActionResult Index()
        {
            return View(db.Works.ToList());
        }
        
        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.workId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return "Спасибо, " + order.user_name + ", за покупку!";
        }
    }
}
