using DataSeeding.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataSeeding.SeedData
{
    public class DefaultPost
    {
        public static List<Post> AllPosts()
        {
            List<Post> posts = new List<Post>();
            posts.Add(Post1);
            posts.Add(Post2);

            return posts;
        }

        public static readonly Post Post1 = new Post
        {
            BlogId = 1,
            Id = 1,
            Title = "First post",
            Content = "Test 1"
        };

        public static readonly Post Post2 = new Post
        {
            BlogId = 2,
            Id = 2,
            Title = "Second post",
            Content = "Test 2"
        };
    }
}
