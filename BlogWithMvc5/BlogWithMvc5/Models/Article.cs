using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogWithMvc5.Models
{
    public class Article
    {

        public Article()
        {
            date = DateTime.Now;
        }


        public int Id { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Content { get; set; }

        public string Picture { get; set; }

        [Editable(false)]
        public DateTime date { get; set; }

        public virtual ICollection<Comment> MyProperty { get; set; }

    }
}