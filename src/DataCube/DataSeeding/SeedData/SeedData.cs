using DataSeeding.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataSeeding.SeedData
{
    public class SeedData
    {
        public static Blog[] BuildBlogs()
        {
            return DefaultBlog.AllBlogs().ToArray();
        }
         
        public static Post[] BuildPosts()
        {
            return DefaultPost.AllPosts().ToArray();
        }
    }
}
