using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageBoard.Models
{
    public class ForumThread
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Views { get; set; }

        public UserProfile Author { get; set; }
    }
}
