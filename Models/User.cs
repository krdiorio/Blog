using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[User]")]
    public class User
    {

        public User()
        {
            Roles = new List<Role>(); // ou     => Roles = new List<Role>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string PassWordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }

        [Write(false)]
        public List<Role> Roles { get; set; }
    }
}