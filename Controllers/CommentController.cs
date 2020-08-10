using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    public class CommentController : Controller
    {
        CommentContext db;
        public CommentController(CommentContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Comment()
        {
            showAllComments();
            return View("Comment");
        }

        private IActionResult showAllComments()
        {
            List<Comment> countries = db.Comments.ToList();
            return View("AllComments", countries);
        }

        [HttpPost]
        public IActionResult Comment(Comment comment)
        {
            db.Comments.Add(comment);
            db.SaveChanges();
            showAllComments();
            return View("Comment");
        }
    }
}
