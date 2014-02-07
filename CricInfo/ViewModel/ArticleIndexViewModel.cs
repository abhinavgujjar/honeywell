using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CricInfo.ViewModel
{
    public class ArticleIndexViewModel
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PublishDate { get; set; }
        public double AverageRating { get; set; }

        public int FbLikes { get; set; }
        public int Tweets { get; set; }
        public int PlusShares { get; set; }
    }
}