using kyr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kyr.ViewModels
{
    public class ListViewModel
    {
        public IEnumerable<Post> allposts { get; set; }
        public IEnumerable<Review> allreviews { get; set; }
        public IEnumerable<Tag> alltags { get; set; }

        public string currCategory { get; set; }
    }
}
