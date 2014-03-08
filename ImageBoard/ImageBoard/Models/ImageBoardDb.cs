using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ImageBoard.Models
{
    public class ImageBoardDb : DbContext
    {
        public ImageBoardDb() : base("ImageBoardConn")
        {
            
        }

        public DbSet<UserProfile> Users { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostComment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ForumBoard> ForumBoards { get; set; }
        public DbSet<ForumThread> ForumThreads { get; set; }
        public DbSet<ForumComment> ForumComments { get; set; }
    }
}