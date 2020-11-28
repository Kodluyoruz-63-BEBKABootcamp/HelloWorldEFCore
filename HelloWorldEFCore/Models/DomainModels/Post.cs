using System.ComponentModel.DataAnnotations;

namespace HelloWorldEFCore.Models.DomainModels
{
    public class Post
    {
        public Post()
        {
        }

        [Required]
        [Key]
        public int PostId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
