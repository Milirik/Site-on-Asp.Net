using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kyr.Models
{
    public class Post
    {
        public int id { set; get; }
        public string img { set; get; }
        public string title { set; get; }
        public string text { set; get; }
        public virtual Tag Tag { set; get; }
    }
}
