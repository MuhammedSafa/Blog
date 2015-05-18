using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogWithMvc5.Models
{
    public class Comment
    {

        public int Id { get; set; }
        [Required]
        public string makedComment { get; set; }

        [Editable(false)]
        public int ArticleID { get; set; }
    }
}