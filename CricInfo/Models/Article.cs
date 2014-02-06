using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CricInfo.Models
{
    public class Article
    {
        public Article()
        {
            IsGoodArticle = true;
        }
        public int Id { get; set; }

        [DisplayName("Written By")]
        public string Author { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime DatePublished { get; set; }

        public bool IsGoodArticle { get; set; }
    }
}