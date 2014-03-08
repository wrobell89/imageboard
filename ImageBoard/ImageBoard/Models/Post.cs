using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageBoard.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UploadDate { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Size { get; set; }
        public int Score { get; set; }

        public Author Author { get; set; }
        public UserProfile Uploader { get; set; }
        public ICollection<Album> Albums { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<PostComment> Comments { get; set; }        
    }
}
