using System.Collections.Generic;
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
                bool ensure = db.Database.EnsureCreated();

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
    }
}
