using System;
using System.Collections.Generic;
using System.Linq;
using HelloWorldEFCore.Models.DomainModels;

namespace HelloWorldEFCore.Models.Services
{
    public class PostService
    {
        public PostService()
        {
        }

        public int CreatePost(Post post)
        {
            using (var db = new BloggingContext())
            {
                //bool ensure = db.Database.EnsureCreated();

                db.Posts.Add(post);
                db.SaveChanges();
            }

            return post.PostId;
        }

        public List<int> CreateBatchPost(List<Post> list)
        {
            List<int> returnList = new List<int>();

            foreach (var item in list)
            {
               returnList.Add(CreatePost(item));
            }

            return returnList;
        }

        public List<Post> GetAllPosts()
        {
            List<Post> list = new List<Post>();
            using (var db = new BloggingContext())
            {
                //bool ensure = db.Database.EnsureCreated();

                list = db.Posts.ToList();
            }

            return list;
        }

        public List<Post> GetPosts(int blogId)
        {
            List<Post> list = new List<Post>();
            using (var db = new BloggingContext())
            {
                //bool ensure = db.Database.EnsureCreated();

                list = db.Posts.Where(p => p.BlogId == blogId).ToList();
            }

            return list;
        }

        public IQueryable<Post> GetPosts(Func<Post,bool> func)
        {
            IQueryable<Post> list;
            using (var db = new BloggingContext())
            {
                //bool ensure = db.Database.EnsureCreated();

                list = (IQueryable<Post>)db.Posts.Where(func);
            }

            return list;
        }
    }
}
