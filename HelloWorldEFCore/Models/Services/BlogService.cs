using System.Collections.Generic;
using System.Linq;
using HelloWorldEFCore.Models.DomainModels;

namespace HelloWorldEFCore.Models.Services
{
    public class BlogService
    {
        public BlogService()
        {
        }

        public int CreateBlog(Blog blog)
        {
            using (var db = new BloggingContext())
            {
                bool ensure = db.Database.EnsureCreated();

                db.Blogs.Add(blog);
                db.SaveChanges();
            }

            return blog.BlogId;
        }

        public List<Blog> GetAllBlogs()
        {
            List<Blog> list = new List<Blog>();
            using (var db = new BloggingContext())
            {
                bool ensure = db.Database.EnsureCreated();

                list = db.Blogs.ToList();
            }

            return list;
        }
    }
}
