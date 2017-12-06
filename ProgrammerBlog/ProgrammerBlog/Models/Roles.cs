using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammerBlog.Models
{
    public class Role
    {
        private int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
        public ICollection<object> Roles { get; internal set; }
        
        public Role() {
            User = new List<User>();
        }    
        }
}