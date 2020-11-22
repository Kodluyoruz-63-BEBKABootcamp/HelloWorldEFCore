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
    }
}
