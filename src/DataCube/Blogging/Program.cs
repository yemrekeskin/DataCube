using System;

namespace Blogging
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new BloggingContext())
            {
                //var blog = new Blog();
                //blog.BlogId = 2;
                ////blog.Inserted = DateTime.Now;
                //blog.Url = "blog.yemrekeskin.com";

                //context.Blogs.Add(blog);
                //context.SaveChanges();


                var post = new Post()
                {
                    BlogId = 1,
                    Content = "DDD",
                    PostType = PostType.Value1,
                    Title = "zsdfzsdf"
                };
                context.Posts.Add(post);
                context.SaveChanges();
            }

            Console.ReadLine();
        }
    }
}
