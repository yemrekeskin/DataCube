using System;

namespace Blogging
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new BloggingContext())
            {
                var blog = new Blog();
                blog.BlogId = 2;
                //blog.Inserted = DateTime.Now;
                blog.Url = "blog.yemrekeskin.com";

                context.Blogs.Add(blog);
                context.SaveChanges();
            }

            Console.ReadLine();
        }
    }
}
