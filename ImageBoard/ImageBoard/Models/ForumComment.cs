using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageBoard.Models
{
    public class ForumComment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public UserProfile Author { get; set; }
    }
}
