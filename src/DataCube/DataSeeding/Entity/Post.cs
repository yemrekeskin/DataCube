using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataSeeding.Entity
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }
        public string Title { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public string AuthorName { get; set; }
    }
}
