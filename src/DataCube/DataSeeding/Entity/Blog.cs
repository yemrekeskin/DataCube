using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataSeeding.Entity
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        public string Url { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
