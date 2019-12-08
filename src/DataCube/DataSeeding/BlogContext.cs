using DataSeeding.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DataSeeding.SeedData;

namespace DataSeeding
{
    public class BlogContext
        : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=BlogDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Option 1
            //modelBuilder.Entity<Blog>()
            //    .HasData(new Blog { BlogId = 1, Url = "http://sample.com" });
            
            //modelBuilder.Entity<Post>()
            //    .HasData(new Post() { BlogId = 1, Id = 1, Title = "First post", Content = "Test 1" });
            
            // Seed Option 2
            modelBuilder.Entity<Blog>().HasData(DefaultBlog.AllBlogs().ToArray());
            modelBuilder.Entity<Post>().HasData(DefaultPost.AllPosts().ToArray());


            base.OnModelCreating(modelBuilder);
        }
    }
}
