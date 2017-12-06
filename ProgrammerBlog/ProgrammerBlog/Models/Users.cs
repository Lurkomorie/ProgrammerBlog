using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammerBlog.Models
{
    public class User
    {
        private int Id { get; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
        public bool Deleted { get; set; }

        public ICollection<Role> Roles { get; set; }
        
        public User() {
            Roles = new List<Role>();
        }
        }

}