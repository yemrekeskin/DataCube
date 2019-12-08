using System;
using System.Collections.Generic;
using System.Text;

namespace Blogging
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public PostType PostType { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }

    public enum PostType
    {
        Value1,
        Value2
    }
}
