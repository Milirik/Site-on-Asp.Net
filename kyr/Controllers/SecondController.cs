using kyr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kyr.ViewModels;
using kyr.Models;

namespace kyr.Controllers
{ 
    public class SecondController : Controller
    {
        private readonly IPosts _allposts;
        private readonly IReviews _allreviews;
        private readonly ITags _alltags;

        public SecondController(IPosts _allposts, IReviews _allreviews, ITags _alltags)
        {
            this._allposts = _allposts;
            this._allreviews = _allreviews;
            this._alltags = _alltags;
        }

        public ViewResult About()
        {
            return View();
        }


        public ViewResult Contact()
        {
            return View();
        }

        [Route("Second/List")]
        [Route("Second/List/{tag}")]
        public ViewResult List(string tag)
        {
            IEnumerable<Post> posts = null;

            ListViewModel l = new ListViewModel();
            //foreach (Post post in _allposts.allPosts) {
            //    if (post.Tag.Name == tag)
            //        posts = posts.Concat(new[] { post });
            //}
            posts = _allposts.allPosts.Where(i => i.Tag.Name == tag);
            ViewBag.h = tag;
            l.allposts = posts;
            l.allreviews = _allreviews.allReviews;
            l.alltags = _alltags.allTags;

            return View(l);
        }
    }
}
