using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageBoard.Models
{
    public class ForumBoard
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ForumThread> Threads { get; set; }
    }
}
