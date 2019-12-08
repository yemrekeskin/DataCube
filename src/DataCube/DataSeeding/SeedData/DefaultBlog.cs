using DataSeeding.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataSeeding.SeedData
{
    public class DefaultBlog
    {
        public static List<Blog> AllBlogs()
        {
            List<Blog> blogs = new List<Blog>();
            blogs.Add(Blog1);
            blogs.Add(Blog2);

            return blogs;
        }

        public static readonly Blog Blog1 = new Blog
        {
            BlogId = 1,
            Url = "http://sample.com"
        };

        public static readonly Blog Blog2 = new Blog
        {
            BlogId = 2,
            Url = "http://blog.sample.com"
        };
    }
}
