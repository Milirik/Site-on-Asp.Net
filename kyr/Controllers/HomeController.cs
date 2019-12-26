using kyr.Interfaces;
using kyr.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kyr.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPosts _allposts;
        private readonly IReviews _allreviews;
        private readonly ITags _alltags;

        public HomeController(IPosts _allposts, IReviews _allreviews, ITags _alltags) {
            this._allposts = _allposts;
            this._allreviews = _allreviews;
            this._alltags = _alltags;
        }

        public object CarsLiseViewModel { get; private set; }

        public ViewResult Index() {
            ListViewModel l = new ListViewModel();
            l.allposts = _allposts.allPosts;
            l.allreviews = _allreviews.allReviews;
            l.alltags = _alltags.allTags;
            return View(l);
        }

    }
}
