using CricInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CricInfo.Controllers
{
    public class ArticlesController : Controller
    {
        //
        // GET: /Articles/

        public ActionResult Index()
        {
            //1. Prepare model
            var articles = (new ArticlesProvider()).GetArticles();

            //2. Select View

            //3. make the model available to the view
            return View(articles);
        }

        public ActionResult Details(int id)
        {
            var articles = (new ArticlesProvider()).GetArticles();
            var targetArticle = articles.Where(a => a.Id == id).Single();

            return View(targetArticle);

        }

    }
}
