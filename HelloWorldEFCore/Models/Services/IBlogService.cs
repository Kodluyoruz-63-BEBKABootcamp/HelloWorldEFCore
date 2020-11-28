using System.Collections.Generic;
using HelloWorldEFCore.Models.DomainModels;

namespace HelloWorldEFCore.Models.Services
{
    public interface IBlogService
    {
        public List<Blog> GetAllBlogs();
        public int CreateBlog(Blog blog);
    }
}
