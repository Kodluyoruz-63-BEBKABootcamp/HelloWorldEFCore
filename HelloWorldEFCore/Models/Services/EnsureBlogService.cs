using System;
using System.Collections.Generic;
using HelloWorldEFCore.Models.DomainModels;

namespace HelloWorldEFCore.Models.Services
{
    public class EnsureBlogService : IBlogService
    {
        public EnsureBlogService()
        {
        }

        public int CreateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAllBlogs()
        {
            throw new NotImplementedException();
        }
    }
}
