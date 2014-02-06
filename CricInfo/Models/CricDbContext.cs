using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CricInfo.Models
{
    public class CricDbContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
    }
}