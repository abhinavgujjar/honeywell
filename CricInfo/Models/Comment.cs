using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CricInfo.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }

        [Required]
        public string CommentText { get; set; }
        public DateTime DateCommented { get; set; }
        public int Rating { get; set; }
    }
}