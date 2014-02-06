using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CricInfo.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string CommentText { get; set; }
        public DateTime DateCommented { get; set; }
        public int Rating { get; set; }
    }
}