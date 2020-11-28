using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using HelloWorldEFCore.Models.Services;
using HelloWorldEFCore.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HelloWorldEFCore.Models;

namespace HelloWorldEFCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        BlogService blogService = new BlogService();
        PostService postService = new PostService();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            /*
            BloggingContext context = new BloggingContext();
            context.Posts.Add(new Models.DomainModels.Post() { PostId = 1, Title = "Test", Content = "First Blog Post" });
            context.SaveChanges();
            */

            Blog blog = new Blog() { Url = "blogs.com/" + Guid.NewGuid(), Rating = 5 };
            int id = blogService.CreateBlog(blog);


            Random rnd = new Random();
            var post1 = new Post() { Title = "Test", Content = "First Blog Post" + rnd.Next().ToString(), BlogId = id };
            var post2 = new Post() { Title = "My Post", Content = "Second Blog Post", BlogId = id };
            List<Post> myPosts = new List<Post>();
            myPosts.Add(post1);
            myPosts.Add(post2);

            var list = postService.CreateBatchPost(myPosts);

            return View();
        }

        public IActionResult ListBlog()
        {
            var list = blogService.GetAllBlogs();

            return View(list);
        }

        public IActionResult ListPost()
        {
            var list = postService.GetAllPosts();

            return View(list);
        }

        public IActionResult ListBlogDetail(int id)
        {
            var list = postService.GetPosts(id);

            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
