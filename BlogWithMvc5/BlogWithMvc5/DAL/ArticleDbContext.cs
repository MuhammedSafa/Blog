using BlogWithMvc5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogWithMvc5.DAL
{
    public class ArticleDbContext : DbContext
    {

        public ArticleDbContext() : base("ArticleDbContext") { }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}