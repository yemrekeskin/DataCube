using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conventions.MyBlogContext
{
    /// <summary>
    /// IncludedTypes, InheritanceDbSets
    /// </summary>
    public class MyBlogContext 
        : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<RssBlog> RssBlogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditEntry>();

            base.OnModelCreating(modelBuilder);
        }

    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; set; }
    }

    public class RssBlog : Blog
    {
        public string RssUrl { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public Blog Blog { get; set; }
    }

    public class AuditEntry
    {
        public int AuditEntryId { get; set; }
        public string Username { get; set; }
        public string Action { get; set; }
    }
}
