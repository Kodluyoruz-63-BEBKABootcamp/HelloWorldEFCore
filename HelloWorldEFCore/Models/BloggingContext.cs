using HelloWorldEFCore.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace HelloWorldEFCore.Models
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
            optionsBuilder.UseSqlServer(@"");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().ToTable("Blogs").HasKey(blog => blog.BlogId);
            modelBuilder.Entity<Blog>().Property(blog => blog.BlogId).IsRequired();
            modelBuilder.Entity<Blog>().Property(blog => blog.Url).IsRequired();

            modelBuilder.Entity<Post>().ToTable("Posts").HasKey(post => post.PostId);
            modelBuilder.Entity<Post>().Property(post => post.PostId).IsRequired();
            modelBuilder.Entity<Post>().Property(post => post.Title).IsRequired();
        }
    }
}