using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kyr.Models
{
    public class Tag
    {
        public string Name { set; get; }
        public List<Post> posts { set; get; }
    }
}
