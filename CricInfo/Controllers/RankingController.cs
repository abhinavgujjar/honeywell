using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using CricInfo.Models;

namespace CricInfo.Controllers
{
    public class RankingController : ApiController
    {
        private CricDbContext db = new CricDbContext();

        // GET api/Ranking
        public IEnumerable<Ranking> GetRankings()
        {
            return db.Rankings.AsEnumerable();
        }

        // GET api/Ranking/5
        public Ranking GetRanking(int id)
        {
            Ranking ranking = db.Rankings.Find(id);
            if (ranking == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return ranking;
        }

        // PUT api/Ranking/5
        public HttpResponseMessage PutRanking(int id, Ranking ranking)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != ranking.Id)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            db.Entry(ranking).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST api/Ranking
        public HttpResponseMessage PostRanking(Ranking ranking)
        {
            if (ModelState.IsValid)
            {
                db.Rankings.Add(ranking);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, ranking);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = ranking.Id }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE api/Ranking/5
        public HttpResponseMessage DeleteRanking(int id)
        {
            Ranking ranking = db.Rankings.Find(id);
            if (ranking == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Rankings.Remove(ranking);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, ranking);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}