using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlogWithMvc5.Models;
using PagedList;
using PagedList.Mvc;

namespace BlogWithMvc5.Controllers
{
    public class VisitorController : Controller
    {
        //Database Connection
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Visitor
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Index(int pageNumber = 1)
        {
            return View(db.Articles.OrderBy(x => x.date).ToList().ToPagedList(pageNumber, 10));
        }

        // GET: Visitor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            ViewBag.Message = article.Subject;
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
