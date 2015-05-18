using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlogWithMvc5.Models;

namespace BlogWithMvc5.Controllers
{
    public class VisitorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Visitor
        public ActionResult Index()
        {
            return View(db.Articles.ToList());
        }

        // GET: Visitor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            ViewBag.Title = article.Subject;
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
