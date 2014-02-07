using CricInfo.Models;
using CricInfo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CricInfo.Controllers
{
    public class ArticlesController : Controller
    {
        private CricDbContext db = new CricDbContext();
        //
        // GET: /Articles/

        [Log]
        public ActionResult Index()
        {
            //a
            ViewData["SubTitle"] = "great Articles";

            //1. Prepare model
            var articles = db.Articles.ToList();

            var viewModels = new List<ArticleIndexViewModel>();

            foreach (var article in articles)
            {
                var viewModel = new ArticleIndexViewModel()
                {
                    ArticleId = article.Id,
                    Title = article.Title,
                    Body = article.Body,
                    PublishDate = article.DatePublished,
                    FbLikes = article.FbLikes,
                    Tweets = article.Tweets,
                    PlusShares = article.PlusShares
                };

                var ratings = db.Comments.
                    Where(c => c.ArticleId == article.Id).ToList();

                if (ratings != null && ratings.Count > 0)
                {
                    viewModel.AverageRating = ratings.Average(r => r.Rating);
                }

                viewModels.Add(viewModel);
                    
            }

            //2. Select View

            //3. make the model available to the view
            return View(viewModels);
        }

        public ActionResult Details(int id)
        {
            var targetArticle = db.Articles.Find(id);

            return View(targetArticle);

        }

    }
}
