﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CricInfo.Models;

namespace CricInfo.Controllers
{
    public class CommentController : Controller
    {
        private CricDbContext db = new CricDbContext();

        //
        // GET: /Comment/

        public ActionResult Index()
        {
            return View(db.Comments.ToList());
        }

        [ChildActionOnly]
        public ActionResult ByArticle(int articleId)
        {
            var comments = db.Comments.
                Where(c => c.ArticleId == articleId).ToList();
            
            ViewBag.ArticleId = articleId;

            return PartialView(comments);
        }
        
        //
        // GET: /Comment/Details/5

        public ActionResult Details(int id = 0)
        {
            Comment comment = db.Comments.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        //
        // GET: /Comment/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Comment/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Comment comment)
        {
            if (ModelState.IsValid)
            {
                if (comment.DateCommented.Year < DateTime.Now.Year)
                {
                    ModelState.AddModelError("DateCommented", "Cannot add a date in the past");
                    return View(comment);
                }

                comment.SecureField = 9998; //got this from encryptions algorithm
                db.Comments.Add(comment);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(comment);
        }

        //
        // GET: /Comment/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Comment comment = db.Comments.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        //
        // POST: /Comment/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Comment comment)
        {

            if (ModelState.IsValid)
            {
                db.Entry(comment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(comment);
        }

        //
        // GET: /Comment/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Comment comment = db.Comments.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        //
        // POST: /Comment/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Comment comment = db.Comments.Find(id);
            db.Comments.Remove(comment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}