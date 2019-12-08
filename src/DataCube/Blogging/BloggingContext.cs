using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Blogging
{

    public class BloggingContext
        : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=BlogTestDb;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Timestamp/row version
            modelBuilder.Entity<Blog>()                              
                .Property(p => p.Timestamp)
                .IsRowVersion();

            modelBuilder.Entity<Blog>()
                .HasIndex(d => d.Url)
                .IsUnique();

            var convert = new EnumToStringConverter<PostType>();

            modelBuilder.Entity<Post>()
                .Property(d => d.PostType)
                .HasConversion(convert);

            base.OnModelCreating(modelBuilder);
        }
    }
}
