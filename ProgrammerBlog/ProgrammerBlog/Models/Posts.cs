﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgrammerBlog.Models
{
    public class Post
    {
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public bool Deleted { get; set; }
    public int BlogId { get; set; }
    }
}