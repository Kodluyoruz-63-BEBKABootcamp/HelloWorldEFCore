using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HelloWorldEFCore.Models.DomainModels
{
    public class Blog
    {
        public Blog()
        {
        }

        [Required]
        [Key]
        public int BlogId { get; set; }
        [Required]
        public string Url { get; set; }
        public int Rating { get; set; }

        public List<Post> Posts { get; set; }
    }
}
