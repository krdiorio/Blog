using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("Post")]
    public class Post
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdadeDate { get; set; }
        public List<Category> Categories { get; set; }
        public List<User> Authors { get; set; }


    }
}