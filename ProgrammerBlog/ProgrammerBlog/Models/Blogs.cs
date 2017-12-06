using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammerBlog.Models
{
    public class Blog
    {
        private int Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
    }
}