using CricInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CricInfo.Controllers
{
    public class LiveScoreController : Controller
    {
        private CricDbContext db = new CricDbContext();
        //
        // GET: /LiveScore/

        public ActionResult Index()
        {
            var scores = db.LiveScores.ToList();

            return PartialView(scores);
        }

    }
}
