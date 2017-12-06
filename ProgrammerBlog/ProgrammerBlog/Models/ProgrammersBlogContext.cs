using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProgrammerBlog.Models
{
    public class ProgrammersBlogContext : DbContext
    {
        public ProgrammersBlogContext() : base("ProgrammersBlogContext") { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<User>()
            .HasMany(e => e.Users)
            .WithMany(e => e.Roles)
            .Map(m => m.ToTable("UsersRoles").MapLeftKey("UserId").MapRightKey("RoleId"));
        }
    }
}