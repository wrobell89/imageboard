using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageBoard.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
