using System;
using System.Collections.Generic;
using HelloWorldEFCore.Models.DomainModels;

namespace HelloWorldEFCore.Models.Services
{
    public class FakeBlogService : IBlogService
    {
        public FakeBlogService()
        {
        }

        public int CreateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAllBlogs()
        {
            return new List<Blog>()
            { new Blog() { BlogId=1, Url="testurl"},
            new Blog() { BlogId=2, Url="testurl2" } };
        }
    }
}
