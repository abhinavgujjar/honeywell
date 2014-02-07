using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CricInfo.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [DisplayName("Enter the Article Id")]
        public int ArticleId { get; set; }

        public int SecureField { get; set; }

        [Required(ErrorMessage = "Always enter the comment text before proceeding")]
        public string CommentText { get; set; }
        public DateTime DateCommented { get; set; }


        public int Rating { get; set; }
    }
}