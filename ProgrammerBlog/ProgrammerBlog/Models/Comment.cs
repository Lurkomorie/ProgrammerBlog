using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammerBlog.Models
{
    public class Comment
    {
        private int Id { get; }
        public int UserId { get; set; }
        public string Body { get; set; }
        public bool Deleted { get; set; }
        public int PostId { get; set; }
    }
}