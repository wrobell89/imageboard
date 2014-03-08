using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageBoard.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HomePage { get; set; }
        public string Description { get; set; }

        public UserProfile UserAccount { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
